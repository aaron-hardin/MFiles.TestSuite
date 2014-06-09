using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace VaultMockObjects.ComModels
{
    public class xActionConvertToPDF
    {
        public bool FailOnUnsupportedSourceFiles { get; set; }
        public bool OverwriteExistingFile { get; set; }
        public bool PDFA1b { get; set; }
        public bool StoreAsSeparateFile { get; set; }

        public xActionConvertToPDF() { }

        public xActionConvertToPDF(ActionConvertToPDF c2pdf)
        {
            this.FailOnUnsupportedSourceFiles = c2pdf.FailOnUnsupportedSourceFiles;
            this.OverwriteExistingFile = c2pdf.OverwriteExistingFile;
            this.PDFA1b = c2pdf.PDFA1b;
            this.StoreAsSeparateFile = c2pdf.StoreAsSeparateFile;
        }
    }
}
