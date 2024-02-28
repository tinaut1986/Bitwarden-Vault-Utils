using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BitwardenVaultCLI_API.Model
{
    [DebuggerDisplay("Username = {username}")]
    public class Login
    {
        public List<Uri> uris { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public object totp { get; set; }
        public object passwordRevisionDate { get; set; }
    }

    [DebuggerDisplay("Name = {name}")]
    public class Item
    {
        public string @object { get; set; }
        public string id { get; set; }
        public string organizationId { get; set; }
        public object folderId { get; set; }
        public int type { get; set; }
        public int reprompt { get; set; }
        public string name { get; set; }
        public string notes { get; set; }
        public bool favorite { get; set; }
        public Login login { get; set; }
        public List<string> collectionIds { get; set; }
        public List<Attachment> attachments { get; set; }
        public DateTime revisionDate { get; set; }
        public object deletedDate { get; set; }

        public string loginUsername => login?.username ?? "";
        public string lowerLoginUsername => loginUsername.ToLower();
        public string loginPassword => login?.password ?? "";

        public void CopyURLs(Item sourceItem)
        {
            if (login.uris == sourceItem.login.uris)
                return;

            if (sourceItem.login.uris != null)
            {
                if (login.uris == null)
                    login.uris = new List<BitwardenVaultCLI_API.Model.Uri>();

                login.uris.AddRange(sourceItem.login.uris);
            }
        }

        public void CopyNotes(Item sourceItem)
        {
            if (notes == sourceItem.notes)
                return;

            if (sourceItem.notes != null)
            {
                if (notes == null)
                    notes = sourceItem.notes;
                else
                    notes += Environment.NewLine + sourceItem.notes;
            }
        }

        public void CopyAttachment(Item sourceItem)
        {
            if (attachments == sourceItem.attachments)
                return;

            if (sourceItem.attachments != null)
            {
                if (attachments == null)
                    attachments = new List<Attachment>();

                attachments.AddRange(sourceItem.attachments);
            }
        }
    }

    [DebuggerDisplay("Uri = {uri}")]
    public class Uri
    {
        public object match { get; set; }
        public string uri { get; set; }
    }

    [DebuggerDisplay("Name = {name}")]
    public class Field
    {
        public string name { get; set; }
        public string value { get; set; }
        public int type { get; set; }
    }

    [DebuggerDisplay("Name = {fileName}")]
    public class Attachment
    {
        public string id { get; set; }
        public string fileName { get; set; }
        public string size { get; set; }
        public string sizeName { get; set; }
        public string url { get; set; }
    }
}
