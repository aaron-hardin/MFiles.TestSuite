using System;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestAccessControlListComponentContainer : AccessControlListComponentContainer
    {
        public TestAccessControlListComponentContainer()
        {
        }

        public AccessControlListComponent At(AccessControlListComponentKey AccessControlListComponentKey)
        {
            throw new NotImplementedException();
        }

        public int Count { get; set; }

        public AccessControlListComponentKeys GetKeys()
        {
            throw new NotImplementedException();
        }

        public bool HasKey(AccessControlListComponentKey AccessControlListComponentKey)
        {
            throw new NotImplementedException();
        }
    }
}
