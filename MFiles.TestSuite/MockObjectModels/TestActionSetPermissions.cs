using MFiles.VaultJsonTools.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestActionSetPermissions : ActionSetPermissions
    {
        public TestActionSetPermissions() { }

        public TestActionSetPermissions(xActionSetPermissions asp)
        {
            this.DiscardsAutomaticPermissions = asp.DiscardsAutomaticPermissions;
            this.Permissions = new TestAccessControlList(asp.Permissions);
        }

        public ActionSetPermissions Clone()
        {
            TestActionSetPermissions asp = new TestActionSetPermissions
            {
                DiscardsAutomaticPermissions = this.DiscardsAutomaticPermissions,
                Permissions = this.Permissions.Clone()
            };
            return asp;
        }

        public bool DiscardsAutomaticPermissions { get; set; }

        public AccessControlList Permissions { get; set; }
    }
}
