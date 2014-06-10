using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.ComModels
{
    public class xTypedValue
    {
        public int DataType { get; set; }
        public string DisplayValue { get; set; }
        public dynamic Value { get; set; }

        public xTypedValue() { }

        public xTypedValue(TypedValue tv)
        {
            this.DataType = (int) tv.DataType;
            this.DisplayValue = tv.DisplayValue;
            this.Value = tv.Value;
        }
    }
}
