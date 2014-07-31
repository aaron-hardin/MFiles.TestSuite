using System;
using MFiles.VaultJsonTools.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestObjType : ObjType
    {
        public TestObjType()
        {
        }

        public TestObjType(xObjType objType)
        {
            this.AccessControlList = new TestAccessControlList(objType.AccessControlList);
            this.AllowAdding = objType.AllowAdding;
            this.CanHaveFiles = objType.CanHaveFiles;
            this.DefaultAccessControlList = new TestAccessControlList(objType.DefaultAccessControlList);
            this.DefaultPropertyDef = objType.DefaultPropertyDef;
            this.External = objType.External;
            this.GUID = objType.GUID;
            this.HasOwnerType = objType.HasOwnerType;
            this.Hierarchical = objType.Hierarchical;
            // this.Icon = objType.Icon;
            this.ID = objType.ID;
            this.NamePlural = objType.NamePlural;
            this.NameSingular = objType.NameSingular;
            this.ObjectTypeTargetsForBrowsing = new ObjectTypeTargetsForBrowsing();
            if (objType.ObjectTypeTargetsForBrowsing != null)
            {
                foreach (xObjectTypeTargetForBrowsing targetForBrowsing in objType.ObjectTypeTargetsForBrowsing)
                {
                    TestObjectTypeTargetForBrowsing ottfb = new TestObjectTypeTargetForBrowsing(targetForBrowsing);
                    this.ObjectTypeTargetsForBrowsing.Add(-1, ottfb);
                }
            }
            this.OwnerPropertyDef = objType.OwnerPropertyDef;
            this.OwnerType = objType.OwnerType;
            this.ReadOnlyPropertiesDuringInsert = new IDs();
            foreach (int id in objType.ReadOnlyPropertiesDuringInsert)
            {
                this.ReadOnlyPropertiesDuringInsert.Add(-1, id);
            }
            this.ReadOnlyPropertiesDuringUpdate = new IDs();
            foreach (int id in objType.ReadOnlyPropertiesDuringUpdate)
            {
                this.ReadOnlyPropertiesDuringUpdate.Add(-1, id);
            }
            this.RealObjectType = objType.RealObjectType;
            this.ShowCreationCommandInTaskPane = objType.ShowCreationCommandInTaskPane;
        }

        public AccessControlList AccessControlList { get; set; }

        public bool AllowAdding { get; set; }

        public bool CanHaveFiles { get; set; }

        public bool CanHaveItemIcons()
        {
            throw new NotImplementedException();
        }

        public ObjType Clone()
        {
            throw new NotImplementedException();
        }

        public AccessControlList DefaultAccessControlList { get; set; }

        public int DefaultPropertyDef { get; set; }

        public bool External { get; set; }

        public string GUID { get; set; }

        public byte[] GetIconAsPNG(int Width, int Height)
        {
            throw new NotImplementedException();
        }

        public bool HasOwnerType { get; set; }

        public bool Hierarchical { get; set; }

        public int ID { get; set; }

        public byte[] Icon { get; set; }

        public bool IsAddingAllowedForUser(SessionInfo SessionInfo)
        {
            throw new NotImplementedException();
        }

        public string NamePlural { get; set; }

        public string NameSingular { get; set; }

        public ObjectTypeTargetsForBrowsing ObjectTypeTargetsForBrowsing { get; set; }

        public int OwnerPropertyDef { get; set; }

        public int OwnerType { get; set; }

        public IDs ReadOnlyPropertiesDuringInsert { get; set; }

        public IDs ReadOnlyPropertiesDuringUpdate { get; set; }

        public bool RealObjectType { get; set; }

        public bool ShowCreationCommandInTaskPane { get; set; }

        public bool SupportsStartsWithAtWordBoundarySearches { get; set; }
    }
}
