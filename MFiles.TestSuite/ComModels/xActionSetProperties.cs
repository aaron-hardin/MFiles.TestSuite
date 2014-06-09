using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace VaultMockObjects.ComModels
{
    public class xActionSetProperties
    {
        public xDefaultProperty[] Properties { get; set; }

        public xActionSetProperties() { }

        public xActionSetProperties(ActionSetProperties asp)
        {
            this.Properties = (from DefaultProperty prop in asp.Properties select new xDefaultProperty(prop)).ToArray();
        }
    }
}
