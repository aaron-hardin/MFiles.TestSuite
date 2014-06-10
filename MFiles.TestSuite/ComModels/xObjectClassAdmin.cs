using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.ComModels
{
    public class xObjectClassAdmin
    {
        public xAssociatedPropertyDef[] AssociatedPropertyDefs { get; set; }
        public xAutomaticPermissions AutomaticPermissionsForObjects { get; set; }
        public bool ForceWorkflow { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public int NamePropertyDef { get; set; }
        public int ObjectType { get; set; }
        public bool Predefined { get; set; }
        public string[] SemanticAliases { get; set; }
        public int Workflow { get; set; }

        public xObjectClassAdmin() { }

        public xObjectClassAdmin(ObjectClassAdmin ocAdmin)
        {
            this.AssociatedPropertyDefs = (from AssociatedPropertyDef associatedPropertyDef in ocAdmin.AssociatedPropertyDefs select new xAssociatedPropertyDef(associatedPropertyDef)).ToArray();
            this.AutomaticPermissionsForObjects = new xAutomaticPermissions(ocAdmin.AutomaticPermissionsForObjects);
            this.ForceWorkflow = ocAdmin.ForceWorkflow;
            this.ID = ocAdmin.ID;
            this.Name = ocAdmin.Name;
            this.NamePropertyDef = ocAdmin.NamePropertyDef;
            this.ObjectType = ocAdmin.ObjectType;
            this.Predefined = ocAdmin.Predefined;
            this.SemanticAliases = ocAdmin.SemanticAliases.Value.Split(';');
            this.Workflow = ocAdmin.Workflow;
        }
    }
}
