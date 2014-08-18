using System;
using System.Linq;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
	public class TestClassOperations : VaultClassOperations
	{
		private TestVault vault;

		public TestClassOperations( TestVault vault )
		{
			vault.MetricGatherer.MethodCalled();

			this.vault = vault;
		}

		public ObjectClassAdmin AddObjectClassAdmin( ObjectClassAdmin objectClassAdmin )
		{
			vault.MetricGatherer.MethodCalled();

			// TODO: make functionality comparable to API
			vault.classAdmins.Add( objectClassAdmin );
			vault.classes.Add(new TestObjectClass(objectClassAdmin));

			return objectClassAdmin;
		}

		public ObjectClasses GetAllObjectClasses()
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectClassesAdmin GetAllObjectClassesAdmin()
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectClass GetObjectClass( int objectClass )
		{
			vault.MetricGatherer.MethodCalled();

			TestObjectClass objClass = vault.classes.FirstOrDefault( cl => cl.ID == objectClass );

			if(objClass == null)
			{
				throw new Exception("Class not found: "+objectClass);
			}
			return objClass;
		}

		public ObjectClassAdmin GetObjectClassAdmin( int Class )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public int GetObjectClassIDByAlias( string alias )
		{
			vault.MetricGatherer.MethodCalled();

			try
			{
				ObjectClassAdmin classAdmin =
					vault.classAdmins.SingleOrDefault( classy => classy.SemanticAliases.Value.Split( ';' ).Contains( alias ) );
				return classAdmin == null ? -1 : classAdmin.ID;
			}
			catch
			{
				return -1;
			}
		}

		public int GetObjectClassIDByGUID( string objectClassGuid )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectClasses GetObjectClasses( int objectType )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectClassesAdmin GetObjectClassesAdmin( int objectType )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void RemoveObjectClassAdmin( int objectClassID )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void UpdateObjectClassAdmin( ObjectClassAdmin objectClass )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}
	}
}
