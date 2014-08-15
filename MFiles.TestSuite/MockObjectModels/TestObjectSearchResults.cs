using System;
using System.Collections;
using System.Collections.Generic;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
	public class TestObjectSearchResults : ObjectSearchResults
	{
		private readonly List<TestObjectVersionAndProperties> results = new List<TestObjectVersionAndProperties>();

		internal void Add(TestObjectVersionAndProperties ovap)
		{
			results.Add( ovap );
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		public void Sort( IObjectComparer objectComparer )
		{
			throw new NotImplementedException();
		}

		public ObjectVersions GetAsObjectVersions()
		{
			TestObjectVersions ovs = new TestObjectVersions();
			foreach( TestObjectVersionAndProperties testOvap in results )
			{
				ovs.Add( -1, testOvap.VersionData );
			}
			return ovs;
		}

		public int GetScoreOfObject( ObjVer objVer )
		{
			throw new NotImplementedException();
		}

		public int ScoreAt( int index )
		{
			throw new NotImplementedException();
		}

		public void SortByScore( bool @ascending = false )
		{
			throw new NotImplementedException();
		}

		public int Count { get { return results.Count; } }

		public ObjectVersion this[ int index ]
		{
			get { return results[ index-1 ].VersionData; }
		}

		public bool MoreResults { get; private set; }
		public ObjectVersions ObjectVersions { get; private set; }

		IEnumerator IObjectSearchResults.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
