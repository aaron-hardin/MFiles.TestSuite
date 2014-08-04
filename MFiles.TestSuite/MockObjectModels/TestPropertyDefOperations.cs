using System;
using System.Linq;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
	public class TestPropertyDefOperations : VaultPropertyDefOperations
	{
		private TestVault vault;

		public TestPropertyDefOperations( TestVault vault )
		{
			vault.MetricGatherer.MethodCalled();

			this.vault = vault;
		}

		public PropertyDefAdmin AddPropertyDefAdmin( PropertyDefAdmin propertyDefAdmin, TypedValue resetLastUsedValue = null )
		{
			vault.MetricGatherer.MethodCalled();

			// TODO: use arguments
			// TODO: error checking
			vault.propertyDefs.Add( propertyDefAdmin );
			return propertyDefAdmin;
		}

		public PropertyDef GetBuiltInPropertyDef( MFBuiltInPropertyDef propertyDefType )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public PropertyDef GetPropertyDef( int propertyDef )
		{
			vault.MetricGatherer.MethodCalled();

			// TODO: verify functionality
			if( propertyDef < 0 )
				throw new IndexOutOfRangeException( "ID out of range" );
			PropertyDefAdmin pda = vault.propertyDefs.SingleOrDefault( pdef => pdef.PropertyDef.ID == propertyDef );
			return pda == null ? null : pda.PropertyDef;
		}

		public PropertyDefAdmin GetPropertyDefAdmin( int propertyDef )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public int GetPropertyDefIDByAlias( string alias )
		{
			vault.MetricGatherer.MethodCalled();

			try
			{
				// TODO: check all properties that use alias, following does not work
				//return this.vault.propertyDefs.Single(pdef => pdef.SemanticAliases.Value.Contains(Alias)).PropertyDef.ID;
				return vault.propertyDefs.Single( pdef => pdef.SemanticAliases.Value.Split( ';' ).Contains( alias ) ).PropertyDef.ID;
			}
			catch
			{
				return -1;
			}
		}

		public int GetPropertyDefIDByGUID( string propertyDefGuid )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public PropertyDefs GetPropertyDefs()
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public PropertyDefsAdmin GetPropertyDefsAdmin()
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void RemovePropertyDefAdmin( int propertyDef, bool copyToAnotherPropertyDef = false, int targetPropertyDef = 0, bool append = false, bool deleteFromClassesIfNecessary = false )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void UpdatePropertyDefAdmin( PropertyDefAdmin propertyDefAdmin, TypedValue resetLastUsedValue = null )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void UpdatePropertyDefWithAutomaticPermissionsAdmin( PropertyDefAdmin propertyDefAdmin, TypedValue resetLastUsedValue = null, bool automaticPermissionsForcedActive = false )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}
	}
}
