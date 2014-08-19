using System;
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
		    pv.TypedValue.SetValue(MFDataType.MFDatatypeLookup, 115);
			pvs.Add(-1, pv);
		    ObjectVersionAndProperties ovap = vault.ObjectOperations.CreateNewObject(0, pvs);

			Assert.AreEqual(1, vault.ovaps.Count, "Number of objects != 1");

			Assert.AreEqual( 115, ovap.VersionData.Class );
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
			}, true );
			Assert.AreNotEqual( 0, vault.MetricGatherer.MethodsCalled.Count );
			
			Assert.AreEqual( 1, vault.ovaps.Count, "Number of objects != 1" );

			PropertyValue sfd = new PropertyValue { PropertyDef = ( int )MFBuiltInPropertyDef.MFBuiltInPropertyDefSingleFileObject };
			sfd.TypedValue.SetValue( MFDataType.MFDatatypeBoolean, true );
			pvs.Add( -1, sfd );

			vault.ObjectPropertyOperations.SetAllProperties( ovap.ObjVer, true, pvs );

			Assert.AreEqual( 2, vault.ovaps.Count, "Number of objects/versions != 2" );

			vault.MetricGatherer.PrintResults();
		}

		[Test]
		public void CloneFrom()
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
			vault.ObjectOperations.CreateNewObject(0, pvs);

			Assert.AreEqual(1, vault.ovaps.Count, "Number of objects != 1");

			TestVault clone = new TestVault();
			clone.CloneFrom( vault );

			Assert.AreEqual(1, vault.ovaps.Count, "After Clone::Number of objects should be 1.");

			clone.ObjectOperations.CreateNewObject(0, pvs);

			Assert.AreEqual(2, clone.ovaps.Count, "Clone does not have 2 objects");
			Assert.AreEqual(2, vault.ovaps.Count, "Original does not have 2 objects");
		}

		[Test]
		public void Search()
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
			vault.ObjectOperations.CreateNewObject(0, pvs);

			Assert.AreEqual(1, vault.ovaps.Count, "Number of objects != 1");
			const int testPropID = 55;
			pv = new PropertyValue{ PropertyDef = testPropID };
			const int testLookupID = 77;
			Lookups lks = new Lookups();
			Lookup lk = new Lookup { Item = testLookupID, ObjectType = 0 };
			lks.Add(-1, lk);
			pv.TypedValue.SetValueToMultiSelectLookup( lks );
			pvs.Add( -1, pv );
			vault.ObjectOperations.CreateNewObject(0, pvs);
			Assert.AreEqual(2, vault.ovaps.Count, "Original does not have 2 objects");

			SearchCondition c = new SearchCondition();
			c.Expression.DataPropertyValuePropertyDef = testPropID;
			c.ConditionType = MFConditionType.MFConditionTypeEqual;
			c.TypedValue.SetValue( MFDataType.MFDatatypeLookup, testLookupID );

			SearchCondition sc = new SearchCondition();
			sc.Expression.SetStatusValueExpression(MFStatusType.MFStatusTypeDeleted);
			sc.ConditionType = MFConditionType.MFConditionTypeEqual;
			sc.TypedValue.SetValue(MFDataType.MFDatatypeBoolean, false);
			
			SearchConditions search = new SearchConditions();
			search.Add(-1, sc);
			search.Add(-1, c);

			ObjectSearchResults results = vault.ObjectSearchOperations.SearchForObjectsByConditionsEx( search,
				MFSearchFlags.MFSearchFlagDisableRelevancyRanking, false );

			Assert.AreEqual( 1, results.Count );

			ObjectVersion ov = results[ 1 ];
			
			Assert.NotNull( ov );

			ObjectVersions ovs = results.GetAsObjectVersions();

			foreach( ObjectVersion result in ovs )
			{
				Assert.NotNull( result );
			}
		}

		[Test]
		public void GetObjectInfo()
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
			pv.PropertyDef = 0;
			pv.TypedValue.SetValue( MFDataType.MFDatatypeText, "Title" );
			pvs.Add( -1, pv );
			ObjectVersionAndProperties ovap = vault.ObjectOperations.CreateNewObject(0, pvs);

			ObjectVersion ov = vault.ObjectOperations.GetObjectInfo( ovap.ObjVer, false, true );
			Assert.NotNull( ov );
			Assert.AreEqual( "Title", ov.Title );
		}

		[Test]
		public void Checkout()
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
			pv.PropertyDef = 0;
			pv.TypedValue.SetValue(MFDataType.MFDatatypeText, "Title");
			pvs.Add(-1, pv);
			ObjectVersionAndProperties ovap = vault.ObjectOperations.CreateNewObject(0, pvs);

			ObjectVersion ov = vault.ObjectOperations.CheckOut(ovap.ObjVer.ObjID);
			Assert.AreEqual(2, ov.ObjVer.Version);

			Assert.Throws<Exception>( () => vault.ObjectOperations.CheckOut( ovap.ObjVer.ObjID ) );
		}

		[Test]
		public void ForceUndoCheckout()
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
			pv.PropertyDef = 0;
			pv.TypedValue.SetValue(MFDataType.MFDatatypeText, "Title");
			pvs.Add(-1, pv);
			ObjectVersionAndProperties ovap = vault.ObjectOperations.CreateNewObject(0, pvs);

			Assert.Throws<Exception>( () => vault.ObjectOperations.ForceUndoCheckout( ovap.ObjVer ) );

			ObjectVersion ov = vault.ObjectOperations.CheckOut( ovap.ObjVer.ObjID );
			Assert.AreEqual( 2, ov.ObjVer.Version );

			ov = vault.ObjectOperations.ForceUndoCheckout( ov.ObjVer );
			Assert.AreEqual( 1, ov.ObjVer.Version );
		}
    }
}
