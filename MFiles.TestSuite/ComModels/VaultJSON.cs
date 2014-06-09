using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace VaultMockObjects.ComModels
{
    public class VaultJSON
    {
        public string Objects { get; set; }
        public string Classes { get; set; }
        public string Properties { get; set; }
        public string ValueLists { get; set; }
        public string Workflows { get; set; }
    }
}
