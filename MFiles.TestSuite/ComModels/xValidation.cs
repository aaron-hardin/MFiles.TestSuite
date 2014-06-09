using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace VaultMockObjects.ComModels
{
    public class xValidation
    {
        public string RegularExpression { get; set; }
        public string VBScript { get; set; }

        public xValidation() { }

        public xValidation(Validation val)
        {
            this.RegularExpression = val.RegularExpression;
            this.VBScript = val.VBScript;
        }
    }
}
