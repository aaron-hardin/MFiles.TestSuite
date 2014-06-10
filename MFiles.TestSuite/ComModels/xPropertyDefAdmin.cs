using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.ComModels
{
    public class xPropertyDefAdmin
    {
        public bool AllowAutomaticPermissions { get; set; }
        public xAutomaticValue AutomaticValue { get; set; }
        public xPropertyDef PropertyDef { get; set; }
        public string[] SemanticAliases { get; set; }
        public xValidation Validation { get; set; }

        public xPropertyDefAdmin() { }

        public xPropertyDefAdmin(PropertyDefAdmin pda)
        {
            this.AllowAutomaticPermissions = pda.AllowAutomaticPermissions;
            this.AutomaticValue = new xAutomaticValue(pda.AutomaticValue);
            this.PropertyDef = new xPropertyDef(pda.PropertyDef);
            this.SemanticAliases = pda.SemanticAliases.Value.Split(';');
            this.Validation = new xValidation(pda.Validation);
        }
    }
}
