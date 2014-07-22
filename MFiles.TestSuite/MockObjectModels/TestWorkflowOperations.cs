using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestWorkflowOperations : VaultWorkflowOperations
    {
        private TestVault vault;

        public TestWorkflowOperations(TestVault vault)
        {
            this.vault = vault;
        }

        public WorkflowAdmin AddWorkflowAdmin(WorkflowAdmin Workflow)
        {
            // TODO: verify
            this.vault.workflows.Add(Workflow);

            ValueListItem valueListItemWorkflow = new ValueListItem { ID = Workflow.Workflow.ID, Name = Workflow.Workflow.Name };
            this.vault.ValueListItemOperations.AddValueListItem((int)MFBuiltInValueList.MFBuiltInValueListWorkflows,
                valueListItemWorkflow);
            for (int i = 1; i <= Workflow.States.Count; ++i)
            {
                StateAdmin stateAdmin = Workflow.States[i];
                ValueListItem valueListItemState = new ValueListItem { ID = stateAdmin.ID, Name = stateAdmin.Name, OwnerID = Workflow.Workflow.ID };
                this.vault.ValueListItemOperations.AddValueListItem((int) MFBuiltInValueList.MFBuiltInValueListStates,
                    valueListItemState);
            }
            return Workflow;
        }

        public SignatureSettings GetStateTransitionSignatureSettings(int FromState, int ToState)
        {
            throw new NotImplementedException();
        }

        public WorkflowAdmin GetWorkflowAdmin(int WorkflowID)
        {
	        return vault.workflows.SingleOrDefault(wf => wf.Workflow.ID == WorkflowID);
            // TODO: verify
        }

        public Workflow GetWorkflowForClient(int WorkflowID, bool UpdateFromServer = false)
        {
            throw new NotImplementedException();
        }

        public int GetWorkflowIDByAlias(string Alias)
        {
            try
            {
                return this.vault.workflows.Single(wf => wf.SemanticAliases.Value.Split(';').Contains(Alias)).Workflow.ID;
            }
            catch
            {
                return -1;
            }
        }

        public int GetWorkflowIDByGUID(string WorkflowGUID)
        {
            throw new NotImplementedException();
        }

        public int GetWorkflowStateIDByAlias(string Alias)
        {
            // TODO: verify
            int stateId = -1;
            foreach (WorkflowAdmin workflowAdmin in this.vault.workflows)
            {
                for (int i = 1; i <= workflowAdmin.States.Count; ++i)
                {
                    StateAdmin stateAdmin = workflowAdmin.States[i];
                    if (!stateAdmin.SemanticAliases.Value.Split(';').Contains(Alias))
                        continue;
                    if (stateId != -1)
                        return -1;
                    stateId = stateAdmin.ID;
                }
            }
            return stateId;
        }

        public int GetWorkflowStateIDByGUID(string StateGUID)
        {
            throw new NotImplementedException();
        }

        public States GetWorkflowStates(int Workflow, TypedValue CurrentState = null)
        {
            throw new NotImplementedException();
        }

        public States GetWorkflowStatesEx(int Workflow, TypedValue CurrentState = null, ObjVer ObjVer = null)
        {
            throw new NotImplementedException();
        }

        public WorkflowsAdmin GetWorkflowsAdmin()
        {
            throw new NotImplementedException();
        }

        public ValueListItems GetWorkflowsAsValueListItems(bool UpdateFromServer = false)
        {
            throw new NotImplementedException();
        }

        public Workflows GetWorkflowsForClient(bool UpdateFromServer = false)
        {
            throw new NotImplementedException();
        }

        public void RemoveWorkflowAdmin(int WorkflowID)
        {
            throw new NotImplementedException();
        }

        public WorkflowAdmin UpdateWorkflowAdmin(WorkflowAdmin Workflow)
        {
            throw new NotImplementedException();
        }
    }
}
