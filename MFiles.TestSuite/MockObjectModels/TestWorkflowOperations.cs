using System;
using System.Linq;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
	public class TestWorkflowOperations : VaultWorkflowOperations
	{
		private TestVault vault;

		public TestWorkflowOperations( TestVault vault )
		{
			vault.MetricGatherer.MethodCalled();

			this.vault = vault;
		}

		public WorkflowAdmin AddWorkflowAdmin( WorkflowAdmin workflow )
		{
			vault.MetricGatherer.MethodCalled();

			// TODO: verify
			vault.workflows.Add( workflow );

			ValueListItem valueListItemWorkflow = new ValueListItem { ID = workflow.Workflow.ID, Name = workflow.Workflow.Name };
			vault.ValueListItemOperations.AddValueListItem( ( int )MFBuiltInValueList.MFBuiltInValueListWorkflows,
				valueListItemWorkflow );
			for( int i = 1; i <= workflow.States.Count; ++i )
			{
				StateAdmin stateAdmin = workflow.States[ i ];
				ValueListItem valueListItemState = new ValueListItem { ID = stateAdmin.ID, Name = stateAdmin.Name, OwnerID = workflow.Workflow.ID };
				vault.ValueListItemOperations.AddValueListItem( ( int )MFBuiltInValueList.MFBuiltInValueListStates,
					valueListItemState );
			}
			return workflow;
		}

		public SignatureSettings GetStateTransitionSignatureSettings( int fromState, int toState )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public WorkflowAdmin GetWorkflowAdmin( int workflowID )
		{
			vault.MetricGatherer.MethodCalled();

			return vault.workflows.SingleOrDefault( wf => wf.Workflow.ID == workflowID );
			// TODO: verify
		}

		public Workflow GetWorkflowForClient( int workflowID, bool updateFromServer = false )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public int GetWorkflowIDByAlias( string alias )
		{
			vault.MetricGatherer.MethodCalled();

			try
			{
				return vault.workflows.Single( wf => wf.SemanticAliases.Value.Split( ';' ).Contains( alias ) ).Workflow.ID;
			}
			catch
			{
				return -1;
			}
		}

		public int GetWorkflowIDByGUID( string workflowGuid )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public int GetWorkflowStateIDByAlias( string alias )
		{
			vault.MetricGatherer.MethodCalled();

			// TODO: verify
			int stateId = -1;
			foreach( WorkflowAdmin workflowAdmin in vault.workflows )
			{
				for( int i = 1; i <= workflowAdmin.States.Count; ++i )
				{
					StateAdmin stateAdmin = workflowAdmin.States[ i ];
					if( !stateAdmin.SemanticAliases.Value.Split( ';' ).Contains( alias ) )
						continue;
					if( stateId != -1 )
						return -1;
					stateId = stateAdmin.ID;
				}
			}
			return stateId;
		}

		public int GetWorkflowStateIDByGUID( string stateGuid )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public States GetWorkflowStates( int workflow, TypedValue currentState = null )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public States GetWorkflowStatesEx( int workflow, TypedValue currentState = null, ObjVer objVer = null )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public WorkflowsAdmin GetWorkflowsAdmin()
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ValueListItems GetWorkflowsAsValueListItems( bool updateFromServer = false )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public Workflows GetWorkflowsForClient( bool updateFromServer = false )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void RemoveWorkflowAdmin( int workflowID )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public WorkflowAdmin UpdateWorkflowAdmin( WorkflowAdmin workflow )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}
	}
}
