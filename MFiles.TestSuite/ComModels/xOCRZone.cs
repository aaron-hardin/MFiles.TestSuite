using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace VaultMockObjects.ComModels
{
    public class xOCRZone
    {
        public bool Barcode { get; set; }
        public int DataType { get; set; }
        public int DimensionUnit { get; set; }
        public bool HasOCROptions { get; set; }
        public int Height { get; set; }
        public int ID { get; set; }
        public int Left { get; set; }
        public string Name { get; set; }
        public xOCROptions OCROptions { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }

        public xOCRZone(OCRZone ocr)
        {
            this.Barcode = ocr.Barcode;
            this.DataType = (int) ocr.DataType;
            this.DimensionUnit = (int) ocr.DimensionUnit;
            this.HasOCROptions = ocr.HasOCROptions;
            this.Height = ocr.Height;
            this.ID = ocr.ID;
            this.Left = ocr.Left;
            this.Name = ocr.Name;
            this.OCROptions = new xOCROptions(ocr.OCROptions);
            this.Top = ocr.Top;
            this.Width = ocr.Width; 
        }
    }
}
