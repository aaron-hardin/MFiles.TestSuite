using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace VaultMockObjects.ComModels
{
    public class xOwnerPropertyDef
    {
        public int DependencyRelation { get; set; }
        public int ID { get; set; }
        public int? IndexForAutomaticFilling { get; set; }
        public bool IsRelationFiltering { get; set; }

        public xOwnerPropertyDef() { }

        public xOwnerPropertyDef(OwnerPropertyDef opd)
        {
            this.DependencyRelation = (int) opd.DependencyRelation;
            this.ID = opd.ID;
            try
            {
                this.IndexForAutomaticFilling = opd.IndexForAutomaticFilling;
            }
            catch (Exception)
            {
                this.IndexForAutomaticFilling = null;
            }
            this.IsRelationFiltering = opd.IsRelationFiltering;
        }
    }
}
