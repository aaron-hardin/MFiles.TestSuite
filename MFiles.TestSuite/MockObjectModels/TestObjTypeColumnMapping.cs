using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;
using VaultMockObjects.ComModels;

namespace VaultMockObjects.MockObjectModels
{
    public class TestObjTypeColumnMapping : ObjTypeColumnMapping
    {
        public TestObjTypeColumnMapping() { }

        public TestObjTypeColumnMapping(xObjTypeColumnMapping columnMapping)
        {
            this.ObjectType = columnMapping.ObjectType;
            this.Ordinal = columnMapping.Ordinal;
            this.PartOfInsert = columnMapping.PartOfInsert;
            this.PartOfUpdate = columnMapping.PartOfUpdate;
            this.SourceField = columnMapping.SourceField;
            this.TargetPropertyDef = columnMapping.TargetPropertyDef;
            this.Type = (short)columnMapping.Type;
        }

        public ObjTypeColumnMapping Clone()
        {
            throw new NotImplementedException();
        }

        public int ObjectType { get; set; }

        public int Ordinal { get; set; }

        public bool PartOfInsert { get; set; }

        public bool PartOfUpdate { get; set; }

        public string SourceField { get; set; }

        public int TargetPropertyDef { get; set; }

        public short Type { get; set; }
    }
}
