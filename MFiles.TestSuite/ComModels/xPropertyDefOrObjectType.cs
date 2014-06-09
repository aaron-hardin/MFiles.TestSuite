using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace VaultMockObjects.ComModels
{
    public class xPropertyDefOrObjectType
    {
        public int ID { get; set; }
        public bool PropertyDef { get; set; }

        public xPropertyDefOrObjectType(PropertyDefOrObjectType pdot)
        {
            this.ID = pdot.ID;
            this.PropertyDef = pdot.PropertyDef;
        }
    }
}
