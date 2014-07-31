using System;
using MFiles.VaultJsonTools.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestSearchCondition : SearchCondition
    {
        public TestSearchCondition() { }

        public TestSearchCondition(xSearchCondition sc)
        {
            this.ConditionType = (MFConditionType)sc.ConditionType;
            this.Expression = new TestExpression(sc.Expression);
            this.TypedValue = new TestTypedValue(sc.TypedValue);
        }

        public SearchCondition Clone()
        {
            TestSearchCondition newSeachCondition = new TestSearchCondition
            {
                ConditionType = this.ConditionType,
                Expression = this.Expression.Clone(),
                TypedValue = this.TypedValue.Clone()
            };
            return newSeachCondition;
        }

        public MFConditionType ConditionType { get; set; }

        public Expression Expression { get; set; }

        public void Set(Expression Expression, MFConditionType ConditionType, TypedValue TypedValue)
        {
            throw new NotImplementedException();
        }

        public TypedValue TypedValue { get; set; }
    }
}
