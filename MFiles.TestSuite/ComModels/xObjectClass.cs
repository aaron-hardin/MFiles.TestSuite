using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.ComModels
{
    public class xObjectClass
    {
        public xAccessControlList ACLForObjects { get; set; }
        public xAccessControlList AccessControlList { get; set; }
        public List<xAssociatedPropertyDef> AssociatedPropertyDefs { get; set; }
        public xAutomaticPermissions AutomaticPermissionsForObjects { get; set; }
        public bool ForceWorkflow { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public int NamePropertyDef { get; set; }
        public int ObjectType { get; set; }
        public int Workflow { get; set; }

        public xObjectClass() { }

        public xObjectClass(ObjectClass oClass) 
        {
            this.ACLForObjects = new xAccessControlList(oClass.ACLForObjects);
            this.AccessControlList = new xAccessControlList(oClass.AccessControlList);
            this.AssociatedPropertyDefs = new List<xAssociatedPropertyDef>();
            foreach (AssociatedPropertyDef associatedPropertyDef in oClass.AssociatedPropertyDefs)
            {
                this.AssociatedPropertyDefs.Add(new xAssociatedPropertyDef(associatedPropertyDef));
            }
            this.AutomaticPermissionsForObjects = new xAutomaticPermissions(oClass.AutomaticPermissionsForObjects);
            this.ForceWorkflow = oClass.ForceWorkflow;
            this.ID = oClass.ID;
            this.Name = oClass.Name;
            this.NamePropertyDef = oClass.NamePropertyDef;
            this.ObjectType = oClass.ObjectType;
            this.Workflow = oClass.Workflow;
        }
    }
}
