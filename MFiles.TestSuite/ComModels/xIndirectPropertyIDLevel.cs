using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.ComModels
{
    public class xIndirectPropertyIDLevel
    {
        public int ID { get; set; }
        public int LevelType { get; set; }

        public xIndirectPropertyIDLevel() { }

        public xIndirectPropertyIDLevel(IndirectPropertyIDLevel idpLevel)
        {
            this.ID = idpLevel.ID;
            this.LevelType = (int) idpLevel.LevelType;
        }
    }
}
