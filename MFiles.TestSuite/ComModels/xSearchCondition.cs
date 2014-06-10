using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.ComModels
{
    public class xSearchCondition
    {
        public int ConditionType { get; set; }
        public xExpression Expression { get; set; }
        public xTypedValue TypedValue { get; set; }

        public xSearchCondition() { }

        public xSearchCondition(SearchCondition sc)
        {
            this.ConditionType = (int) sc.ConditionType;
            this.Expression = new xExpression(sc.Expression);
            this.TypedValue = new xTypedValue(sc.TypedValue);
        }
    }
}
