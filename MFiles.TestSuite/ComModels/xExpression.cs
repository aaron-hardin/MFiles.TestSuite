using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.ComModels
{
    public class xExpression
    {
        public object DataAnyFieldFTSFlags { get; set; }
        public int DataFileValueType { get; set; }
        public int DataObjectIDSegmentSegmentSize { get; set; }
        public int DataPermissionsType { get; set; }
        public int DataPropertyValueDataFunction { get; set; }
        public int DataPropertyValueParentChildBehaviour { get; set; }
        public int DataPropertyValuePropertyDef { get; set; }
        public int DataStatusValueDataFunction { get; set; }
        public int DataStatusValueType { get; set; }
        public int DataTypedValueDataFunction { get; set; }
        public int DataTypedValueDatatype { get; set; }
        public int DataTypedValueParentChildBehaviour { get; set; }
        public int DataTypedValueValueList { get; set; }
        public xPropertyDefOrObjectType[] IndirectionLevels { get; set; }
        public int Type { get; set; }

        public xExpression(Expression exp)
        {
            try
            {
                this.DataAnyFieldFTSFlags = exp.DataAnyFieldFTSFlags;
            }
            catch (Exception ex)
            {                
                Debug.WriteLine(ex.Message);
            }

            try
            {
                this.DataFileValueType = (int) exp.DataFileValueType;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataObjectIDSegmentSegmentSize = exp.DataObjectIDSegmentSegmentSize;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataPermissionsType = (int)exp.DataPermissionsType;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataPropertyValueDataFunction = (int) exp.DataPropertyValueDataFunction;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataPropertyValueParentChildBehaviour = (int) exp.DataPropertyValueParentChildBehaviour;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataPropertyValuePropertyDef = exp.DataPropertyValuePropertyDef;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataStatusValueDataFunction = (int) exp.DataStatusValueDataFunction;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataStatusValueType = (int) exp.DataStatusValueType;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataTypedValueDataFunction = (int) exp.DataTypedValueDataFunction;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataTypedValueDatatype = (int) exp.DataTypedValueDatatype;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataTypedValueParentChildBehaviour = (int) exp.DataTypedValueParentChildBehaviour;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataTypedValueValueList = exp.DataTypedValueValueList;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.IndirectionLevels = (from PropertyDefOrObjectType pdot in exp.IndirectionLevels select new xPropertyDefOrObjectType(pdot)).ToArray();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.Type = (int) exp.Type;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
        
    }
}
