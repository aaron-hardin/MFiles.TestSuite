using System;
using System.Collections.Generic;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
	public class TestObjectVersions : ObjectVersions
	{
		readonly List<ObjectVersion> objects = new List<ObjectVersion>();

		public void Add( int index, ObjectVersion objectVersionData )
		{
			objects.Add( objectVersionData );
		}

		public int Count
		{
			get { return objects.Count; }
		}

		public ObjVers GetAsObjVers()
		{
			ObjVers objVers = new ObjVers();
			foreach( ObjectVersion objectVersion in objects )
			{
				objVers.Add( -1, objectVersion.ObjVer );
			}
			return objVers;
		}

		public System.Collections.IEnumerator GetEnumerator()
		{
			return objects.GetEnumerator();			
		}

		public void Remove( int index )
		{
			objects.Remove( this[ index ] );
		}

		public void Sort( IObjectComparer objectComparer )
		{
			throw new NotImplementedException();
		}

		public ObjectVersion this[ int index ]
		{
			get { return objects[ index ]; }
			set { objects[ index ] = value; }
		}
	}
}
