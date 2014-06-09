using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;
using VaultMockObjects.ComModels;

namespace VaultMockObjects.MockObjectModels
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
