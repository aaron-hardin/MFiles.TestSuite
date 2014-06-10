using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFiles.TestSuite.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestTypedValue : TypedValue
    {
        public TestTypedValue() { }

        public TestTypedValue(xTypedValue tv)
        {
            this.DataType = (MFDataType)tv.DataType;
            this.DisplayValue = tv.DisplayValue;
            this.Value = tv.Value;
        }

        public TypedValue Clone()
        {
            TestTypedValue tv = new TestTypedValue
            {
                DataType = this.DataType,
                DisplayValue = this.DisplayValue,
                Value = this.Value
            };
            return tv;
        }

        public int CompareTo(TypedValue TypedValue)
        {
            throw new NotImplementedException();
        }

        public MFDataType DataType { get; set; }

        public string DisplayValue { get; set; }

        public int GetLookupID()
        {
            throw new NotImplementedException();
        }

        public string GetValueAsLocalizedText()
        {
            throw new NotImplementedException();
        }

        public Lookup GetValueAsLookup()
        {
            throw new NotImplementedException();
        }

        public Lookups GetValueAsLookups()
        {
            throw new NotImplementedException();
        }

        public string GetValueAsText(bool Localized, bool NULLAsEmptyString, bool EmptyLookupDisplayValuesAsHidden, bool LongDateFormat, bool NoSeconds, bool NumericValueAsKilobytes)
        {
            throw new NotImplementedException();
        }

        public string GetValueAsTextWithExpression(Expression Expression, uint Locale = 0)
        {
            throw new NotImplementedException();
        }

        public Timestamp GetValueAsTimestamp()
        {
            throw new NotImplementedException();
        }

        public string GetValueAsUnlocalizedText()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public bool IsNULL()
        {
            return this.Value == null;
        }

        public bool IsUninitialized()
        {
            throw new NotImplementedException();
        }

        public byte[] Serialize()
        {
            throw new NotImplementedException();
        }

        public void SetValue(MFDataType DataType, object Value)
        {
            if(DataType == MFDataType.MFDatatypeText)
            {
                this.Value = Value;
                return;
            }
            else if(DataType == MFDataType.MFDatatypeBoolean)
            {
                this.Value = Value;
                return;
            }
            throw new NotImplementedException();
        }

        public void SetValueToLookup(Lookup Lookup)
        {
            throw new NotImplementedException();
        }

        public void SetValueToMultiSelectLookup(Lookups MultiSelectLookup)
        {
            throw new NotImplementedException();
        }

        public void SetValueToNULL(MFDataType DataType)
        {
            throw new NotImplementedException();
        }

        public void Unserialize(byte[] Bytes, bool ReadFromOldSerializingFormat)
        {
            throw new NotImplementedException();
        }

        public dynamic Value { get; set; }
    }
}
