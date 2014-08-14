using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestObjectVersionAndProperties : ObjectVersionAndProperties
    {
        internal TestPropertyValues properties = new TestPropertyValues();

	    internal TestObjectVersion versionData;

        public ObjectVersionAndProperties Clone()
        {
            TestObjectVersionAndProperties clone = new TestObjectVersionAndProperties
            {
                Properties = this.Properties.Clone(),
                Vault = this.Vault,
                VersionData = this.VersionData.Clone()
            };
            return clone;
        }

		public TestObjectVersionAndProperties CloneCheckedOut()
		{
			TestObjectVersionAndProperties clone = new TestObjectVersionAndProperties
			{
				Properties = this.Properties.Clone(),
				Vault = this.Vault,
				VersionData = this.versionData.Clone()
			};
			clone.versionData.checkedOut = true;

			return clone;
		}

        public ObjVer ObjVer {
	        get { return VersionData.ObjVer; }
        }

        public PropertyValues Properties
        {
            get { return this.properties.Clone(); }
	        set
	        {
				properties = new TestPropertyValues();
		        foreach( PropertyValue propertyValue in value )
		        {
					TestPropertyValue pval = new TestPropertyValue();
					pval.PropertyDef = propertyValue.PropertyDef;
					pval.TypedValue = propertyValue.Value;
			        this.properties.Add( -1, pval );
		        }
	        }
        }

        public Vault Vault {
	        get { return testVault; }
	        set { testVault = (TestVault)value; }
        }

	    private TestVault testVault;

        public ObjectVersion VersionData {
	        get { return versionData; }
			set { versionData = new TestObjectVersion(value, testVault); }
        }
    }
}
