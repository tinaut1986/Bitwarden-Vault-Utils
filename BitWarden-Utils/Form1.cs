using BitwardenVaultCLI_API.Controller;
using BitwardenVaultCLI_API.Model;
using Microsoft.VisualBasic.Devices;

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

        private BitwardenCLI bitwarden;
        private List<Item> items;

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
            try
            {
                SetWaitCursor();

                if (items == null)
                    items = bitwarden.ListItems().Where(x => x.type == (int)ItemType.Login).ToList();

                gridResults.DataSource = items.Where(x => MatchFilter(x, txtFilter.Text)).ToList();
            }
            catch
            {

            }
            finally
            {
                SetDefaultCursor();
            }
        }

        private void RefreshData()
        {
            Connect();
            Search();
        }

        private void Connect()
        {
            SetWaitCursor();

            Console.Write("Trying logging into Bitwarden ... ");

            items = null;

            bitwarden = new BitwardenCLI(url, email, password);

            Console.WriteLine("Success!");
        }

        private void Merge()
        {
            try
            {
                SetWaitCursor();
                DataGridViewSelectedRowCollection selectedIRows = gridResults.SelectedRows;
                List<Item> selectedItems = selectedIRows.Cast<DataGridViewRow>().Select(x => x.DataBoundItem).Cast<Item>().ToList();

                bool collectionModified = false;
                var groupedItems = selectedItems.GroupBy(item => new { username = item.lowerLoginUsername, password = item.loginPassword })
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

                        bitwarden.DeleteItem(item.id);
                        items.Remove(item);
                        modified = true;
                        collectionModified = true;
                    }

                    if (modified)
                        bitwarden.EditItem(firstItem);
                }

                if (collectionModified)
                    gridResults.DataSource = items.Where(x => MatchFilter(x, txtFilter.Text)).ToList();
            }
            catch (Exception ex)
            {

            }
            finally
            {
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

        private void SetWaitCursor()
        {
            Cursor = Cursors.WaitCursor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridResults.AutoGenerateColumns = false;
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
                return;
            }
            finally
            {
                SetDefaultCursor();
            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                Search();
        }

        private void gridResults_SelectionChanged(object sender, EventArgs e)
        {
            gridURLs.DataSource = ((Item)gridResults.CurrentRow.DataBoundItem).login.uris.ToList();
        }

        private void mergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Merge();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
