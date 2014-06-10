using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using MFiles.TestSuite.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestUserOrUserGroupIDEx : UserOrUserGroupIDEx
    {
        public TestUserOrUserGroupIDEx() { }

        public TestUserOrUserGroupIDEx(xUserOrUserGroupIDEx uoug)
        {
            try
            {
                this.IndirectProperty = new IndirectPropertyID();
                foreach (xIndirectPropertyIDLevel level in uoug.IndirectProperty)
                {
                    this.IndirectProperty.Add(-1, new TestIndirectPropertyIDLevel(level));
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            this.UserOrGroupID = uoug.UserOrGroupID;
            this.UserOrGroupType = (MFUserOrUserGroupType)uoug.UserOrGroupType;
            this.WorkflowState = uoug.WorkflowState;
        }

        public UserOrUserGroupIDEx Clone()
        {
            TestUserOrUserGroupIDEx uoug = new TestUserOrUserGroupIDEx();
            uoug.IndirectProperty = new IndirectPropertyID();
            if (this.IndirectProperty != null)
            {
                for (int i=1 ; i<= this.IndirectProperty.Count ; ++i)
                {
                    IndirectPropertyIDLevel level = this.IndirectProperty[i];
                    uoug.IndirectProperty.Add(-1, level.Clone());
                }
            }
            uoug.UserOrGroupID = this.UserOrGroupID;
            uoug.UserOrGroupType = this.UserOrGroupType;
            uoug.WorkflowState = this.WorkflowState;
            return uoug;
        }

        public IndirectPropertyID IndirectProperty { get; set; }

        public void SetIndirectPropertyPseudoUser(IndirectPropertyID PseudoUserID)
        {
            throw new NotImplementedException();
        }

        public void SetUserAccount(int UserAccount)
        {
            throw new NotImplementedException();
        }

        public void SetUserGroup(int UserGroup)
        {
            throw new NotImplementedException();
        }

        public void SetWorkflowStatePseudoUser(int WorkflowState)
        {
            throw new NotImplementedException();
        }

        public int UserOrGroupID { get; set; }

        public MFUserOrUserGroupType UserOrGroupType { get; set; }

        public int WorkflowState { get; set; }
    }
}
