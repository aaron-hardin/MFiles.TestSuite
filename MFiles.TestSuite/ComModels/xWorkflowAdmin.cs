using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace VaultMockObjects.ComModels
{
    public class xWorkflowAdmin
    {
        public string Description { get; set; }
        public xAccessControlList Permissions { get; set; }
        public string[] SemanticAliases { get; set; }
        public xStateAdmin[] States { get; set; }
        public xStateTransition[] StateTransitions { get; set; }
        public xWorkflow Workflow { get; set; }

        public xWorkflowAdmin() { }

        public xWorkflowAdmin(WorkflowAdmin wfa)
        {
            this.Description = wfa.Description;
            this.Permissions = new xAccessControlList(wfa.Permissions);
            this.SemanticAliases = wfa.SemanticAliases.Value.Split(';');
            this.States = (from StateAdmin state in wfa.States select new xStateAdmin(state)).ToArray();
            this.StateTransitions = (from StateTransition st in wfa.StateTransitions select new xStateTransition(st)).ToArray();
            this.Workflow = new xWorkflow(wfa.Workflow);
        }
    }
}
