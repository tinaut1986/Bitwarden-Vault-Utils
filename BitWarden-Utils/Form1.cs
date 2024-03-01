using BitwardenVaultCLI_API.Controller;
using BitwardenVaultCLI_API.Model;
using System.Drawing.Imaging;

namespace BitWarden_Utils
{
    public partial class Form1 : Form
    {
        private string client_id = "user.YourClientID";       //see https://bitwarden.com/help/public-api/
        private string client_secret = "YourClientSecret";    //see https://bitwarden.com/help/public-api/
        private string email = "yourmail@yourdomain.com";
        private string password = "Sup3rS3cr3tP@ssw0rd";
        private int otp2FA = 999999;                                //it's not mandatory, but highly recommended
        private string url = "https://yourownserver.youdomain.com"; //default: https://vault.bitwarden.com

        private BitwardenCLI? bitwarden;
        private List<Item>? loadedItems;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            bool cursorChanged = false;
            try
            {
                cursorChanged = SetWaitCursor();

                if (loadedItems == null)
                    loadedItems = bitwarden?.ListItems().Where(x => x.type == (int)ItemType.Login).ToList();

                gridResults.DataSource = loadedItems?.Where(x => MatchFilter(x, txtFilter.Text)).ToList();
            }
            catch
            {

            }
            finally
            {
                if (cursorChanged)
                    SetDefaultCursor();
            }
        }

        private void RefreshData()
        {
            Connect();
            loadedItems = null;
            Search();
        }

        private bool CleanURLs(Login? login)
        {
            if (login == null)
                return false;

            bool cursorChanged = false;
            try
            {
                cursorChanged = SetWaitCursor();
                bool modified = false;
                List<BitwardenVaultCLI_API.Model.Uri> deletedUris = new List<BitwardenVaultCLI_API.Model.Uri>();

                foreach (BitwardenVaultCLI_API.Model.Uri uri in login.uris.ToList())
                {
                    if (deletedUris.Contains(uri))
                        continue;

                    // Caution! With ToList(), URI1 can delete URI2 and URI2 delete URI1 after that.
                    foreach (BitwardenVaultCLI_API.Model.Uri uriToDelete in login.uris.ToList())
                    {
                        if (uri == uriToDelete)
                            continue;

                        if (deletedUris.Contains(uriToDelete))
                            continue;

                        if (!DeleteURI(uriToDelete, uri))
                            continue;

                        login.uris.Remove(uriToDelete);
                        deletedUris.Add(uriToDelete);
                        modified = true;
                    }
                }

                return modified;
            }
            catch (Exception error)
            {
                Console.WriteLine($"Fail: {error.Message}");
                throw;
            }
            finally
            {
                if (cursorChanged)
                    SetDefaultCursor();
            }
        }

        private bool DeleteURI(BitwardenVaultCLI_API.Model.Uri uriToDelete, BitwardenVaultCLI_API.Model.Uri uriToCheck)
        {
            List<string> ListToDelete = uriToDelete.uri.Split('/', StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> ListToCheck = uriToCheck.uri.Split('/', StringSplitOptions.RemoveEmptyEntries).ToList();

            if (ListToDelete.Count < ListToCheck.Count)
                return false;

            for (int i = 0; i < ListToCheck.Count; i++)
            {
                if (ListToCheck[i] != ListToDelete[i])
                    return false;
            }

            return true;
        }

        private void Connect()
        {
            bool cursorChanged = false;
            try
            {
                cursorChanged = SetWaitCursor();

                Console.Write("Trying logging into Bitwarden ... ");

                bitwarden = new BitwardenCLI(url, email, password);

                Console.WriteLine("Success!");
            }
            catch (Exception error)
            {
                Console.WriteLine($"Fail: {error.Message}");
            }
            finally
            {
                if (cursorChanged)
                    SetDefaultCursor();
            }

        }

        private void Merge(List<Item> items)
        {
            bool cursorChanged = false;
            try
            {
                cursorChanged = SetWaitCursor();

                bool collectionModified = false;
                var groupedItems = items.GroupBy(item => new { username = item.lowerLoginUsername, password = item.loginPassword })
                                        .Select(group => new
                                        {
                                            Username = group.Key.username,
                                            Password = group.Key.password,
                                            Items = group.ToList()
                                        })
                                        .ToList();

                foreach (var groupedItem in groupedItems)
                {
                    Item firstItem = groupedItem.Items.First();

                    bool modified = false;
                    foreach (Item item in groupedItem.Items.Skip(1).ToList())
                    {
                        firstItem.revisionDate = new DateTime(Math.Max(firstItem.revisionDate.Ticks, item.revisionDate.Ticks));

                        firstItem.CopyURLs(item);
                        firstItem.CopyNotes(item);
                        firstItem.CopyAttachment(item);
                        CleanURLs(firstItem.login);

                        bitwarden?.DeleteItem(item.id);
                        loadedItems?.Remove(item);
                        items?.Remove(item);
                        modified = true;
                        collectionModified = true;
                    }

                    if (modified)
                        bitwarden?.EditItem(firstItem);
                }

                if (collectionModified)
                    gridResults.DataSource = loadedItems?.Where(x => MatchFilter(x, txtFilter.Text)).ToList();
            }
            catch (Exception error)
            {
                Console.WriteLine($"Fail: {error.Message}");
                throw;
            }
            finally
            {
                if (cursorChanged)
                    SetDefaultCursor();
            }
        }

        private bool MatchFilter(Item item, string filter)
        {
            string upperFilter = (filter ?? "").ToUpper();
            string itemUpperName = (item.name ?? "").ToUpper();
            bool containsName = itemUpperName.Contains(upperFilter);

            bool containsURI = false;
            if (item.login != null)
                containsURI = item.login.uris.Any(x => (x.uri ?? "").ToUpper().Contains(upperFilter));

            return containsName || containsURI;
        }

        private void SetDefaultCursor()
        {
            Cursor = Cursors.Default;
        }

        private bool SetWaitCursor()
        {
            if (Cursors.WaitCursor == Cursor)
                return false;

            Cursor = Cursors.WaitCursor;
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridResults.AutoGenerateColumns = false;
            gridURIs.AutoGenerateColumns = false;
            gridURIs.AutoGenerateColumns = false;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {
                Connect();
            }
            catch (Exception error)
            {
                Console.WriteLine($"Fail: {error.Message}");
                throw;
            }
            finally
            {
            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                Search();
        }

        private void gridResults_SelectionChanged(object sender, EventArgs e)
        {
            gridURIs.DataSource = ((Item)gridResults.CurrentRow.DataBoundItem).login.uris.ToList();
        }

        private void mergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedIRows = gridResults.SelectedRows;
            List<Item> selectedItems = selectedIRows.Cast<DataGridViewRow>().Select(x => x.DataBoundItem).Cast<Item>().ToList();

            Merge(selectedItems);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void cleanURIsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Item item = (Item)gridResults.CurrentRow.DataBoundItem;

            if (CleanURLs(item?.login))
                bitwarden?.EditItem(item);
        }
    }
}
