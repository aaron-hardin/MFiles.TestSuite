﻿using MFiles.VaultJsonTools.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestActionConvertToPDF : ActionConvertToPDF
    {
        public TestActionConvertToPDF() { }

        public TestActionConvertToPDF(xActionConvertToPDF c2pdf)
        {
            this.FailOnUnsupportedSourceFiles = c2pdf.FailOnUnsupportedSourceFiles;
            this.OverwriteExistingFile = c2pdf.OverwriteExistingFile;
            this.PDFA1b = c2pdf.PDFA1b;
            this.StoreAsSeparateFile = c2pdf.StoreAsSeparateFile;
        }

        public ActionConvertToPDF Clone()
        {
            TestActionConvertToPDF c2pdf = new TestActionConvertToPDF
            {
                FailOnUnsupportedSourceFiles = this.FailOnUnsupportedSourceFiles,
                OverwriteExistingFile = this.OverwriteExistingFile,
                PDFA1b = this.PDFA1b,
                StoreAsSeparateFile = this.StoreAsSeparateFile
            };
            return c2pdf;
        }

        public bool FailOnUnsupportedSourceFiles { get; set; }

        public bool OverwriteExistingFile { get; set; }

        public bool PDFA1b { get; set; }

        public bool StoreAsSeparateFile { get; set; }
    }
}
