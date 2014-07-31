using System;
using System.Collections;
using MFiles.VaultJsonTools.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestAccessControlList : AccessControlList
    {
        public TestAccessControlList() { }

        public TestAccessControlList(xAccessControlList controlList)
        {
            this.CheckedOutToUserID = controlList.CheckedOutToUserID;
            this.CustomComponent = new TestAccessControlListComponent(controlList.CustomComponent);
            this.HasCheckedOutToUserID = controlList.HasCheckedOutToUserID;
            this.IsFullyAuthoritative = controlList.IsFullyAuthoritative;
        }

        public void Add(int Index, AccessControlEntry AccessControlEntry)
        {
            throw new NotImplementedException();
        }

        public AccessControlListComponentContainer AutomaticComponents { get; set; }

        public int CheckedOutToUserID { get; set; }

        public AccessControlList Clone()
        {
            TestAccessControlList controlList = new TestAccessControlList
            {
                CheckedOutToUserID = this.CheckedOutToUserID,
                CustomComponent = this.CustomComponent.Clone(),
                HasCheckedOutToUserID = this.HasCheckedOutToUserID,
                IsFullyAuthoritative = this.IsFullyAuthoritative
            };
            return controlList;
        }

        public int Count { get; set; }

        public AccessControlListComponent CustomComponent { get; set; }

        public bool EqualTo(AccessControlList AccessControlList)
        {
            throw new NotImplementedException();
        }

        public AccessControlEntry GetACEByUserOrGroupID(int UserOrGroupID, bool IsGroup)
        {
            throw new NotImplementedException();
        }

        public int GetACEIndexByUserOrGroupID(int UserOrGroupID, bool IsGroup)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool HasCheckedOutToUserID { get; set; }

        public bool HasIdenticalPermissions(AccessControlList AccessControlList)
        {
            throw new NotImplementedException();
        }

        public bool IsFullyAuthoritative { get; set; }

        public void Remove(int Index)
        {
            throw new NotImplementedException();
        }

        public AccessControlEntry this[int Index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
