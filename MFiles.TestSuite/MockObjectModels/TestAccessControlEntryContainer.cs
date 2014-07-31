using System;
using MFiles.VaultJsonTools.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestAccessControlEntryContainer : AccessControlEntryContainer
    {
        public TestAccessControlEntryContainer()
        {
        }

        public TestAccessControlEntryContainer(xAccessControlEntryContainer container)
        {
            this.IsEmpty = container.IsEmpty;
        }

        public void Add(AccessControlEntryKey AccessControlEntryKey, AccessControlEntryData AccessControlEntryData)
        {
            throw new NotImplementedException();
        }

        public AccessControlEntryData At(AccessControlEntryKey AccessControlEntryKey)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public AccessControlEntryContainer Clone()
        {
            TestAccessControlEntryContainer container = new TestAccessControlEntryContainer { IsEmpty = this.IsEmpty };
            return container;
        }

        public AccessControlEntryKeys GetKeys()
        {
            throw new NotImplementedException();
        }

        public AccessControlEntryKeys GetKeysWithPseudoUserDefinitions()
        {
            throw new NotImplementedException();
        }

        public bool HasKey(AccessControlEntryKey AccessControlEntryKey)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty { get; set; }
        
        public void Remove(AccessControlEntryKey AccessControlEntryKey)
        {
            throw new NotImplementedException();
        }
    }
}
