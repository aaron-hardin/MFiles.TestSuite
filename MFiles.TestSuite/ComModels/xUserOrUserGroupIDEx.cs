using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace VaultMockObjects.ComModels
{
    public class xUserOrUserGroupIDEx
    {
        public xIndirectPropertyIDLevel[] IndirectProperty { get; set; }
        public int UserOrGroupID { get; set; }
        public int UserOrGroupType { get; set; }
        public int WorkflowState { get; set; }

        public xUserOrUserGroupIDEx() { }

        public xUserOrUserGroupIDEx(UserOrUserGroupIDEx uoug)
        {
            try
            {
                this.IndirectProperty = (from IndirectPropertyIDLevel idpLevel in uoug.IndirectProperty select new xIndirectPropertyIDLevel(idpLevel)).ToArray();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            this.UserOrGroupID = uoug.UserOrGroupID;
            this.UserOrGroupType = (int) uoug.UserOrGroupType;
            this.WorkflowState = uoug.WorkflowState;
        }
    }
}
