using System.Collections;
using System.Collections.Generic;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
	public class TestValueListItems : ValueListItems
	{
		internal readonly List<TestValueListItem> Items = new List<TestValueListItem>();
			
		IEnumerator IEnumerable.GetEnumerator()
		{
			return Items.GetEnumerator();
		}

		public int Count
		{
			get { return Items.Count; }
		}

		public ValueListItem this[ int index ]
		{
			get
			{
				// I hate 1 indexing
				return Items[ index - 1 ];
			}
		}

		IEnumerator IValueListItems.GetEnumerator()
		{
			return Items.GetEnumerator();
		}
	}
}
