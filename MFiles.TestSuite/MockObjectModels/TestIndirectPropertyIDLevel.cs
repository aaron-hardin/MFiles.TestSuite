using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;
using VaultMockObjects.ComModels;

namespace VaultMockObjects.MockObjectModels
{
    public class TestIndirectPropertyIDLevel : IndirectPropertyIDLevel
    {
        public TestIndirectPropertyIDLevel() { }

        public TestIndirectPropertyIDLevel(xIndirectPropertyIDLevel idpLevel)
        {
            this.ID = idpLevel.ID;
            this.LevelType = (MFIndirectPropertyIDLevelType)idpLevel.LevelType;
        }

        public IndirectPropertyIDLevel Clone()
        {
            TestIndirectPropertyIDLevel idpLevel = new TestIndirectPropertyIDLevel
            {
                ID = this.ID,
                LevelType = this.LevelType
            };
            return idpLevel;
        }

        public int ID { get; set; }

        public MFIndirectPropertyIDLevelType LevelType { get; set; }
    }
}
