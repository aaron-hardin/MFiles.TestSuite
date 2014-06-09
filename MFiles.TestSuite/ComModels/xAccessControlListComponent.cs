using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace VaultMockObjects.ComModels
{
    public class xAccessControlListComponent
    {
        public xAccessControlEntryContainer AccessControlEntries { get; set; }
        public bool CanDeactivate { get; set; }
        public int CurrentUserBinding { get; set; }
        public bool HasCurrentUser { get; set; }
        public bool HasCurrentUserBinding { get; set; }
        public bool HasNamedACLLink { get; set; }
        public bool HasPseudoUsers { get; set; }
        public bool IsActive { get; set; }
        public int NamedACLLink { get; set; }

        public xAccessControlListComponent(AccessControlListComponent aclComponent)
        {
            if (aclComponent == null)
                return;
            this.AccessControlEntries = new xAccessControlEntryContainer(aclComponent.AccessControlEntries);
            this.CanDeactivate = aclComponent.CanDeactivate;
            this.CurrentUserBinding = aclComponent.CurrentUserBinding;
            this.HasCurrentUser = aclComponent.HasCurrentUser;
            this.HasCurrentUserBinding = aclComponent.HasCurrentUserBinding;
            this.HasNamedACLLink = aclComponent.HasNamedACLLink;
            this.HasPseudoUsers = aclComponent.IsActive;
            this.IsActive = aclComponent.IsActive;
            this.NamedACLLink = aclComponent.NamedACLLink;
        }
    }
}
