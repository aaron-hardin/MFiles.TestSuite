using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestPropertyValue : PropertyValue
    {
        public PropertyValue Clone()
        {
			TestPropertyValue val = new TestPropertyValue();
	        val.PropertyDef = PropertyDef;
	        val.Value = Value.Clone();
	        return val;
        }

        public string GetValueAsLocalizedText()
        {
	        return Value.DisplayValue;
        }

        public string GetValueAsText(bool Localized, bool NULLAsEmptyString, bool EmptyLookupDisplayValuesAsHidden, bool LongDateFormat, bool NoSeconds, bool NumericValueAsKilobytes)
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
            get { return this.Value; }
            set { this.Value = value; }
        }

        public TypedValue Value { get; set; }
    }
}
