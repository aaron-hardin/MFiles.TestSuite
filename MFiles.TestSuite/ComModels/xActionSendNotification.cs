using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace VaultMockObjects.ComModels
{
    public class xActionSendNotification
    {
        public string Message { get; set; }
        public xUserOrUserGroupIDEx[] RecipientsEx { get; set; }
        public string Subject { get; set; }

        public xActionSendNotification() { }

        public xActionSendNotification(ActionSendNotification asn)
        {
            this.Message = asn.Message;
            List<xUserOrUserGroupIDEx> recipients = new List<xUserOrUserGroupIDEx>();
            foreach (UserOrUserGroupIDEx recipient in asn.RecipientsEx)
            {
                xUserOrUserGroupIDEx nonComRecipient = new xUserOrUserGroupIDEx(recipient);
                recipients.Add(nonComRecipient);
            }
            //this.RecipientsEx = (from UserOrUserGroupIDEx recipient in asn.Recipients select new xUserOrUserGroupIDEx(recipient)).ToArray();
            this.RecipientsEx = recipients.ToArray();
            this.Subject = asn.Subject;
        }
    }
}
