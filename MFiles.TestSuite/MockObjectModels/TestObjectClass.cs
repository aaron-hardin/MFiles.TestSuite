using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;
using VaultMockObjects.ComModels;

namespace VaultMockObjects.MockObjectModels
{
    public class TestObjectClass : ObjectClass
    {
        public TestObjectClass() { }

        public TestObjectClass(xObjectClass oClass) 
        {
            this.ACLForObjects = new TestAccessControlList(oClass.ACLForObjects);
            this.AccessControlList = new TestAccessControlList(oClass.AccessControlList);
            this.AssociatedPropertyDefs = new AssociatedPropertyDefs();
            foreach (xAssociatedPropertyDef associatedPropertyDef in oClass.AssociatedPropertyDefs)
            {
                this.AssociatedPropertyDefs.Add(-1, new TestAssociatedPropertyDef(associatedPropertyDef));
            }
            this.AutomaticPermissionsForObjects = new TestAutomaticPermissions(oClass.AutomaticPermissionsForObjects);
            this.ForceWorkflow = oClass.ForceWorkflow;
            this.ID = oClass.ID;
            this.Name = oClass.Name;
            this.NamePropertyDef = oClass.NamePropertyDef;
            this.ObjectType = oClass.ObjectType;
            this.Workflow = oClass.Workflow;
        }

        public AccessControlList ACLForObjects { get; set; }

        public AccessControlList AccessControlList { get; set; }

        public AssociatedPropertyDefs AssociatedPropertyDefs { get; set; }

        public AutomaticPermissions AutomaticPermissionsForObjects { get; set; }

        public ObjectClass Clone()
        {
            throw new NotImplementedException();
        }

        public bool ForceWorkflow { get; set; }

        public int ID { get; set; }

        public string Name { get; set; }

        public int NamePropertyDef { get; set; }

        public int ObjectType { get; set; }

        public int Workflow { get; set; }
    }
}
