using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;
using VaultMockObjects.ComModels;

namespace VaultMockObjects.MockObjectModels
{
    public class TestWorkflow : Workflow
    {
        public TestWorkflow() { }

        public TestWorkflow(xWorkflow wf)
        {
            this.ID = wf.ID;
            this.Name = wf.Name;
            this.ObjectClass = wf.ObjectClass;
        }

        public Workflow Clone()
        {
            throw new NotImplementedException();
        }

        public Lookup GetAsLookup()
        {
            throw new NotImplementedException();
        }

        public TypedValue GetAsTypedValue()
        {
            throw new NotImplementedException();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public int ObjectClass { get; set; }
    }
}
