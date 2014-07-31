using System;
using MFiles.VaultJsonTools.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestPropertyDefOrObjectType : PropertyDefOrObjectType
    {
        public TestPropertyDefOrObjectType() { }

        public TestPropertyDefOrObjectType(xPropertyDefOrObjectType pdot)
        {
            this.ID = pdot.ID;
            this.PropertyDef = pdot.PropertyDef;
        }

        public PropertyDefOrObjectType Clone()
        {
            TestPropertyDefOrObjectType pdot = new TestPropertyDefOrObjectType
            {
                ID = this.ID,
                PropertyDef = this.PropertyDef
            };
            return pdot;
        }

        public Expression GetAsExpression()
        {
            throw new NotImplementedException();
        }

        public int ID { get; set; }

        public bool PropertyDef { get; set; }
    }
}
