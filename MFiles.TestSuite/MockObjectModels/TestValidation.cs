using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;
using VaultMockObjects.ComModels;

namespace VaultMockObjects.MockObjectModels
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
