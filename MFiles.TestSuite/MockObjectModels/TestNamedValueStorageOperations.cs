using System;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
	public class TestNamedValueStorageOperations : VaultNamedValueStorageOperations
	{
		private TestVault vault;

		public TestNamedValueStorageOperations( TestVault vault )
		{
			vault.MetricGatherer.MethodCalled();

			this.vault = vault;
		}

		public NamedValues GetNamedValues( MFNamedValueType namedValueType, string Namespace )
		{
			vault.MetricGatherer.MethodCalled();

			// TODO: fix this
			switch( namedValueType )
			{
				case MFNamedValueType.MFConfigurationValue:
					if( vault.namedValues.ContainsKey( Namespace ) )
						return vault.namedValues[ Namespace ];
					return new NamedValues();
				default:
					throw new NotImplementedException(
						string.Format( "TestNamedValueStorageOperations::GetNamedValues NamedValueType {0} not yet implemented",
							namedValueType ) );
			}
			//return new NamedValues();
			//throw new NotImplementedException();
		}

		public void RemoveNamedValues( MFNamedValueType namedValueType, string Namespace, Strings namedValueNames )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void SetNamedValues( MFNamedValueType namedValueType, string Namespace, NamedValues namedValues )
		{
			vault.MetricGatherer.MethodCalled();

			// TODO: fix this
			switch( namedValueType )
			{
			case MFNamedValueType.MFConfigurationValue:
				if( vault.namedValues.ContainsKey( Namespace ) )
				{
					vault.namedValues[ Namespace ] = namedValues;
				}
				else
				{
					vault.namedValues.Add( Namespace, namedValues );
				}
				break;
			default:
				throw new NotImplementedException( string.Format( "TestNamedValueStorageOperations::GetNamedValues NamedValueType {0} not yet implemented", namedValueType ) );
			}
		}
	}
}
