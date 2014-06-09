using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace VaultMockObjects.ComModels
{
    public class xActionSetPermissions
    {
        public bool DiscardsAutomaticPermissions { get; set; }
        public xAccessControlList Permissions { get; set; }

        public xActionSetPermissions() { }

        public xActionSetPermissions(ActionSetPermissions asp)
        {
            this.DiscardsAutomaticPermissions = asp.DiscardsAutomaticPermissions;
            this.Permissions = new xAccessControlList(asp.Permissions);
        }
    }
}
