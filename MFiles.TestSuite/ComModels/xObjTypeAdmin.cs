using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.ComModels
{
    public class xObjTypeAdmin
    {
        public List<xObjTypeColumnMapping> ColumnMappings { get; set; }

        public string ConnectionString { get; set; }
        public xAutomaticPermissions DefaultForAutomaticPermissions { get; set; }
        public xAccessControlList DefaultAccessControlList { get; set; }
        public string DeleteStatement { get; set; }
        public string InsertIntoStatement { get; set; }
        public xObjType ObjectType { get; set; }
        public string SelectExtIDStatement { get; set; }
        public string SelectStatement { get; set; }
        public string SelectStatementOneRecord { get; set; }
        public string[] SemanticAliases { get; set; }
        public bool Translatable { get; set; }
        public string UpdateStatement { get; set; }

        public xObjTypeAdmin() { }

        public xObjTypeAdmin(ObjTypeAdmin objType)
        {
            this.ColumnMappings = new List<xObjTypeColumnMapping>();
            if (objType.ColumnMappings != null)
            {
                foreach (ObjTypeColumnMapping colMapping in objType.ColumnMappings)
                {
                    this.ColumnMappings.Add(new xObjTypeColumnMapping(colMapping));
                }
            }
            
            this.ConnectionString = objType.ConnectionString;
            this.DefaultForAutomaticPermissions = new xAutomaticPermissions(objType.DefaultForAutomaticPermissions);
            this.DefaultAccessControlList = new xAccessControlList(objType.DefaultAccessControlList);
            this.DeleteStatement = objType.DeleteStatement;
            this.InsertIntoStatement = objType.InsertIntoStatement;
            this.ObjectType = new xObjType(objType.ObjectType);
            this.SelectExtIDStatement = objType.SelectExtIDStatement;
            this.SelectStatement = objType.SelectStatement;
            this.SelectStatementOneRecord = objType.SelectStatementOneRecord;
            this.SemanticAliases = objType.SemanticAliases.Value.Split(';');
            this.Translatable = objType.Translatable;
            this.UpdateStatement = objType.UpdateStatement;
        }
    }
}
