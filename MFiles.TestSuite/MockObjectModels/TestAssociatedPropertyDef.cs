using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;
using VaultMockObjects.ComModels;

namespace VaultMockObjects.MockObjectModels
{
    public class TestAssociatedPropertyDef : AssociatedPropertyDef
    {
        public TestAssociatedPropertyDef() { }

        public TestAssociatedPropertyDef(xAssociatedPropertyDef apd) 
        {
            this.PropertyDef = apd.PropertyDef;
            this.Required = apd.Required;
        }

        public AssociatedPropertyDef Clone()
        {
            TestAssociatedPropertyDef apd = new TestAssociatedPropertyDef
            {
                PropertyDef = this.PropertyDef,
                Required = this.Required
            };
            return apd;
        }

        public int PropertyDef { get; set; }

        public bool Required { get; set; }
    }
}
