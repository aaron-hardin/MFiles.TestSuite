using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFiles.TestSuite.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestAccessControlListComponent : AccessControlListComponent
    {
        public TestAccessControlListComponent() { }

        public TestAccessControlListComponent(xAccessControlListComponent component)
        {
            if(component == null)
                return;
            this.AccessControlEntries = new TestAccessControlEntryContainer(component.AccessControlEntries);
            this.CanDeactivate = component.CanDeactivate;
            this.CurrentUserBinding = component.CurrentUserBinding;
            this.HasCurrentUser = component.HasCurrentUser;
            this.HasCurrentUserBinding = component.HasCurrentUserBinding;
            this.HasNamedACLLink = component.HasNamedACLLink;
            this.HasPseudoUsers = component.HasPseudoUsers;
            this.IsActive = component.IsActive;
            this.NamedACLLink = component.NamedACLLink;
        }

        public AccessControlEntryContainer AccessControlEntries { get; set; }

        public bool CanDeactivate { get; set; }

        public AccessControlListComponent Clone()
        {
            TestAccessControlListComponent component = new TestAccessControlListComponent
            {
                AccessControlEntries = this.AccessControlEntries.Clone(),
                CanDeactivate = this.CanDeactivate,
                CurrentUserBinding = this.CurrentUserBinding,
                HasCurrentUser = this.HasCurrentUser,
                HasCurrentUserBinding = this.HasCurrentUserBinding,
                HasNamedACLLink = this.HasNamedACLLink,
                HasPseudoUsers = this.HasPseudoUsers,
                IsActive = this.IsActive,
                NamedACLLink = this.NamedACLLink
            };
            return component;
        }

        public int CurrentUserBinding { get; set; }

        public AccessControlEntryData GetACEByUserOrGroupID(int UserOrGroupID, bool IsGroup)
        {
            throw new NotImplementedException();
        }

        public AccessControlEntryKey GetACEKeyByUserOrGroupID(int UserOrGroupID, bool IsGroup)
        {
            throw new NotImplementedException();
        }

        public bool HasCurrentUser { get; set; }

        public bool HasCurrentUserBinding { get; set; }

        public bool HasNamedACLLink { get; set; }

        public bool HasPseudoUsers { get; set; }

        public bool IsActive { get; set; }

        public int NamedACLLink { get; set; }

        public void ResetCurrentUserBinding()
        {
            throw new NotImplementedException();
        }

        public void ResetNamedACLLink()
        {
            throw new NotImplementedException();
        }
    }
}
