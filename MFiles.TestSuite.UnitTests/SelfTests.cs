using System.IO;
using System.Reflection;
using MFiles.TestSuite.MockObjectModels;
using MFiles.VaultJsonTools;
using MFilesAPI;
using NUnit.Framework;

namespace MFiles.TestSuite.UnitTests
{
    [TestFixture]
	[Category( TestCategories.UNIT )]
    public class SelfTests
    {
        [Test]
        [Category(TestCategories.DO_NOT_RUN)]
        public void GenerateVault()
        {
            MFilesServerApplication mfserver = new MFilesServerApplication();
            mfserver.Connect(NetworkAddress: "mfbuilderdl01");
            Vault vault = mfserver.LogInToVault("{1C6A118E-DD8E-411C-8E6F-DAF8805FC781}");

            StructureGenerator.VaultToJsonFile(vault, "VaultStructure.json");
        }

	    [Test]
	    public void TestCreate()
	    {
		    Assembly current = Assembly.GetAssembly(typeof (Tools));
			Stream stream = current.GetManifestResourceStream(typeof(Tools), "VaultStructure.json");

			if(stream == null)
				Assert.Fail("Failed to load stream.");

		    TestVault vault = TestVault.FromStream(stream);

			PropertyValues pvs = new PropertyValues();
			PropertyValue pv = new PropertyValue {PropertyDef = (int) MFBuiltInPropertyDef.MFBuiltInPropertyDefClass};
		    pv.TypedValue.SetValue(MFDataType.MFDatatypeLookup, 0);
			pvs.Add(-1, pv);
		    vault.ObjectOperations.CreateNewObject(0, pvs);

			Assert.AreEqual(1, vault.ovaps.Count, "Number of objects != 1");
	    }

		[Test]
		public void TestEdit()
		{
			Assembly current = Assembly.GetAssembly(typeof(Tools));
			Stream stream = current.GetManifestResourceStream(typeof(Tools), "VaultStructure.json");

			if (stream == null)
				Assert.Fail("Failed to load stream.");

			TestVault vault = TestVault.FromStream(stream);

			PropertyValues pvs = new PropertyValues();
			PropertyValue pv = new PropertyValue { PropertyDef = (int)MFBuiltInPropertyDef.MFBuiltInPropertyDefClass };
			pv.TypedValue.SetValue(MFDataType.MFDatatypeLookup, 0);
			pvs.Add(-1, pv);
			ObjectVersionAndProperties ovap = vault.ObjectOperations.CreateNewObject(0, pvs);

			Assert.AreEqual(1, vault.ovaps.Count, "Number of objects != 1");

			PropertyValue sfd = new PropertyValue {PropertyDef = (int) MFBuiltInPropertyDef.MFBuiltInPropertyDefSingleFileObject};
			sfd.TypedValue.SetValue(MFDataType.MFDatatypeBoolean, true);
			pvs.Add(-1, sfd);

			vault.ObjectPropertyOperations.SetAllProperties(ovap.ObjVer, true, pvs);

			Assert.AreEqual(2, vault.ovaps.Count, "Number of objects/versions != 2");
		}

		[Test]
		public void TestMetrics()
		{
			Assembly current = Assembly.GetAssembly( typeof( Tools ) );
			Stream stream = current.GetManifestResourceStream( typeof( Tools ), "VaultStructure.json" );

			if( stream == null )
				Assert.Fail( "Failed to load stream." );

			TestVault vault = TestVault.FromStream( stream );
			
			PropertyValues pvs = new PropertyValues();
			PropertyValue pv = new PropertyValue { PropertyDef = ( int )MFBuiltInPropertyDef.MFBuiltInPropertyDefClass };
			pv.TypedValue.SetValue( MFDataType.MFDatatypeLookup, 0 );
			pvs.Add( -1, pv );
			Assert.AreEqual( 0, vault.MetricGatherer.MethodsCalled.Count);
			Assert.IsFalse( vault.MetricGatherer.TrackMetrics );
			ObjectVersionAndProperties ovap = null;
			vault.MetricGatherer.CallWithLogging( () => 
			{
				ovap = vault.ObjectOperations.CreateNewObject( 0, pvs );
			} );
			Assert.AreNotEqual( 0, vault.MetricGatherer.MethodsCalled.Count );
			
			Assert.AreEqual( 1, vault.ovaps.Count, "Number of objects != 1" );

			PropertyValue sfd = new PropertyValue { PropertyDef = ( int )MFBuiltInPropertyDef.MFBuiltInPropertyDefSingleFileObject };
			sfd.TypedValue.SetValue( MFDataType.MFDatatypeBoolean, true );
			pvs.Add( -1, sfd );

			vault.ObjectPropertyOperations.SetAllProperties( ovap.ObjVer, true, pvs );

			Assert.AreEqual( 2, vault.ovaps.Count, "Number of objects/versions != 2" );

			vault.MetricGatherer.PrintResults();
		}
    }
}
