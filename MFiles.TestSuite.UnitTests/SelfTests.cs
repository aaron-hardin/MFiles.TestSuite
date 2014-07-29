using System.IO;
using System.Reflection;
using MFiles.TestSuite.MockObjectModels;
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
		    Assembly current = Assembly.GetAssembly(typeof (StructureGenerator));
		    Stream stream = current.GetManifestResourceStream(typeof (StructureGenerator), "VaultStructure.json");

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
    }
}
