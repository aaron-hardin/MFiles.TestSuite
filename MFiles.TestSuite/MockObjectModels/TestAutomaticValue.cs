using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;
using VaultMockObjects.ComModels;

namespace VaultMockObjects.MockObjectModels
{
    public class TestAutomaticValue : AutomaticValue
    {
        public TestAutomaticValue() { }

        public TestAutomaticValue(xAutomaticValue av)
        {
            this.ANSIncrement = av.ANSIncrement;
            this.ANVCode = av.ANVCode;
            this.CalculationOrderNumber = av.CalculationOrderNumber;
            this.CVSExpression = av.CVSExpression;
            this.CVVCode = av.CVVCode;
        }

        public int ANSIncrement { get; set; }

        public string ANVCode { get; set; }

        public string CVSExpression { get; set; }

        public string CVVCode { get; set; }

        public int CalculationOrderNumber { get; set; }

        public AutomaticValue Clone()
        {
            throw new NotImplementedException();
        }
    }
}
