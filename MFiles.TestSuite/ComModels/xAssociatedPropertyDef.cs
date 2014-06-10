using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.ComModels
{
    public class xAssociatedPropertyDef
    {
        public int PropertyDef { get; set; }
        public bool Required { get; set; }

        public xAssociatedPropertyDef() { }

        public xAssociatedPropertyDef(AssociatedPropertyDef apd)
        {
            this.PropertyDef = apd.PropertyDef;
            this.Required = apd.Required;
        }
    }
}
