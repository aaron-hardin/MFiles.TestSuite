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
	    public void TestFail()
	    {
		    Assert.Fail("Testing build process.");
	    }
    }
}
