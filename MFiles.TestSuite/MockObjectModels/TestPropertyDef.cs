using System;
using MFiles.VaultJsonTools.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestPropertyDef : PropertyDef
    {
        public TestPropertyDef() { }

        public TestPropertyDef(xPropertyDef pd)
        {
            this.AccessControlList = new TestAccessControlList(pd.AccessControlList);
            this.AllObjectTypes = pd.AllObjectTypes;
            this.AutomaticValueDefinition = new TestTypedValue(pd.AutomaticValueDefinition);
            this.AutomaticValueType = (MFAutomaticValueType)pd.AutomaticValueType;
            this.BasedOnValueList = pd.BasedOnValueList;
            this.ContentType = (MFContentType)pd.ContentType;
            this.DataType = (MFDataType)pd.DataType;
            this.DependencyPD = pd.DependencyPD;
            this.DependencyRelation = (MFDependencyRelation)pd.DependencyRelation;
            this.GUID = pd.GUID;
            this.ID = pd.ID;
            this.Name = pd.Name;
            this.ObjectType = pd.ObjectType;
            this.OwnerPropertyDef = new TestOwnerPropertyDef(pd.OwnerPropertyDef);
            this.Predefined = pd.Predefined;
            this.SortAscending = pd.SortAscending;
            this.StaticFilter = new SearchConditions();
            foreach (xSearchCondition searchCondition in pd.StaticFilter)
            {
                TestSearchCondition tsc = new TestSearchCondition(searchCondition);
                this.StaticFilter.Add(-1, tsc);
            }
            this.ThisIsConflictPD = pd.ThisIsConflictPD;
            this.ThisIsDefaultPD = pd.ThisIsDefaultPD;
            this.ThisIsOwnerPD = pd.ThisIsOwnerPD;
            this.UpdateType = (MFUpdateType)pd.UpdateType;
            this.ValueList = pd.ValueList;
            this.ValueListSortingType = (MFValueListSortingType)pd.ValueListSortingType;
        }

        public AccessControlList AccessControlList { get; set; }

        public bool AllObjectTypes { get; set; }

        public string AutomaticValue { get; set; }

        public TypedValue AutomaticValueDefinition { get; set; }

        public MFAutomaticValueType AutomaticValueType { get; set; }

        public bool BasedOnValueList { get; set; }

        public PropertyDef Clone()
        {
            throw new NotImplementedException();
        }

        public MFContentType ContentType { get; set; }

        public MFDataType DataType { get; set; }

        public int DependencyPD { get; set; }

        public MFDependencyRelation DependencyRelation { get; set; }

        public string GUID { get; set; }

        public int ID { get; set; }

        public string Name { get; set; }

        public int ObjectType { get; set; }

        public OwnerPropertyDef OwnerPropertyDef { get; set; }

        public bool Predefined { get; set; }

        public bool SortAscending { get; set; }

        public SearchConditions StaticFilter { get; set; }

        public bool ThisIsConflictPD { get; set; }

        public bool ThisIsDefaultPD { get; set; }

        public bool ThisIsOwnerPD { get; set; }

        public MFUpdateType UpdateType { get; set; }

        public int ValueList { get; set; }

        public MFValueListSortingType ValueListSortingType { get; set; }
    }
}
