using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.ComModels
{
    public class xStateConditions
    {
        public bool PropertyConditions { get; set; }
        public xSearchCondition[] PropertyConditionsDefinition { get; set; }
        public bool VBScript { get; set; }
        public string VBScriptDefinition { get; set; }

        public xStateConditions() { }

        public xStateConditions(StateConditions scs)
        {
            this.PropertyConditions = scs.PropertyConditions;
            this.PropertyConditionsDefinition = (from SearchCondition sc in scs.PropertyConditionsDefinition select new xSearchCondition(sc)).ToArray();
            this.VBScript = scs.VBScript;
            this.VBScriptDefinition = scs.VBScriptDefinition;
        }
    }
}
