using System;
using System.Collections;
using System.Collections.Generic;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
	public class TestStatesAdmin : StatesAdmin
	{
		internal readonly List<TestStateAdmin> States = new List<TestStateAdmin>();
		
		internal TestStatesAdmin(StatesAdmin ssa)
		{
			foreach( StateAdmin stateAdmin in ssa )
			{
				States.Add( new TestStateAdmin(stateAdmin) );
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return States.GetEnumerator();
		}

		public void Add( int index, StateAdmin stateAdmin )
		{
			TestStateAdmin newState = ( stateAdmin as TestStateAdmin ) ?? new TestStateAdmin( stateAdmin );

			if(index == -1 || index == States.Count+1)
			{
				States.Add( newState );
			}
			else if(index > States.Count)
			{
				throw new Exception( "Index out of range: " + index );
			}
			else
			{
				// I hate 1 indexing
				States[ index-1 ] = newState;
			}
		}

		public void Remove( int index )
		{
			// I hate 1 indexing
			States.RemoveAt( index - 1 );
		}

		public StatesAdmin Clone()
		{
			throw new NotImplementedException();
		}

		public int Count {
			get { return States.Count; }
		}

		public StateAdmin this[ int index ]
		{
			// I hate 1 indexing
			get { return States[ index - 1 ]; }
		}

		IEnumerator IStatesAdmin.GetEnumerator()
		{
			return States.GetEnumerator();
		}
	}
}
