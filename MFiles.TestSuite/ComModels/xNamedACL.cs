﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.ComModels
{
    public class xNamedACL
    {
        public xAccessControlList AccessControlList { get; set; }
        public string GUID { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public int NamedACLType { get; set; }

        public xNamedACL(NamedACL namedAcl)
        {
            this.AccessControlList = new xAccessControlList(namedAcl.AccessControlList);
            this.GUID = namedAcl.GUID;
            this.ID = namedAcl.ID;
            this.Name = namedAcl.Name;
            this.NamedACLType = (int) namedAcl.NamedACLType;
        }
    }
}