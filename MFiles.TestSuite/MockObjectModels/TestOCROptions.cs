using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;
using VaultMockObjects.ComModels;

namespace VaultMockObjects.MockObjectModels
{
    public class TestOCROptions : OCROptions
    {
        public TestOCROptions() { }

        public TestOCROptions(xOCROptions ocr)
        {
            this.PrimaryLanguage = (MFOCRLanguage)ocr.PrimaryLanguage;
            this.SecondaryLanguage = (MFOCRLanguage)ocr.SecondaryLanguage;
        }

        public OCROptions Clone()
        {
            TestOCROptions ocr = new TestOCROptions
            {
                PrimaryLanguage = this.PrimaryLanguage,
                SecondaryLanguage = this.SecondaryLanguage
            };
            return ocr;
        }

        public MFOCRLanguage PrimaryLanguage { get; set; }

        public MFOCRLanguage SecondaryLanguage { get; set; }
    }
}
