using MFiles.VaultJsonTools.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestActionSendNotification : ActionSendNotification
    {
        public TestActionSendNotification() { }

        public TestActionSendNotification(xActionSendNotification asn)
        {
            this.Message = asn.Message;
            this.RecipientsEx = new UserOrUserGroupIDExs();
            foreach (xUserOrUserGroupIDEx userGroupIdEx in asn.RecipientsEx)
            {
                this.RecipientsEx.Add(-1, new TestUserOrUserGroupIDEx(userGroupIdEx));
            }
            this.Subject = asn.Subject;
        }

        public ActionSendNotification Clone()
        {
            TestActionSendNotification asn = new TestActionSendNotification
            {
                Message = this.Message,
                RecipientsEx = new UserOrUserGroupIDExs(),
                Subject = this.Subject
            };
            for (int i = 1; i <= this.RecipientsEx.Count; ++i)
            {
                UserOrUserGroupIDEx userGroupIdEx = this.RecipientsEx[i];
                asn.RecipientsEx.Add(-1, userGroupIdEx.Clone());
            }
            return asn;
        }

        public string Message { get; set; }

        public UserOrUserGroupIDs Recipients { get; set; }

        public UserOrUserGroupIDExs RecipientsEx { get; set; }

        public string Subject { get; set; }
    }
}
