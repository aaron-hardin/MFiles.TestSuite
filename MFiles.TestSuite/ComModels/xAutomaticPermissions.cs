using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace VaultMockObjects.ComModels
{
    public class xAutomaticPermissions
    {
        public bool CanDeactivate { get; set; }
        public bool IsBasedOnObjectACL { get; set; }
        public bool IsDefault { get; set; }
        public xNamedACL NamedACL { get; set; }

        public xAutomaticPermissions(AutomaticPermissions autoPerms)
        {
            if (autoPerms != null)
            {
                this.CanDeactivate = autoPerms.CanDeactivate;
                this.IsBasedOnObjectACL = autoPerms.IsBasedOnObjectACL;
                this.IsDefault = autoPerms.IsDefault;
                this.NamedACL = new xNamedACL(autoPerms.NamedACL);
            }
        }
    }
}
