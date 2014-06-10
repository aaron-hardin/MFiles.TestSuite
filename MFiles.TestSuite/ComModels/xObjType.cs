using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.ComModels
{
    public class xObjType
    {
        public xAccessControlList AccessControlList { get; set; }
        public bool AllowAdding { get; set; }
        public bool CanHaveFiles { get; set; }
        public xAccessControlList DefaultAccessControlList { get; set; }
        public int DefaultPropertyDef { get; set; }
        public bool External { get; set; }
        public string GUID { get; set; }
        public bool HasOwnerType { get; set; }
        public bool Hierarchical { get; set; }
        public byte[] Icon { get; set; }
        public int ID { get; set; }
        public string NamePlural { get; set; }
        public string NameSingular { get; set; }

        public List<xObjectTypeTargetForBrowsing> ObjectTypeTargetsForBrowsing { get; set; }
        public int OwnerPropertyDef { get; set; }
        public int OwnerType { get; set; }
        public int[] ReadOnlyPropertiesDuringInsert { get; set; }
        public int[] ReadOnlyPropertiesDuringUpdate { get; set; }
        public bool RealObjectType { get; set; }
        public bool ShowCreationCommandInTaskPane { get; set; }

        public xObjType() { }

        public xObjType(ObjType objType)
        {
            this.AccessControlList = new xAccessControlList(objType.AccessControlList);
            this.AllowAdding = objType.AllowAdding;
            this.CanHaveFiles = objType.CanHaveFiles;
            this.DefaultAccessControlList = new xAccessControlList(objType.DefaultAccessControlList);
            this.DefaultPropertyDef = objType.DefaultPropertyDef;
            this.External = objType.External;
            this.GUID = objType.GUID;
            this.HasOwnerType = objType.HasOwnerType;
            this.Hierarchical = objType.Hierarchical;
            // this.Icon = objType.Icon;
            this.ID = objType.ID;
            this.NamePlural = objType.NamePlural;
            this.NameSingular = objType.NameSingular;
			this.ObjectTypeTargetsForBrowsing = new List<xObjectTypeTargetForBrowsing>();
            foreach (ObjectTypeTargetForBrowsing targetForBrowsing in objType.ObjectTypeTargetsForBrowsing)
            {
	            xObjectTypeTargetForBrowsing ottfb = new xObjectTypeTargetForBrowsing(targetForBrowsing);
                this.ObjectTypeTargetsForBrowsing.Add(ottfb);
            }            
            this.OwnerPropertyDef = objType.OwnerPropertyDef;
            this.OwnerType = objType.OwnerType;
            this.ReadOnlyPropertiesDuringInsert = objType.ReadOnlyPropertiesDuringInsert.Cast<int>().ToArray();
            this.ReadOnlyPropertiesDuringUpdate = objType.ReadOnlyPropertiesDuringUpdate.Cast<int>().ToArray();
            this.RealObjectType = objType.RealObjectType;
            this.ShowCreationCommandInTaskPane = objType.ShowCreationCommandInTaskPane;
        }
    }
}
