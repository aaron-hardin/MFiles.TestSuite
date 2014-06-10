using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFiles.TestSuite.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestPropertyDefAdmin : PropertyDefAdmin
    {
        public TestPropertyDefAdmin() { }

        public TestPropertyDefAdmin(xPropertyDefAdmin pda) 
        {
            this.AllowAutomaticPermissions = pda.AllowAutomaticPermissions;
            this.AutomaticValue = new TestAutomaticValue(pda.AutomaticValue);
            this.PropertyDef = new TestPropertyDef(pda.PropertyDef);
            this.SemanticAliases =  new SemanticAliases { Value = string.Join(";", pda.SemanticAliases) };
            this.Validation = new TestValidation(pda.Validation);
        }

        public bool AllowAutomaticPermissions { get; set; }

        public AutomaticValue AutomaticValue { get; set; }

        public PropertyDefAdmin Clone()
        {
            throw new NotImplementedException();
        }

        public PropertyDef PropertyDef { get; set; }

        public SemanticAliases SemanticAliases { get; set; }

        public Validation Validation { get; set; }
    }
}
