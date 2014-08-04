using System;
using System.Collections.Generic;
using System.Linq;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
	public class TestObjectPropertyOperations : VaultObjectPropertyOperations
	{
		private readonly TestVault vault;

		public TestObjectPropertyOperations( TestVault vault )
		{
			vault.MetricGatherer.MethodCalled();

			this.vault = vault;
		}

		public AccessControlList GenerateAutomaticPermissionsFromPropertyValues( PropertyValues propertyValues )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public WorkflowAssignment GetAssignment_DEPRECATED( ObjVer objVer, bool updateFromServer = false )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public PropertyValues GetProperties( ObjVer objVer, bool updateFromServer = false )
		{
			vault.MetricGatherer.MethodCalled();

			// TODO: handle args
			List<TestObjectVersionAndProperties> thisObj =
				vault.ovaps.Where( ovap => ovap.ObjVer.ID == objVer.ID && ovap.ObjVer.Type == objVer.Type ).ToList();
			if( thisObj.Count == 0 )
				return null;
			int lookupVersion = ( objVer.Version == -1 ) ? thisObj.Max( obj => obj.ObjVer.Version ) : objVer.Version;

			return thisObj.Single( obj => obj.ObjVer.Version == lookupVersion ).Properties.Clone();
		}

		public string GetPropertiesAsXML( ObjVer objVer, bool updateFromServer = false )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public PropertyValuesForDisplay GetPropertiesForDisplay( ObjVer objVer, bool updateFromServer = false )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public NamedValues GetPropertiesForMetadataSync( ObjVer objVer, MFMetadataSyncFormat format )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public PropertyValuesOfMultipleObjects GetPropertiesOfMultipleObjects( ObjVers objectVersions )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public PropertyValuesWithIconClues GetPropertiesWithIconClues( ObjVer objVer, bool updateFromServer = false )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public PropertyValuesWithIconCluesOfMultipleObjects GetPropertiesWithIconCluesOfMultipleObjects( ObjVers objectVersions )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public PropertyValue GetProperty( ObjVer objVer, int property )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public VersionComment GetVersionComment( ObjVer objVer )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public VersionComments GetVersionCommentHistory( ObjVer objVer )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionWorkflowState GetWorkflowState( ObjVer objVer, bool updateFromServer = false )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties MarkAssignmentComplete( ObjVer objVer )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties RemoveProperty( ObjVer objVer, int property )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties SetAllProperties( ObjVer objVer, bool allowModifyingCheckedInObject, PropertyValues propertyValues )
		{
			vault.MetricGatherer.MethodCalled();

			// TODO: error checking
			foreach( PropertyValue propertyValue in propertyValues )
			{
				if( vault.propertyDefs.SingleOrDefault( prop => prop.PropertyDef.ID == propertyValue.PropertyDef ) == null )
					throw new Exception( string.Format( "Property does not exist. ({0})", propertyValue.PropertyDef ) );
			}

			List<TestObjectVersionAndProperties> thisObj =
				vault.ovaps.Where( obj => obj.ObjVer.ID == objVer.ID && obj.ObjVer.Type == objVer.Type ).ToList();
			if( thisObj.Count == 0 )
				throw new Exception( "Object not found" );
			int maxVersion = thisObj.Max( obj => obj.ObjVer.Version );

			if( objVer.Version != -1 && objVer.Version != maxVersion )
				throw new Exception( "Invalid version" );
			TestObjectVersionAndProperties current = thisObj.Single( obj => obj.ObjVer.Version == maxVersion );

			if( !current.VersionData.ObjectCheckedOut )
			{
				if( !allowModifyingCheckedInObject )
				{
					throw new Exception( "Modifying Checked In Object not allowed." );
				}
				current = ( TestObjectVersionAndProperties )current.Clone();
				current.ObjVer.Version += 1;
				vault.ovaps.Add( current );
			}
			current.Properties = propertyValues.Clone();

			return current;
		}

		public ObjectVersionAndProperties SetAllPropertiesWithPermissions( ObjVer objVer, bool allowModifyingCheckedInObject, PropertyValues propertyValues, MFACLEnforcingMode aclEnforcingMode = MFACLEnforcingMode.MFACLEnforcingModeAutomatic, AccessControlList aclProvided = null )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties SetAllPropertiesWithPermissionsEx( ObjVer objVer, bool allowModifyingCheckedInObject, PropertyValues propertyValues, MFACLEnforcingMode aclEnforcingMode = MFACLEnforcingMode.MFACLEnforcingModeAutomatic, AccessControlList aclProvided = null, object electronicSignature = null )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties SetAssignment_DEPRECATED( ObjVer objVer, WorkflowAssignment assignment )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties SetCreationInfoAdmin( ObjVer objVer, bool updateCreatedBy, TypedValue createdBy, bool updateCreated, TypedValue createdUtc )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties SetLastModificationInfoAdmin( ObjVer objVer, bool updateLastModifiedBy, TypedValue lastModifiedBy, bool updateLastModified, TypedValue lastModifiedUtc )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties SetProperties( ObjVer objVer, PropertyValues propertyValues )
		{
			vault.MetricGatherer.MethodCalled();

			// TODO: use arguments
			// TODO: error checking
			// TODO: use SetAllProperties?
			foreach( PropertyValue propertyValue in propertyValues )
			{
				if( vault.propertyDefs.SingleOrDefault( prop => prop.PropertyDef.ID == propertyValue.PropertyDef ) == null )
					throw new Exception( string.Format( "Property does not exist. ({0})", propertyValue.PropertyDef ) );
			}

			List<TestObjectVersionAndProperties> thisObj =
				vault.ovaps.Where( obj => obj.ObjVer.ID == objVer.ID && obj.ObjVer.Type == objVer.Type ).ToList();
			if( thisObj.Count == 0 )
				throw new Exception( "Object not found" );
			int maxVersion = thisObj.Max( obj => obj.ObjVer.Version );

			if( objVer.Version != -1 && objVer.Version != maxVersion )
				throw new Exception( "Invalid version." );

			TestObjectVersionAndProperties current = thisObj.Single( obj => obj.ObjVer.Version == maxVersion );
			if( !current.VersionData.ObjectCheckedOut )
			{
				current = ( TestObjectVersionAndProperties )current.Clone();
				current.ObjVer.Version += 1;
				vault.ovaps.Add( current );
			}

			foreach( PropertyValue propertyValue in propertyValues )
			{
				int index = current.properties.IndexOf( propertyValue.PropertyDef );
				if( index == -1 )
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

		public ObjectVersionAndPropertiesOfMultipleObjects SetPropertiesOfMultipleObjects( SetPropertiesParamsOfMultipleObjects setPropertiesParamsOfObjects )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties SetPropertiesWithPermissions( ObjVer objVer, PropertyValues propertyValues, MFACLEnforcingMode aclEnforcingMode = MFACLEnforcingMode.MFACLEnforcingModeAutomatic, AccessControlList aclProvided = null )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties SetPropertiesWithPermissionsEx( ObjVer objVer, PropertyValues propertyValues, MFACLEnforcingMode aclEnforcingMode = MFACLEnforcingMode.MFACLEnforcingModeAutomatic, AccessControlList aclProvided = null, object electronicSignature = null )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties SetProperty( ObjVer objVer, PropertyValue propertyValue )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties SetVersionComment( ObjVer objVer, PropertyValue versionComment )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties SetWorkflowState( ObjVer objVer, ObjectVersionWorkflowState workflowState )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties SetWorkflowStateEx( ObjVer objVer, ObjectVersionWorkflowState workflowState, [System.Runtime.InteropServices.OptionalAttribute][System.Runtime.InteropServices.MarshalAsAttribute( System.Runtime.InteropServices.UnmanagedType.IDispatch )][System.Runtime.CompilerServices.IDispatchConstantAttribute]object electronicSignature )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}
	}
}
