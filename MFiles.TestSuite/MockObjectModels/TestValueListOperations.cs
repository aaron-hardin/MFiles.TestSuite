using System;
using System.Linq;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
	public class TestValueListOperations : VaultValueListOperations
	{
		private TestVault vault;

		internal TestValueListOperations(TestVault vault)
		{
			this.vault = vault;
		}

		public ObjTypes GetValueLists()
		{
			throw new NotImplementedException();
		}

		public ObjType GetValueList( int valueList )
		{
			ObjTypeAdmin vlOtAdmin = vault.objTypes.FirstOrDefault(vl => vl.ObjectType.ID == valueList && vl.ObjectType.RealObjectType == false);

			if(vlOtAdmin == null)
			{
				throw new Exception( "Value List not found: " + valueList );
			}

			return vlOtAdmin.ObjectType;
		}

		public ObjType GetBuiltInValueList( MFBuiltInValueList builtInValueList )
		{
			throw new NotImplementedException();
		}

		public void RefreshExternalValueList( int valueList, MFExternalDBRefreshType refreshType )
		{
			throw new NotImplementedException();
		}
	}
}
