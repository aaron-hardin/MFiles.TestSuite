using MFiles.VaultJsonTools.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestOwnerPropertyDef : OwnerPropertyDef
    {
        public TestOwnerPropertyDef() { }

        public TestOwnerPropertyDef(xOwnerPropertyDef opd)
        {
            this.DependencyRelation = (MFDependencyRelation)opd.DependencyRelation;
            this.ID = opd.ID;
            if (opd.IndexForAutomaticFilling.HasValue)
                this.IndexForAutomaticFilling = opd.IndexForAutomaticFilling.Value;
            this.IsRelationFiltering = opd.IsRelationFiltering;
        }

        public MFDependencyRelation DependencyRelation { get; set; }

        public int ID { get; set; }

        public int IndexForAutomaticFilling { get; set; }

        public bool IsRelationFiltering { get; set; }
    }
}
