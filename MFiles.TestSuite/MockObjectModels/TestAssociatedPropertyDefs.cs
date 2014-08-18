using System;
using System.Collections;
using System.Collections.Generic;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
	public class TestAssociatedPropertyDefs : AssociatedPropertyDefs
	{
		readonly List<TestAssociatedPropertyDef> tapd = new List<TestAssociatedPropertyDef>();

		public TestAssociatedPropertyDefs() {}

		internal TestAssociatedPropertyDefs(AssociatedPropertyDefs apds)
		{
			foreach( AssociatedPropertyDef associatedPropertyDef in apds )
			{
				tapd.Add( new TestAssociatedPropertyDef(associatedPropertyDef) );
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return tapd.GetEnumerator();
		}

		public void Add( int index, AssociatedPropertyDef associatedPropertyDef )
		{
			TestAssociatedPropertyDef newState = (associatedPropertyDef as TestAssociatedPropertyDef) ?? new TestAssociatedPropertyDef(associatedPropertyDef);

			if (index == -1 || index == tapd.Count + 1)
			{
				tapd.Add(newState);
			}
			else if (index > tapd.Count)
			{
				throw new Exception("Index out of range: " + index);
			}
			else
			{
				// I hate 1 indexing
				tapd[index - 1] = newState;
			}
		}

		public void Remove( int index )
		{
			// I hate 1 indexing
			tapd.RemoveAt(index - 1);
		}

		public AssociatedPropertyDefs Clone()
		{
			throw new NotImplementedException();
		}

		public int Count { get { return tapd.Count; } }

		public AssociatedPropertyDef this[ int index ]
		{
			// I hate 1 indexing
			get { return tapd[index - 1]; }
		}

		IEnumerator IAssociatedPropertyDefs.GetEnumerator()
		{
			return tapd.GetEnumerator();
		}
	}
}
