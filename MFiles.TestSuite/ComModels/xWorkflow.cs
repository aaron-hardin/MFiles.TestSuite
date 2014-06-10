using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.ComModels
{
    public class xWorkflow
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ObjectClass { get; set; }

        public xWorkflow() { }

        public xWorkflow(Workflow wf)
        {
            this.ID = wf.ID;
            this.Name = wf.Name;
            this.ObjectClass = wf.ObjectClass;
        }
    }
}
