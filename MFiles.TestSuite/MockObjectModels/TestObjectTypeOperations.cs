using System;
using System.Collections.Generic;
using System.Linq;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
	public class TestObjectTypeOperations : VaultObjectTypeOperations
	{
		private TestVault vault;

		public TestObjectTypeOperations( TestVault vault )
		{
			vault.MetricGatherer.MethodCalled();

			this.vault = vault;
		}

		public ObjTypeAdmin AddObjectTypeAdmin( ObjTypeAdmin objectType )
		{
			vault.MetricGatherer.MethodCalled();

			if( objectType.ObjectType.RealObjectType )
			{
				throw new NotImplementedException();
			}
			else
			{
				vault.objTypes.Add( objectType );
				return objectType;
			}
		}

		public ObjType GetBuiltInObjectType( MFBuiltInObjectType objectType )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjType GetObjectType( int objectType )
		{
			vault.MetricGatherer.MethodCalled();

			List<ObjTypeAdmin> objectTypes = vault.objTypes.Where( obj => obj.ObjectType.ID == objectType ).ToList();
			if( objectTypes.Count > 1 )
				throw new Exception( "hi" );
			ObjTypeAdmin ota = vault.objTypes.SingleOrDefault( obj => obj.ObjectType.ID == objectType );
			return ota == null ? null : ota.ObjectType;
		}

		public ObjTypeAdmin GetObjectTypeAdmin( int objectType )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public int GetObjectTypeIDByAlias( string alias )
		{
			vault.MetricGatherer.MethodCalled();

			// TODO: check that i did not do "obj.SemanticAliases.Value.Contains(Alias)" anywhere, thats not correct...not sure how many times i did that
			try
			{
				return vault.objTypes
					.Single( obj => obj.SemanticAliases != null
					&& obj.SemanticAliases.Value.Split( ';' ).Contains( alias ) ).ObjectType.ID;
			}
			catch
			{
				return -1;
			}
		}

		public int GetObjectTypeIDByGUID( string objectTypeGuid )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjTypes GetObjectTypes()
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjTypesAdmin GetObjectTypesAdmin()
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void RefreshExternalObjectType( int objectType, MFExternalDBRefreshType refreshType )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void RemoveObjectTypeAdmin( int objectTypeID )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjTypeAdmin UpdateObjectTypeAdmin( ObjTypeAdmin objectType )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjTypeAdmin UpdateObjectTypeWithAutomaticPermissionsAdmin( ObjTypeAdmin objectType, bool automaticPermissionsForcedActive = false )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}
	}
}
