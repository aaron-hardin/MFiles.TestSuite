using System;
using MFiles.VaultJsonTools.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestNamedACL : NamedACL
    {
        public TestNamedACL() { }

        public TestNamedACL(xNamedACL namedAcl)
        {
            if (namedAcl == null)
                return;

            this.AccessControlList = new TestAccessControlList(namedAcl.AccessControlList);
            this.GUID = namedAcl.GUID;
            this.ID = namedAcl.ID;
            this.Name = namedAcl.Name;
            this.NamedACLType = (MFNamedACLType)namedAcl.NamedACLType;
        }

        public AccessControlList AccessControlList { get; set; }

        public AccessControlList AccessControlListForNamedACL { get; set; }

        public NamedACL Clone()
        {
            throw new NotImplementedException();
        }

        public string GUID { get; set; }

        public int ID { get; set; }

        public string Name { get; set; }

        public MFNamedACLType NamedACLType { get; set; }
    }
}
