using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;
using VaultMockObjects.ComModels;

namespace VaultMockObjects.MockObjectModels
{
    public class TestExpression : Expression
    {
        public TestExpression() { }

        public TestExpression(xExpression exp)
        {
            if (exp.DataAnyFieldFTSFlags != null)
                this.DataAnyFieldFTSFlags = (MFFullTextSearchFlags)exp.DataAnyFieldFTSFlags;
            if(exp.DataFileValueType != null)
                this.DataFileValueType = (MFFileValueType)exp.DataFileValueType;
            
            if(exp.DataObjectIDSegmentSegmentSize != null)
                this.DataObjectIDSegmentSegmentSize = exp.DataObjectIDSegmentSegmentSize;
            if(exp.DataPermissionsType != null)
                this.DataPermissionsType = (MFPermissionsExpressionType)exp.DataPermissionsType;
            if(exp.DataPropertyValueDataFunction != null)
                this.DataPropertyValueDataFunction = (MFDataFunction)exp.DataPropertyValueDataFunction;
            if(exp.DataPropertyValueParentChildBehaviour != null)
                this.DataPropertyValueParentChildBehaviour = (MFParentChildBehavior)exp.DataPropertyValueParentChildBehaviour;
            if(exp.DataPropertyValuePropertyDef != null)
                this.DataPropertyValuePropertyDef = exp.DataPropertyValuePropertyDef;
            if(exp.DataStatusValueDataFunction != null)
                this.DataStatusValueDataFunction = (MFDataFunction)exp.DataStatusValueDataFunction;
            if(exp.DataStatusValueType != null)
                this.DataStatusValueType = (MFStatusType)exp.DataStatusValueType;
            try
            {
                this.DataTypedValueDataFunction = (MFDataFunction)exp.DataTypedValueDataFunction;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataTypedValueDatatype = (MFDataType)exp.DataTypedValueDatatype;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.DataTypedValueParentChildBehaviour = (MFParentChildBehavior)exp.DataTypedValueParentChildBehaviour;
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
                this.IndirectionLevels = new PropertyDefOrObjectTypes();
                foreach (xPropertyDefOrObjectType pdot in exp.IndirectionLevels)
                {
                    TestPropertyDefOrObjectType tpdot = new TestPropertyDefOrObjectType(pdot);
                    this.IndirectionLevels.Add(-1, tpdot);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                this.Type = (MFExpressionType)exp.Type;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public Expression Clone()
        {
            TestExpression expression = new TestExpression();
            if (this.DataAnyFieldFTSFlags != null)
                expression.DataAnyFieldFTSFlags = this.DataAnyFieldFTSFlags;
            if (this.DataFileValueType != null)
                expression.DataFileValueType = this.DataFileValueType;

            if (this.DataObjectIDSegmentSegmentSize != null)
                expression.DataObjectIDSegmentSegmentSize = this.DataObjectIDSegmentSegmentSize;
            if (this.DataPermissionsType != null)
                expression.DataPermissionsType = this.DataPermissionsType;
            if (this.DataPropertyValueDataFunction != null)
                expression.DataPropertyValueDataFunction = this.DataPropertyValueDataFunction;
            if (this.DataPropertyValueParentChildBehaviour != null)
                expression.DataPropertyValueParentChildBehaviour = this.DataPropertyValueParentChildBehaviour;
            if (this.DataPropertyValuePropertyDef != null)
                expression.DataPropertyValuePropertyDef = this.DataPropertyValuePropertyDef;
            if (this.DataStatusValueDataFunction != null)
                expression.DataStatusValueDataFunction = this.DataStatusValueDataFunction;
            if (this.DataStatusValueType != null)
                expression.DataStatusValueType = this.DataStatusValueType;
            try
            {
                expression.DataTypedValueDataFunction = this.DataTypedValueDataFunction;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                expression.DataTypedValueDatatype = this.DataTypedValueDatatype;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                expression.DataTypedValueParentChildBehaviour = this.DataTypedValueParentChildBehaviour;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                expression.DataTypedValueValueList = this.DataTypedValueValueList;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                expression.IndirectionLevels = new PropertyDefOrObjectTypes();
                foreach (PropertyDefOrObjectType pdot in this.IndirectionLevels)
                {
                    expression.IndirectionLevels.Add(-1, pdot.Clone());
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            try
            {
                expression.Type = this.Type;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return expression;
        }

        public MFFullTextSearchFlags DataAnyFieldFTSFlags { get; set; }

        public MFFileValueType DataFileValueType { get; set; }

        public int DataObjectIDSegmentSegmentSize { get; set; }

        public MFPermissionsExpressionType DataPermissionsType { get; set; }

        public MFDataFunction DataPropertyValueDataFunction { get; set; }

        public MFParentChildBehavior DataPropertyValueParentChildBehaviour { get; set; }

        public int DataPropertyValuePropertyDef { get; set; }

        public MFDataFunction DataStatusValueDataFunction { get; set; }

        public MFStatusType DataStatusValueType { get; set; }

        public MFDataFunction DataTypedValueDataFunction { get; set; }

        public MFDataType DataTypedValueDatatype { get; set; }

        public MFParentChildBehavior DataTypedValueParentChildBehaviour { get; set; }

        public int DataTypedValueValueList { get; set; }

        public string GetExpressionAsText(PropertyDefs PropertyDefinitions, ObjTypes ObjectTypes)
        {
            throw new NotImplementedException();
        }

        public PropertyDefOrObjectTypes GetWholeExpressionAsIndirectionLevels()
        {
            throw new NotImplementedException();
        }

        public PropertyDefOrObjectTypes IndirectionLevels { get; set; }

        public void SetAnyFieldExpression(MFFullTextSearchFlags FullTextSearchFlags)
        {
            throw new NotImplementedException();
        }

        public void SetFileValueExpression(MFFileValueType FileValueType)
        {
            throw new NotImplementedException();
        }

        public void SetObjectIDSegmentExpression(int Segment)
        {
            throw new NotImplementedException();
        }

        public void SetPermissionExpression(MFPermissionsExpressionType PermissionsExpressionType)
        {
            throw new NotImplementedException();
        }

        public void SetPropertyValueExpression(int PropertyDef, MFParentChildBehavior PCBehaviour, DataFunctionCall DataFunctionCall = null)
        {
            throw new NotImplementedException();
        }

        public void SetStatusValueExpression(MFStatusType StatusType, DataFunctionCall DataFunctionCall = null)
        {
            throw new NotImplementedException();
        }

        public void SetTypedValueExpression(MFDataType DataType, int ValueList, MFParentChildBehavior PCBehaviour, DataFunctionCall DataFunctionCall = null)
        {
            throw new NotImplementedException();
        }

        public void SetValueListItemExpression(MFValueListItemPropertyDef PseudoPropertyDef, MFParentChildBehavior PCBehaviour, DataFunctionCall DataFunctionCall = null)
        {
            throw new NotImplementedException();
        }

        public MFExpressionType Type { get; set; }
    }
}
