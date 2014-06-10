using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.ComModels
{
    public class xPropertyDef
    {
        public xAccessControlList AccessControlList { get; set; }
        public bool AllObjectTypes { get; set; }
        public xTypedValue AutomaticValueDefinition { get; set; }
        public int AutomaticValueType { get; set; }
        public bool BasedOnValueList { get; set; }
        public int ContentType { get; set; }
        public int DataType { get; set; }
        public int DependencyPD { get; set; }
        public int DependencyRelation { get; set; }
        public string GUID { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public int ObjectType { get; set; }
        public xOwnerPropertyDef OwnerPropertyDef { get; set; }
        public bool Predefined { get; set; }
        public bool SortAscending { get; set; }
        public xSearchCondition[] StaticFilter { get; set; }
        public bool ThisIsConflictPD { get; set; }
        public bool ThisIsDefaultPD { get; set; }
        public bool ThisIsOwnerPD { get; set; }
        public int UpdateType { get; set; }
        public int ValueList { get; set; }
        public int ValueListSortingType { get; set; }

        public xPropertyDef() { }

        public xPropertyDef(PropertyDef pd)
        {
            this.AccessControlList = new xAccessControlList(pd.AccessControlList);
            this.AllObjectTypes = pd.AllObjectTypes;
            this.AutomaticValueDefinition = new xTypedValue(pd.AutomaticValueDefinition);
            this.AutomaticValueType = (int) pd.AutomaticValueType;
            this.BasedOnValueList = pd.BasedOnValueList;
            this.ContentType = (int) pd.ContentType;
            this.DataType = (int) pd.DataType;
            this.DependencyPD = pd.DependencyPD;
            this.DependencyRelation = (int) pd.DependencyRelation;
            this.GUID = pd.GUID;
            this.ID = pd.ID;
            this.Name = pd.Name;
            this.ObjectType = pd.ObjectType;
            this.OwnerPropertyDef = new xOwnerPropertyDef(pd.OwnerPropertyDef);
            this.Predefined = pd.Predefined;
            this.SortAscending = pd.SortAscending;
            this.StaticFilter = (from SearchCondition searchCondition in pd.StaticFilter select new xSearchCondition(searchCondition)).ToArray();
            this.ThisIsConflictPD = pd.ThisIsConflictPD;
            this.ThisIsDefaultPD = pd.ThisIsDefaultPD;
            this.ThisIsOwnerPD = pd.ThisIsOwnerPD;
            this.UpdateType = (int) pd.UpdateType;
            this.ValueList = pd.ValueList;
            this.ValueListSortingType = (int) pd.ValueListSortingType;
        }

    }
}
