using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace VaultMockObjects.ComModels
{
    public class xAutomaticValue
    {
        public int ANSIncrement { get; set; }
        public string ANVCode { get; set; }
        public int CalculationOrderNumber { get; set; }
        public string CVSExpression { get; set; }
        public string CVVCode { get; set; }

        public xAutomaticValue() { }

        public xAutomaticValue(AutomaticValue av)
        {
            this.ANSIncrement = av.ANSIncrement;
            this.ANVCode = av.ANVCode;
            this.CalculationOrderNumber = av.CalculationOrderNumber;
            this.CVSExpression = av.CVSExpression;
            this.CVVCode = av.CVVCode;
        }
    }
}
