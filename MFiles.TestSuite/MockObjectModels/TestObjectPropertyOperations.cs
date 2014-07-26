using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestObjectPropertyOperations : VaultObjectPropertyOperations
    {
        private TestVault vault;

        public TestObjectPropertyOperations(TestVault vault)
        {
            this.vault = vault;
        }

        public AccessControlList GenerateAutomaticPermissionsFromPropertyValues(PropertyValues PropertyValues)
        {
            throw new NotImplementedException();
        }

        public WorkflowAssignment GetAssignment_DEPRECATED(ObjVer ObjVer, bool UpdateFromServer = false)
        {
            throw new NotImplementedException();
        }

        public PropertyValues GetProperties(ObjVer ObjVer, bool UpdateFromServer = false)
        {
            // TODO: handle args
            List<TestObjectVersionAndProperties> thisObj =
                this.vault.ovaps.Where(ovap => ovap.ObjVer.ID == ObjVer.ID && ovap.ObjVer.Type == ObjVer.Type).ToList();
            if (thisObj.Count == 0)
                return null;
            int lookupVersion = (ObjVer.Version == -1) ? thisObj.Max(obj => obj.ObjVer.Version) : ObjVer.Version;

            return thisObj.Single(obj => obj.ObjVer.Version == lookupVersion).Properties.Clone();
        }

        public string GetPropertiesAsXML(ObjVer ObjVer, bool UpdateFromServer = false)
        {
            throw new NotImplementedException();
        }

        public PropertyValuesForDisplay GetPropertiesForDisplay(ObjVer ObjVer, bool UpdateFromServer = false)
        {
            throw new NotImplementedException();
        }

        public NamedValues GetPropertiesForMetadataSync(ObjVer ObjVer, MFMetadataSyncFormat Format)
        {
            throw new NotImplementedException();
        }

        public PropertyValuesOfMultipleObjects GetPropertiesOfMultipleObjects(ObjVers ObjectVersions)
        {
            throw new NotImplementedException();
        }

        public PropertyValuesWithIconClues GetPropertiesWithIconClues(ObjVer ObjVer, bool UpdateFromServer = false)
        {
            throw new NotImplementedException();
        }

        public PropertyValuesWithIconCluesOfMultipleObjects GetPropertiesWithIconCluesOfMultipleObjects(ObjVers ObjectVersions)
        {
            throw new NotImplementedException();
        }

        public PropertyValue GetProperty(ObjVer ObjVer, int Property)
        {
            throw new NotImplementedException();
        }

        public VersionComment GetVersionComment(ObjVer ObjVer)
        {
            throw new NotImplementedException();
        }

        public VersionComments GetVersionCommentHistory(ObjVer ObjVer)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionWorkflowState GetWorkflowState(ObjVer ObjVer, bool UpdateFromServer = false)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties MarkAssignmentComplete(ObjVer ObjVer)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties RemoveProperty(ObjVer ObjVer, int Property)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetAllProperties(
            ObjVer ObjVer,
            bool AllowModifyingCheckedInObject,
            PropertyValues PropertyValues)
        {
            // TODO: use arguments
            // TODO: error checking
            foreach (PropertyValue propertyValue in PropertyValues)
            {
                if(vault.propertyDefs.SingleOrDefault(prop => prop.PropertyDef.ID == propertyValue.PropertyDef) == null)
                    throw new Exception(string.Format("Property does not exist. ({0})", propertyValue.PropertyDef));
            }

			List<TestObjectVersionAndProperties> thisObj =
                this.vault.ovaps.Where(obj => obj.ObjVer.ID == ObjVer.ID && obj.ObjVer.Type == ObjVer.Type).ToList();
            if(thisObj.Count == 0)
                throw new Exception("Object not found");
            int maxVersion = thisObj.Max(obj => obj.ObjVer.Version);
            
            if(ObjVer.Version != -1 && ObjVer.Version != maxVersion)
                throw new Exception("Invalid version");
            TestObjectVersionAndProperties current =
                (TestObjectVersionAndProperties) thisObj.Single(obj => obj.ObjVer.Version == maxVersion);//.Clone();
            
            //current.ObjVer.Version += 1;
            current.Properties = PropertyValues.Clone();
          //  this.vault.ovaps.Add(current);
            return current;
        }

        public ObjectVersionAndProperties SetAllPropertiesWithPermissions(ObjVer ObjVer, bool AllowModifyingCheckedInObject, PropertyValues PropertyValues, MFACLEnforcingMode ACLEnforcingMode = MFACLEnforcingMode.MFACLEnforcingModeAutomatic, AccessControlList ACLProvided = null)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetAllPropertiesWithPermissionsEx(ObjVer ObjVer, bool AllowModifyingCheckedInObject, PropertyValues PropertyValues, MFACLEnforcingMode ACLEnforcingMode, AccessControlList ACLProvided, [System.Runtime.InteropServices.OptionalAttribute][System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.IDispatch)][System.Runtime.CompilerServices.IDispatchConstantAttribute]object ElectronicSignature)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetAllPropertiesWithPermissionsEx(ObjVer ObjVer, bool AllowModifyingCheckedInObject, PropertyValues PropertyValues, MFACLEnforcingMode ACLEnforcingMode = MFACLEnforcingMode.MFACLEnforcingModeAutomatic, AccessControlList ACLProvided = null)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetAssignment_DEPRECATED(ObjVer ObjVer, WorkflowAssignment Assignment)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetCreationInfoAdmin(ObjVer ObjVer, bool UpdateCreatedBy, TypedValue CreatedBy, bool UpdateCreated, TypedValue CreatedUtc)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetLastModificationInfoAdmin(ObjVer ObjVer, bool UpdateLastModifiedBy, TypedValue LastModifiedBy, bool UpdateLastModified, TypedValue LastModifiedUtc)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetProperties(ObjVer objVer, PropertyValues PropertyValues)
        {
			// TODO: use arguments
			// TODO: error checking
			// TODO: use SetAllProperties?
			foreach( PropertyValue propertyValue in PropertyValues )
			{
				if( vault.propertyDefs.SingleOrDefault( prop => prop.PropertyDef.ID == propertyValue.PropertyDef ) == null )
					throw new Exception( string.Format( "Property does not exist. ({0})", propertyValue.PropertyDef ) );
			}

			List<TestObjectVersionAndProperties> thisObj =
				this.vault.ovaps.Where( obj => obj.ObjVer.ID == objVer.ID && obj.ObjVer.Type == objVer.Type ).ToList();
			if( thisObj.Count == 0 )
				throw new Exception( "Object not found" );
			int maxVersion = thisObj.Max( obj => obj.ObjVer.Version );

			if(objVer.Version != -1 && objVer.Version != maxVersion)
				throw new Exception("Invalid version.");

			TestObjectVersionAndProperties current =
				( TestObjectVersionAndProperties )thisObj.Single( obj => obj.ObjVer.Version == maxVersion );//.Clone();
			if( !current.VersionData.ObjectCheckedOut )
			{
				current = ( TestObjectVersionAndProperties )current.Clone();
				current.ObjVer.Version += 1;
				vault.ovaps.Add( current );
			}

			foreach( PropertyValue propertyValue in PropertyValues )
			{
				int index = current.properties.IndexOf( propertyValue.PropertyDef );
				if(index == -1)
				{
					current.properties.Add( -1, propertyValue );
				}
				else
				{
					current.properties[ index ] = propertyValue;
				}
	        }
			
			return current;
        }

        public ObjectVersionAndPropertiesOfMultipleObjects SetPropertiesOfMultipleObjects(SetPropertiesParamsOfMultipleObjects SetPropertiesParamsOfObjects)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetPropertiesWithPermissions(ObjVer ObjVer, PropertyValues PropertyValues, MFACLEnforcingMode ACLEnforcingMode = MFACLEnforcingMode.MFACLEnforcingModeAutomatic, AccessControlList ACLProvided = null)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetPropertiesWithPermissionsEx(ObjVer ObjVer, PropertyValues PropertyValues, MFACLEnforcingMode ACLEnforcingMode, AccessControlList ACLProvided, [System.Runtime.InteropServices.OptionalAttribute][System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.IDispatch)][System.Runtime.CompilerServices.IDispatchConstantAttribute]object ElectronicSignature)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetPropertiesWithPermissionsEx(ObjVer ObjVer, PropertyValues PropertyValues, MFACLEnforcingMode ACLEnforcingMode = MFACLEnforcingMode.MFACLEnforcingModeAutomatic, AccessControlList ACLProvided = null)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetProperty(ObjVer ObjVer, PropertyValue PropertyValue)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetVersionComment(ObjVer ObjVer, PropertyValue VersionComment)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetWorkflowState(ObjVer ObjVer, ObjectVersionWorkflowState WorkflowState)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties SetWorkflowStateEx(ObjVer ObjVer, ObjectVersionWorkflowState WorkflowState, [System.Runtime.InteropServices.OptionalAttribute][System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.IDispatch)][System.Runtime.CompilerServices.IDispatchConstantAttribute]object ElectronicSignature)
        {
            throw new NotImplementedException();
        }
    }
}
