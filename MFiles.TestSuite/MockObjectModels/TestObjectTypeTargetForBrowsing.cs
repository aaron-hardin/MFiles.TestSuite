using System;
using MFiles.VaultJsonTools.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestObjectTypeTargetForBrowsing : ObjectTypeTargetForBrowsing
    {
        public TestObjectTypeTargetForBrowsing() { }

        public TestObjectTypeTargetForBrowsing(xObjectTypeTargetForBrowsing objectTypeTargetForBrowsing) 
        {
            this.TargetObjectType = objectTypeTargetForBrowsing.TargetObjectType;
            this.ViewCollection = objectTypeTargetForBrowsing.ViewCollection;
        }

        public ObjectTypeTargetForBrowsing Clone()
        {
            throw new NotImplementedException();
        }

        public int TargetObjectType { get; set; }

        public int ViewCollection { get; set; }
    }
}
