using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;
using VaultMockObjects.ComModels;

namespace VaultMockObjects.MockObjectModels
{
    public class TestObjectClassAdmin : ObjectClassAdmin
    {
        public TestObjectClassAdmin() { }

        public TestObjectClassAdmin(xObjectClassAdmin ocAdmin)
        {
            this.AssociatedPropertyDefs = new AssociatedPropertyDefs();
            foreach (xAssociatedPropertyDef propertyDef in ocAdmin.AssociatedPropertyDefs)
            {
                this.AssociatedPropertyDefs.Add(-1, new TestAssociatedPropertyDef(propertyDef));
            }
            this.AutomaticPermissionsForObjects = new TestAutomaticPermissions(ocAdmin.AutomaticPermissionsForObjects);
            this.ForceWorkflow = ocAdmin.ForceWorkflow;
            this.ID = ocAdmin.ID;
            this.Name = ocAdmin.Name;
            this.NamePropertyDef = ocAdmin.NamePropertyDef;
            this.ObjectType = ocAdmin.ObjectType;
            this.Predefined = ocAdmin.Predefined;
            this.SemanticAliases = new SemanticAliases { Value = string.Join(";", ocAdmin.SemanticAliases) };
            this.Workflow = ocAdmin.Workflow;
        }

        public AccessControlList ACLForObjects { get; set; }

        public AssociatedPropertyDefs AssociatedPropertyDefs { get; set; }

        public AutomaticPermissions AutomaticPermissionsForObjects { get; set; }

        public ObjectClassAdmin Clone()
        {
            throw new NotImplementedException();
        }

        public bool ForceWorkflow { get; set; }

        public int ID { get; set; }

        public string Name { get; set; }

        public int NamePropertyDef { get; set; }

        public int ObjectType { get; set; }

        public bool Predefined { get; set; }

        public SemanticAliases SemanticAliases { get; set; }

        public int Workflow { get; set; }
    }
}
