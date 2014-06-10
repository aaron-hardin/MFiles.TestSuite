using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestObjectVersionAndProperties : ObjectVersionAndProperties
    {
        private PropertyValues properties;

        public ObjectVersionAndProperties Clone()
        {
            TestObjectVersionAndProperties clone = new TestObjectVersionAndProperties
            {
                ObjVer = this.ObjVer.Clone(),
                Properties = this.Properties.Clone(),
                Vault = this.Vault,
                VersionData = this.VersionData.Clone()
            };
            return clone;
        }

        public ObjVer ObjVer { get; set; }

        public PropertyValues Properties
        {
            get { return this.properties.Clone(); }
            set { this.properties = value; }
        }

        public Vault Vault { get; set; }

        public ObjectVersion VersionData { get; set; }
    }
}
