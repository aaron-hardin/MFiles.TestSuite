using System;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestPropertyValue : PropertyValue
    {
		public TestPropertyValue()
		{
			TypedValue = new TestTypedValue();
		}

        public PropertyValue Clone()
        {
			TestPropertyValue val = new TestPropertyValue { PropertyDef = PropertyDef, Value = Value.Clone() };
	        return val;
        }

        public string GetValueAsLocalizedText()
        {
	        return Value.DisplayValue;
        }

        public string GetValueAsText(bool localized, bool nullAsEmptyString, bool emptyLookupDisplayValuesAsHidden, bool longDateFormat, bool noSeconds, bool numericValueAsKilobytes)
        {
            throw new NotImplementedException();
        }

        public string GetValueAsUnlocalizedText()
        {
            throw new NotImplementedException();
        }

        public int PropertyDef { get; set; }

        public TypedValue TypedValue
        {
            get { return Value; }
            set { Value = value; }
        }

        public TypedValue Value { get; set; }
    }
}
