using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.ComModels
{
    public class xOCROptions
    {

        public int PrimaryLanguage { get; set; }
        public int SecondaryLanguage { get; set; }

        public xOCROptions(OCROptions ocrOps)
        {
            this.PrimaryLanguage = (int) ocrOps.PrimaryLanguage;
            this.SecondaryLanguage = (int) ocrOps.SecondaryLanguage;
        }
    }
}
