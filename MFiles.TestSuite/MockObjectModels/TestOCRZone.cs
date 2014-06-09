using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;
using VaultMockObjects.ComModels;

namespace VaultMockObjects.MockObjectModels
{
    public class TestOCRZone : OCRZone
    {
        public TestOCRZone() { }

        public TestOCRZone(xOCRZone ocr)
        {
            this.Barcode = ocr.Barcode;
            this.DataType = (MFDataType)ocr.DataType;
            this.DimensionUnit = (MFOCRDimensionUnit)ocr.DimensionUnit;
            this.HasOCROptions = ocr.HasOCROptions;
            this.Height = ocr.Height;
            this.ID = ocr.ID;
            this.Left = ocr.Left;
            this.Name = ocr.Name;
            this.OCROptions = new TestOCROptions(ocr.OCROptions);
            this.Top = ocr.Top;
            this.Width = ocr.Width;
        }

        public bool Barcode { get; set; }

        public void ClearOCROptions()
        {
            throw new NotImplementedException();
        }

        public OCRZone Clone()
        {
            TestOCRZone ocr = new TestOCRZone
            {
                Barcode = this.Barcode,
                DataType = this.DataType,
                DimensionUnit = this.DimensionUnit,
                HasOCROptions = this.HasOCROptions,
                Height = this.Height,
                ID = this.ID,
                Left = this.Left,
                Name = this.Name,
                OCROptions = this.OCROptions.Clone(),
                Top = this.Top,
                Width = this.Width
            };
            return ocr;
        }

        public MFDataType DataType { get; set; }

        public MFOCRDimensionUnit DimensionUnit { get; set; }

        public bool HasOCROptions { get; set; }

        public int Height { get; set; }

        public int ID { get; set; }

        public int Left { get; set; }

        public string Name { get; set; }

        public OCROptions OCROptions { get; set; }

        public void SetOCROptions(OCROptions OCROptions)
        {
            throw new NotImplementedException();
        }

        public int Top { get; set; }

        public int Width { get; set; }
    }
}
