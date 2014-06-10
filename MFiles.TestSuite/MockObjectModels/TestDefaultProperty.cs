using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using MFiles.TestSuite.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestDefaultProperty : DefaultProperty
    {
        public TestDefaultProperty() { }

        public TestDefaultProperty(xDefaultProperty dp)
        {
            try
            {
                this.DataFixedValueValue = new TestTypedValue(dp.DataFixedValueValue);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataFromEmailAddVLItemIfNotFound = dp.DataFromEmailAddVLItemIfNotFound;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataFromEmailField = (MFEmailField)dp.DataFromEmailField;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataFromEmailHeaderAddVLItemIfNotFound = dp.DataFromEmailHeaderAddVLItemIfNotFound;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataFromEmailHeaderField = dp.DataFromEmailHeaderField;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataFromEmailHeaderTreatLookupAsID = dp.DataFromEmailHeaderTreatLookupAsID;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataFromEmailTreatLookupAsID = dp.DataFromEmailTreatLookupAsID;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataFromHPDSSXMLAddVLItemIfNotFound = dp.DataFromHPDSSXMLAddVLItemIfNotFound;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataFromHPDSSXMLPromptName = dp.DataFromHPDSSXMLPromptName;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataFromHPDSSXMLTreatLookupAsID = dp.DataFromHPDSSXMLTreatLookupAsID;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataFromOCRAddVLItemIfNotFound = dp.DataFromOCRAddVLItemIfNotFound;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataFromOCRTreatLookupAsID = dp.DataFromOCRTreatLookupAsID;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataFromOCRZone = new TestOCRZone(dp.DataFromOCRZone);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataFromXMLAddVLItemIfNotFound = dp.DataFromXMLAddVLItemIfNotFound;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataFromXMLTreatLookupAsID = dp.DataFromXMLTreatLookupAsID;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataFromXMLXPathExpression = dp.DataFromXMLXPathExpression;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.PropertyDefID = dp.PropertyDefID;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.Type = (MFDefaultPropertyType)dp.Type;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public DefaultProperty Clone()
        {
            TestDefaultProperty dp = new TestDefaultProperty();
            try
            {
                dp.DataFixedValueValue = this.DataFixedValueValue.Clone();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                dp.DataFromEmailAddVLItemIfNotFound = this.DataFromEmailAddVLItemIfNotFound;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                dp.DataFromEmailField = (MFEmailField)this.DataFromEmailField;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                dp.DataFromEmailHeaderAddVLItemIfNotFound = this.DataFromEmailHeaderAddVLItemIfNotFound;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                dp.DataFromEmailHeaderField = this.DataFromEmailHeaderField;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                dp.DataFromEmailHeaderTreatLookupAsID = this.DataFromEmailHeaderTreatLookupAsID;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                dp.DataFromEmailTreatLookupAsID = this.DataFromEmailTreatLookupAsID;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                dp.DataFromHPDSSXMLAddVLItemIfNotFound = this.DataFromHPDSSXMLAddVLItemIfNotFound;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                dp.DataFromHPDSSXMLPromptName = this.DataFromHPDSSXMLPromptName;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                dp.DataFromHPDSSXMLTreatLookupAsID = this.DataFromHPDSSXMLTreatLookupAsID;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                dp.DataFromOCRAddVLItemIfNotFound = this.DataFromOCRAddVLItemIfNotFound;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                dp.DataFromOCRTreatLookupAsID = this.DataFromOCRTreatLookupAsID;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                dp.DataFromOCRZone = this.DataFromOCRZone.Clone();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                dp.DataFromXMLAddVLItemIfNotFound = this.DataFromXMLAddVLItemIfNotFound;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                dp.DataFromXMLTreatLookupAsID = this.DataFromXMLTreatLookupAsID;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                dp.DataFromXMLXPathExpression = this.DataFromXMLXPathExpression;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                dp.PropertyDefID = this.PropertyDefID;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                dp.Type = this.Type;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return dp;
        }

        public TypedValue DataFixedValueValue { get; set; }

        public bool DataFromEmailAddVLItemIfNotFound { get; set; }

        public MFEmailField DataFromEmailField { get; set; }

        public bool DataFromEmailHeaderAddVLItemIfNotFound { get; set; }

        public string DataFromEmailHeaderField { get; set; }

        public bool DataFromEmailHeaderTreatLookupAsID { get; set; }

        public bool DataFromEmailTreatLookupAsID { get; set; }

        public bool DataFromHPDSSXMLAddVLItemIfNotFound { get; set; }

        public string DataFromHPDSSXMLPromptName { get; set; }

        public bool DataFromHPDSSXMLTreatLookupAsID { get; set; }

        public bool DataFromOCRAddVLItemIfNotFound { get; set; }

        public bool DataFromOCRTreatLookupAsID { get; set; }

        public OCRZone DataFromOCRZone { get; set; }

        public bool DataFromXMLAddVLItemIfNotFound { get; set; }

        public bool DataFromXMLTreatLookupAsID { get; set; }

        public string DataFromXMLXPathExpression { get; set; }

        public int PropertyDefID { get; set; }

        public void SetFixedValue(TypedValue TypedValue)
        {
            throw new NotImplementedException();
        }

        public void SetFromEmail(MFEmailField EmailField, bool TreatLookupAsID, bool AddVLItemIfNotFound)
        {
            throw new NotImplementedException();
        }

        public void SetFromEmailHeader(string Field, bool TreatLookupAsID, bool AddVLItemIfNotFound)
        {
            throw new NotImplementedException();
        }

        public void SetFromHPDSSXML(string PromptName, bool TreatLookupAsID, bool AddVLItemIfNotFound)
        {
            throw new NotImplementedException();
        }

        public void SetFromOCR(OCRZone OCRZone, bool TreatLookupAsID, bool AddVLItemIfNotFound)
        {
            throw new NotImplementedException();
        }

        public void SetFromXML(string XPathExpression, bool TreatLookupAsID, bool AddVLItemIfNotFound)
        {
            throw new NotImplementedException();
        }

        public MFDefaultPropertyType Type { get; set; }
    }
}
