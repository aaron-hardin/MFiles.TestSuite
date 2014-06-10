using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFiles.TestSuite.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestActionSetProperties : ActionSetProperties
    {
        public TestActionSetProperties() { }

        public TestActionSetProperties(xActionSetProperties asp) 
        {
            this.Properties = new DefaultProperties();
            foreach (xDefaultProperty defaultProperty in asp.Properties)
            {
                this.Properties.Add(-1, new TestDefaultProperty(defaultProperty));
            }
        }

        public ActionSetProperties Clone()
        {
            TestActionSetProperties asp = new TestActionSetProperties { Properties = new DefaultProperties() };
            for (int i = 1; i <= this.Properties.Count; ++i)
            {
                DefaultProperty defaultProperty = this.Properties[i];
                asp.Properties.Add(-1, defaultProperty.Clone());
            }
            return asp;
        }

        public DefaultProperties Properties { get; set; }
    }
}
