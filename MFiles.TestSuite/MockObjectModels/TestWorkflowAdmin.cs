using System;
using MFiles.VaultJsonTools.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestWorkflowAdmin : WorkflowAdmin
    {
        public TestWorkflowAdmin() { }

		public TestWorkflowAdmin(WorkflowAdmin wfa) : this(new xWorkflowAdmin(wfa)) {}

        public TestWorkflowAdmin(xWorkflowAdmin wfa) 
        {
            Description = wfa.Description;
            Permissions = new TestAccessControlList(wfa.Permissions);
            SemanticAliases = new SemanticAliases { Value = string.Join(";", wfa.SemanticAliases) };
            States = new StatesAdmin();
            foreach (xStateAdmin stateAdmin in wfa.States)
            {
                States.Add(-1, new TestStateAdmin(stateAdmin));
            }
            StateTransitions = new StateTransitions();
            foreach (xStateTransition transition in wfa.StateTransitions)
            {
                StateTransitions.Add(-1, new TestStateTransition(transition));
            }
            Workflow = new TestWorkflow(wfa.Workflow);
        }

        public WorkflowAdmin Clone()
        {
            throw new NotImplementedException();
        }

        public string Description { get; set; }

        public AccessControlList Permissions { get; set; }

        public SemanticAliases SemanticAliases { get; set; }

        public StateTransitions StateTransitions { get; set; }

	    internal TestStatesAdmin states;

	    public StatesAdmin States
	    {
		    get { return states; }
			set { states = new TestStatesAdmin(value);}
	    }

	    public Workflow Workflow { get; set; }
    }
}
