using System.Collections;
using System.Collections.Generic;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
	public class TestStates : States
	{
		private readonly List<TestState> states = new List<TestState>();
		
		internal TestStates(TestStatesAdmin statesAdmin)
		{
			foreach( TestStateAdmin testStateAdmin in statesAdmin )
			{
				states.Add( new TestState( testStateAdmin ) );
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return states.GetEnumerator();
		}

		public int Count { get; private set; }

		public State this[ int index ]
		{
			// TODO: assumed 1 indexing, is this correct?
			get
			{
				return states[ index - 1 ];
			}
		}

		IEnumerator IStates.GetEnumerator()
		{
			return states.GetEnumerator();
		}
	}
}
