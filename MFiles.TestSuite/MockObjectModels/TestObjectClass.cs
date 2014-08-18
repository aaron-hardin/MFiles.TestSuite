using System;
using MFiles.VaultJsonTools.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestObjectClass : ObjectClass
    {
        public TestObjectClass() { }

		public TestObjectClass(TestObjectClassAdmin oClass)
		{
			AssociatedPropertyDefs = new TestAssociatedPropertyDefs();
			foreach (AssociatedPropertyDef associatedPropertyDef in oClass.AssociatedPropertyDefs)
			{
				AssociatedPropertyDefs.Add(-1, associatedPropertyDef);
			}
			AutomaticPermissionsForObjects = oClass.AutomaticPermissionsForObjects;
			ForceWorkflow = oClass.ForceWorkflow;
			ID = oClass.ID;
			Name = oClass.Name;
			NamePropertyDef = oClass.NamePropertyDef;
			ObjectType = oClass.ObjectType;
			Workflow = oClass.Workflow;
		}

		public TestObjectClass(ObjectClassAdmin oca)
		{
			xObjectClassAdmin oClass = new xObjectClassAdmin(oca);
			AssociatedPropertyDefs = new AssociatedPropertyDefs();
			foreach (xAssociatedPropertyDef associatedPropertyDef in oClass.AssociatedPropertyDefs)
			{
				AssociatedPropertyDefs.Add(-1, new TestAssociatedPropertyDef(associatedPropertyDef));
			}
			AutomaticPermissionsForObjects = new TestAutomaticPermissions(oClass.AutomaticPermissionsForObjects);
			ForceWorkflow = oClass.ForceWorkflow;
			ID = oClass.ID;
			Name = oClass.Name;
			NamePropertyDef = oClass.NamePropertyDef;
			ObjectType = oClass.ObjectType;
			Workflow = oClass.Workflow;
		}

        public TestObjectClass(xObjectClass oClass) 
        {
            ACLForObjects = new TestAccessControlList(oClass.ACLForObjects);
            AccessControlList = new TestAccessControlList(oClass.AccessControlList);
            AssociatedPropertyDefs = new AssociatedPropertyDefs();
            foreach (xAssociatedPropertyDef associatedPropertyDef in oClass.AssociatedPropertyDefs)
            {
                AssociatedPropertyDefs.Add(-1, new TestAssociatedPropertyDef(associatedPropertyDef));
            }
            AutomaticPermissionsForObjects = new TestAutomaticPermissions(oClass.AutomaticPermissionsForObjects);
            ForceWorkflow = oClass.ForceWorkflow;
            ID = oClass.ID;
            Name = oClass.Name;
            NamePropertyDef = oClass.NamePropertyDef;
            ObjectType = oClass.ObjectType;
            Workflow = oClass.Workflow;
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
