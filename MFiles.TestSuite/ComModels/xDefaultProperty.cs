using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace VaultMockObjects.ComModels
{
    public class xDefaultProperty
    {
        public xTypedValue DataFixedValueValue { get; set; }
        public bool DataFromEmailAddVLItemIfNotFound { get; set; }
        public int DataFromEmailField { get; set; }
        public bool DataFromEmailHeaderAddVLItemIfNotFound { get; set; }
        public string DataFromEmailHeaderField { get; set; }
        public bool DataFromEmailHeaderTreatLookupAsID { get; set; }
        public bool DataFromEmailTreatLookupAsID { get; set; }
        public bool DataFromHPDSSXMLAddVLItemIfNotFound { get; set; }
        public string DataFromHPDSSXMLPromptName { get; set; }
        public bool DataFromHPDSSXMLTreatLookupAsID { get; set; }
        public bool DataFromOCRAddVLItemIfNotFound { get; set; }
        public bool DataFromOCRTreatLookupAsID { get; set; }
        public xOCRZone DataFromOCRZone { get; set; }
        public bool DataFromXMLAddVLItemIfNotFound { get; set; }
        public bool DataFromXMLTreatLookupAsID { get; set; }
        public string DataFromXMLXPathExpression { get; set; }
        public int PropertyDefID { get; set; }
        public int Type { get; set; }

        public xDefaultProperty(DefaultProperty dp)
        {
            try
            {
                this.DataFixedValueValue = new xTypedValue(dp.DataFixedValueValue);
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
                this.DataFromEmailField = (int) dp.DataFromEmailField;
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
                this.DataFromOCRZone = new xOCRZone(dp.DataFromOCRZone);
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
                this.Type = (int) dp.Type;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
    }
}
