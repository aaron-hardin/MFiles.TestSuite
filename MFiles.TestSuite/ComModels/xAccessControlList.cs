using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.ComModels
{
    public class xAccessControlList
    {
        // not implemented as it has no public properties
        // public xAccessControlListComponentContainer AutomaticComponents { get; set; }
        public int CheckedOutToUserID { get; set; }
        public xAccessControlListComponent CustomComponent { get; set; }
        public bool HasCheckedOutToUserID { get; set; }
        public bool IsFullyAuthoritative { get; set; }

        public xAccessControlList(AccessControlList acl)
        {
            if(acl == null) return;

            //this.AutomaticComponents = new xAccessControlListComponentContainer(acl.AutomaticComponents);
            this.CheckedOutToUserID = acl.CheckedOutToUserID;
            this.CustomComponent = new xAccessControlListComponent(acl.CustomComponent);
            this.HasCheckedOutToUserID = acl.HasCheckedOutToUserID;
            this.IsFullyAuthoritative = acl.IsFullyAuthoritative;
        }
    }
}
