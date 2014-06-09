using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;
using VaultMockObjects.ComModels;

namespace VaultMockObjects.MockObjectModels
{
    public class TestObjTypeAdmin : ObjTypeAdmin
    {
        public TestObjTypeAdmin()
        {
        }

        public TestObjTypeAdmin(xObjTypeAdmin objType)
        {
            this.ColumnMappings = new ObjTypeColumnMappings();
            if (objType.ColumnMappings != null)
            {
                foreach (xObjTypeColumnMapping colMapping in objType.ColumnMappings)
                {
                    this.ColumnMappings.Add(-1, new TestObjTypeColumnMapping(colMapping));
                }
            }

            this.ConnectionString = objType.ConnectionString;
            this.DefaultForAutomaticPermissions = new TestAutomaticPermissions(objType.DefaultForAutomaticPermissions);
            this.DefaultAccessControlList = new TestAccessControlList(objType.DefaultAccessControlList);
            this.DeleteStatement = objType.DeleteStatement;
            this.InsertIntoStatement = objType.InsertIntoStatement;
            this.ObjectType = new TestObjType(objType.ObjectType);
            this.SelectExtIDStatement = objType.SelectExtIDStatement;
            this.SelectStatement = objType.SelectStatement;
            this.SelectStatementOneRecord = objType.SelectStatementOneRecord;
            this.SemanticAliases = new SemanticAliases { Value = string.Join(";", objType.SemanticAliases) };
            this.Translatable = objType.Translatable;
            this.UpdateStatement = objType.UpdateStatement;
        }

        public ObjTypeAdmin Clone()
        {
            throw new NotImplementedException();
        }

        public ObjTypeColumnMappings ColumnMappings { get; set; }

        public string ConnectionString { get; set; }

        public AccessControlList DefaultAccessControlList { get; set; }

        public AutomaticPermissions DefaultForAutomaticPermissions { get; set; }

        public string DeleteStatement { get; set; }

        public string InsertIntoStatement { get; set; }

        public ObjType ObjectType { get; set; }

        public string SelectExtIDStatement { get; set; }

        public string SelectStatement { get; set; }

        public string SelectStatementOneRecord { get; set; }

        public SemanticAliases SemanticAliases { get; set; }

        public bool Translatable { get; set; }

        public string UpdateStatement { get; set; }
    }
}
