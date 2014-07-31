using System;
using MFiles.VaultJsonTools.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
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
