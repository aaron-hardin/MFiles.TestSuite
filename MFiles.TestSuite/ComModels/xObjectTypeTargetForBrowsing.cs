using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.ComModels
{
    public class xObjectTypeTargetForBrowsing
    {
        public int TargetObjectType { get; set; }
        public int ViewCollection  { get; set; }

        public xObjectTypeTargetForBrowsing(ObjectTypeTargetForBrowsing objectTypeTargetsForBrowsing)
        {
            this.TargetObjectType = objectTypeTargetsForBrowsing.TargetObjectType;
            this.ViewCollection = objectTypeTargetsForBrowsing.ViewCollection;
        }
    }
}
