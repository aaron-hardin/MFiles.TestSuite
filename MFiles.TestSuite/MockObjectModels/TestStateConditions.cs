using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;
using VaultMockObjects.ComModels;

namespace VaultMockObjects.MockObjectModels
{
    public class TestStateConditions : StateConditions
    {
        public TestStateConditions() { }

        public TestStateConditions(xStateConditions scs)
        {
            this.PropertyConditions = scs.PropertyConditions;
            this.PropertyConditionsDefinition = new SearchConditions();
            foreach (xSearchCondition searchCondition in scs.PropertyConditionsDefinition)
            {
                this.PropertyConditionsDefinition.Add(-1, new TestSearchCondition(searchCondition));
            }
            this.VBScript = scs.VBScript;
            this.VBScriptDefinition = scs.VBScriptDefinition;
        }

        public StateConditions Clone()
        {
            TestStateConditions scs = new TestStateConditions
            {
                PropertyConditions = this.PropertyConditions,
                PropertyConditionsDefinition = new SearchConditions(),
                VBScript = this.VBScript,
                VBScriptDefinition = this.VBScriptDefinition
            };
            for (int i = 1; i <= this.PropertyConditionsDefinition.Count; ++i)
            {
                SearchCondition searchCondition = this.PropertyConditionsDefinition[i];
                scs.PropertyConditionsDefinition.Add(-1, searchCondition.Clone());
            }
            return scs;
        }

        public bool PropertyConditions { get; set; }

        public SearchConditions PropertyConditionsDefinition { get; set; }

        public bool VBScript { get; set; }

        public string VBScriptDefinition { get; set; }
    }
}
