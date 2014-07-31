using MFiles.VaultJsonTools.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
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
