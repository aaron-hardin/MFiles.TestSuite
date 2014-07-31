using System;
using MFiles.VaultJsonTools.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestValidation : Validation
    {
        public TestValidation() { }

        public TestValidation(xValidation validation)
        {
            this.RegularExpression = validation.RegularExpression;
            this.VBScript = validation.VBScript;
        }

        public Validation Clone()
        {
            throw new NotImplementedException();
        }

        public string RegularExpression { get; set; }

        public string VBScript { get; set; }
    }
}
