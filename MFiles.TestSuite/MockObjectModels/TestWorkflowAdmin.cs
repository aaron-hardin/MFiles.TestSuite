using System;
using MFiles.VaultJsonTools.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestWorkflowAdmin : WorkflowAdmin
    {
        public TestWorkflowAdmin() { }

        public TestWorkflowAdmin(xWorkflowAdmin wfa) 
        {
            this.Description = wfa.Description;
            this.Permissions = new TestAccessControlList(wfa.Permissions);
            this.SemanticAliases = new SemanticAliases { Value = string.Join(";", wfa.SemanticAliases) };
            this.States = new StatesAdmin();
            foreach (xStateAdmin stateAdmin in wfa.States)
            {
                this.States.Add(-1, new TestStateAdmin(stateAdmin));
            }
            this.StateTransitions = new StateTransitions();
            foreach (xStateTransition transition in wfa.StateTransitions)
            {
                this.StateTransitions.Add(-1, new TestStateTransition(transition));
            }
            this.Workflow = new TestWorkflow(wfa.Workflow);
        }

        public WorkflowAdmin Clone()
        {
            throw new NotImplementedException();
        }

        public string Description { get; set; }

        public AccessControlList Permissions { get; set; }

        public SemanticAliases SemanticAliases { get; set; }

        public StateTransitions StateTransitions { get; set; }

        public StatesAdmin States { get; set; }

        public Workflow Workflow { get; set; }
    }
}
