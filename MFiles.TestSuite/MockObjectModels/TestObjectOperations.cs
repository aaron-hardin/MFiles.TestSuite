using System;
using System.Collections.Generic;
using System.Linq;
using MFilesAPI;
using VaultMockObjects.VaultExtensions;

namespace MFiles.TestSuite.MockObjectModels
{
	public class TestObjectOperations : VaultObjectOperations
	{
		private readonly TestVault vault;

		public TestObjectOperations( TestVault vault )
		{
			vault.MetricGatherer.MethodCalled();

			this.vault = vault;
		}

		public ObjectVersionAndProperties AddFavorite( ObjID objID )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndPropertiesOfMultipleObjects AddFavorites( ObjIDs objIDs )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersion ChangePermissionsToACL( ObjVer objVer, AccessControlList accessControlList, bool changeAllVersions )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersion ChangePermissionsToNamedACL( ObjVer objVer, int namedAcl, bool changeAllVersions )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersion CheckIn( ObjVer objVer )
		{
			vault.MetricGatherer.MethodCalled();

			// TODO: implement
			//throw new NotImplementedException();
			TestObjectVersionAndProperties ovap = GetLatestTestObjectVersionAndProperties( objVer.ObjID, false );
			ovap.versionData.checkedOut = false;
			return ovap.VersionData;
		}

		public ObjectVersions CheckInMultipleObjects( ObjVers objVers )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersion CheckOut( ObjID objID )
		{
			vault.MetricGatherer.MethodCalled();

			// TODO: finish method
			TestObjectVersionAndProperties ovap = GetLatestTestObjectVersionAndProperties( objID, false );

			if (ovap.versionData.checkedOut)
				throw new Exception(string.Format("Object checked out: ({0}-{1}-{2})", ovap.ObjVer.Type, ovap.ObjVer.ID, ovap.ObjVer.Version));
			
			TestObjectVersionAndProperties newVersion = ovap.CloneCheckedOut();
			newVersion.VersionData.ObjVer.Version++;
			vault.CheckedOut.Add( newVersion.ObjVer.ObjID );
			vault.ovaps.Add( newVersion );
			return newVersion.VersionData;
		}

		public ObjectVersions CheckOutMultipleObjects( ObjIDs objIDs )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties CreateNewAssignment( string assignmentName, string assignmentDescription, TypedValue assignedToUser, TypedValue deadline = null, AccessControlList accessControlList = null )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties CreateNewEmptySingleFileDocument( PropertyValues propertyValues, string title, string extension, AccessControlList accessControlList = null )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties CreateNewObject( int objectType, PropertyValues propertyValues,
			SourceObjectFiles sourceObjectFiles = null, AccessControlList accessControlList = null )
		{
			vault.MetricGatherer.MethodCalled();

			// TODO: use parameter args
			TestObjectVersionAndProperties ovap = CreateNewTestObject( objectType, propertyValues );
			return ovap;
		}

		private TestObjectVersionAndProperties CreateNewTestObject( int objectType, PropertyValues propertyValues )
		{
			int maxId = 0;
			List<TestObjectVersionAndProperties> objThisType = vault.ovaps.Where( obj => obj.ObjVer.Type == objectType ).ToList();
			if( objThisType.Count > 0 )
				maxId = objThisType.Max( obj => obj.ObjVer.ID );
			TestObjectVersion objectVersion = new TestObjectVersion(vault)
			{
				ObjVer = new ObjVer { Type = objectType, ID = maxId + 1, Version = 1 }
			};
			TestObjectVersionAndProperties ovap = new TestObjectVersionAndProperties
			{
				Properties = propertyValues,
				Vault = vault,
				VersionData = objectVersion
			};
			vault.ovaps.Add( ovap );
			return ovap;
		}

		public ObjectVersionAndProperties CreateNewObjectEx( int objectType, PropertyValues properties, SourceObjectFiles sourceFiles,
			bool sfd, bool checkIn, AccessControlList accessControlList = null )
		{
			vault.MetricGatherer.MethodCalled();

			// TODO: use parameter args
			TestPropertyValue pv = new TestPropertyValue
			{
				PropertyDef = ( int )MFBuiltInPropertyDef.MFBuiltInPropertyDefSingleFileObject
			};
			pv.TypedValue.SetValue( MFDataType.MFDatatypeBoolean, sfd );
			properties.Add( -1, pv );
			TestObjectVersionAndProperties ovap = CreateNewTestObject( objectType, properties );
			if( !checkIn )
			{
				ovap.versionData.checkedOut = true;
			}
			return ovap;
		}

		public int CreateNewObjectExQuick( int objectType, PropertyValues properties, SourceObjectFiles sourceFiles, bool sfd, bool checkIn, AccessControlList accessControlList = null )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties CreateNewSFDObject( int objectType, PropertyValues properties, SourceObjectFile sourceFile, bool checkIn, AccessControlList accessControlList = null )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public int CreateNewSFDObjectQuick( int objectType, PropertyValues properties, SourceObjectFile sourceFile, bool checkIn, AccessControlList accessControlList = null )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void DelayedCheckIn( ObjVer objVer )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void DestroyObject( ObjID objID, bool destroyAllVersions, int objectVersion )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void DestroyObjects( ObjIDs objIDs )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersion ForceUndoCheckout( ObjVer objVer )
		{
			vault.MetricGatherer.MethodCalled();

			TestObjectVersionAndProperties ovap = GetLatestTestObjectVersionAndProperties(objVer.ObjID, true);
			if( ovap == null )
				throw new Exception( string.Format( "Object not found: ({0}-{1}-{2})", objVer.Type, objVer.ID, objVer.Version ) );
			if( !ovap.versionData.checkedOut )
				throw new Exception( string.Format( "Object not checked out: ({0}-{1}-{2})", objVer.Type, objVer.ID, objVer.Version ) );
			vault.CheckedOut.Remove(objVer.ObjID);
			vault.ovaps.Remove( ovap );

			TestObjectVersionAndProperties prev = GetLatestTestObjectVersionAndProperties(objVer.ObjID, true);
			return prev.VersionData;
		}

		public ObjectVersions GetCollectionMembers( ObjVer objVer )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersions GetHistory( ObjID objID )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjVer GetLatestObjVer( ObjID objID, bool allowCheckedOut, bool updateFromServer = false )
		{
			vault.MetricGatherer.MethodCalled();

			// TODO: handle AllowCheckedOut and UpdateFromServer
			List<TestObjectVersionAndProperties> thisObj =
				vault.ovaps.Where( obj => obj.ObjVer.ID == objID.ID && obj.ObjVer.Type == objID.Type ).ToList();
			if( thisObj.Count == 0 )
				return null;
			int maxVersion = thisObj.Max( obj => obj.ObjVer.Version );
			ObjectVersionAndProperties objectVersionAndProperties = thisObj.SingleOrDefault( obj => obj.ObjVer.Version == maxVersion );
			return objectVersionAndProperties == null ? null : objectVersionAndProperties.ObjVer;
		}

		public ObjVer GetLatestObjVerEx( ObjID objID, bool allowCheckedOut, bool updateFromServer = false, bool notifyViews = false )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties GetLatestObjectVersionAndProperties( ObjID objID, bool allowCheckedOut, bool updateFromServer = false )
		{
			vault.MetricGatherer.MethodCalled();

			// TODO: use arguments
			List<TestObjectVersionAndProperties> thisObj = vault.ovaps.Where( obj => obj.ObjVer.ID == objID.ID && obj.ObjVer.Type == objID.Type ).ToList();
			if( thisObj.Count == 0 )
				return null;
			int maxObj = thisObj.Max( obj => obj.ObjVer.Version );
			ObjectVersionAndProperties ovap = thisObj.Single( obj => obj.ObjVer.Version == maxObj );
			return ovap;
		}

		public TestObjectVersionAndProperties GetLatestTestObjectVersionAndProperties( ObjID objID, bool allowCheckedOut, bool updateFromServer = false )
		{
			vault.MetricGatherer.MethodCalled();

			// TODO: use arguments
			List<TestObjectVersionAndProperties> thisObj = vault.ovaps.Where( obj => obj.ObjVer.ID == objID.ID && obj.ObjVer.Type == objID.Type ).ToList();
			if( thisObj.Count == 0 )
				return null;
			int maxObj = thisObj.Max( obj => obj.ObjVer.Version );
			TestObjectVersionAndProperties ovap = thisObj.Single( obj => obj.ObjVer.Version == maxObj );
			return ovap;
		}

		public string GetMFilesURLForObject( ObjID objID, int targetVersion, bool specificVersion, MFilesURLType urlType = MFilesURLType.MFilesURLTypeShow )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public string GetMFilesURLForObjectOrFile( ObjID objID, int targetVersion = -1, bool specificVersion = false, int file = -1, MFilesURLType urlType = MFilesURLType.MFilesURLTypeShow )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjID GetObjIDByGUID( string objectGuid )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjID GetObjIDByOriginalObjID( string originalVaultGuid, ObjID originalObjID )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public string GetObjectGUID( ObjID objID )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersion GetObjectInfo( ObjVer objVer, bool latestVersion, bool updateFromServer = false )
		{
			vault.MetricGatherer.MethodCalled();

			// TODO: use LatestVersion and UpdateFromServer
			List<TestObjectVersionAndProperties> thisObj =
				vault.ovaps.Where( obj => obj.ObjVer.ID == objVer.ID && obj.ObjVer.Type == objVer.Type ).ToList();
			if( thisObj.Count == 0 )
				return null;
			int lookupVersion = ( objVer.Version == -1 ) ? thisObj.Max( obj => obj.ObjVer.Version ) : objVer.Version;
			ObjectVersionAndProperties objectVersionAndProperties = thisObj.SingleOrDefault( obj => obj.ObjVer.Version == lookupVersion );
			if( objectVersionAndProperties == null )
				return null;
			TestObjectVersion objectVersion = ( TestObjectVersion )objectVersionAndProperties.VersionData;
			//objectVersion.Class = objectVersionAndProperties.Properties.SearchForProperty( 100 ).Value.GetLookupID();
			objectVersion.Title = objectVersionAndProperties.Properties.SearchForProperty( 0 ).GetValueAsLocalizedText();
			return objectVersion;
		}

		public ObjectVersion GetObjectInfoEx( ObjVer objVer, bool latestVersion, bool updateFromServer = false, bool notifyViews = false )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public Strings GetObjectLocationsInView( int view, MFLatestSpecificBehavior latestSpecificBehavior, ObjVer objectVersion )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionPermissions GetObjectPermissions( ObjVer objVer )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties GetObjectVersionAndProperties( ObjVer objVer, bool updateFromServer = false )
		{
			vault.MetricGatherer.MethodCalled();

			// TODO: use LatestVersion and UpdateFromServer
			List<TestObjectVersionAndProperties> thisObj =
				vault.ovaps.Where(obj => obj.ObjVer.ID == objVer.ID && obj.ObjVer.Type == objVer.Type).ToList();
			if (thisObj.Count == 0)
				return null;
			int lookupVersion = (objVer.Version == -1) ? thisObj.Max(obj => obj.ObjVer.Version) : objVer.Version;
			ObjectVersionAndProperties objectVersionAndProperties = thisObj.SingleOrDefault(obj => obj.ObjVer.Version == lookupVersion);
			
			return objectVersionAndProperties;
		}

		public ObjectVersions GetRelationships( ObjVer objVer, MFRelationshipsMode mode )
		{
			vault.MetricGatherer.MethodCalled();

			// TODO: far from optimal, vault.ovaps may need restructuring
			//      MFRelationshipsModeToThisObject is really bad
			List<ObjectVersion> relationships = new List<ObjectVersion>();

			if( mode == MFRelationshipsMode.MFRelationshipsModeAll || mode == MFRelationshipsMode.MFRelationshipsModeFromThisObject )
			{
				ObjectVersionAndProperties ovap = vault.GetOvap( objVer );
				foreach( PropertyValue propertyValue in ovap.Properties )
				{
					if( propertyValue.Value.IsNULL() )
						continue;
					PropertyDef pdef = vault.propertyDefs.Single( pd => pd.PropertyDef.ID == propertyValue.PropertyDef ).PropertyDef;
					if( pdef.ID <= 101 )
						continue;
					if( !pdef.BasedOnValueList )
						continue;
					ObjType ot = vault.objTypes.Single( ota => ota.ObjectType.ID == pdef.ValueList ).ObjectType;
					if( !ot.RealObjectType )
						continue;
					if( propertyValue.Value.DataType == MFDataType.MFDatatypeMultiSelectLookup )
					{
						foreach( Lookup value in propertyValue.Value.GetValueAsLookups() )
						{
							// TODO: find out what causes the following line to be necessary
							value.ObjectType = pdef.ValueList;
							if( value.Deleted )
								continue;
							if( relationships.SingleOrDefault( obj => obj.ObjVer.ID == value.Item && obj.ObjVer.Type == value.ObjectType ) == null )
							{
								relationships.Add( value.GetAsObjectVersion( vault, true ) );
							}
						}
					}
					if( propertyValue.Value.DataType == MFDataType.MFDatatypeLookup )
					{
						Lookup value = propertyValue.Value.GetValueAsLookup();
						if( relationships.SingleOrDefault( obj => obj.ObjVer.ID == value.Item && obj.ObjVer.Type == value.ObjectType ) == null )
						{
							relationships.Add( value.GetAsObjectVersion( vault, true ) );
						}
					}
				}
			}
			if( mode == MFRelationshipsMode.MFRelationshipsModeAll || mode == MFRelationshipsMode.MFRelationshipsModeToThisObject )
			{
				List<PropertyDef> propertiesThatReferenceThisObjType = vault.propertyDefs
					.Select( pda => pda.PropertyDef )
					.Where( pd => pd.BasedOnValueList && pd.ValueList == objVer.Type )
					.ToList();
				foreach( ObjectVersionAndProperties ovap in vault.ovaps )
				{
					if( vault.ObjectOperations.GetLatestObjVer( ovap.ObjVer.ObjID, true, true ).Version != ovap.ObjVer.Version )
						continue; // Only do latest version
					if( ovap.VersionData.Deleted )
						continue;
					foreach( PropertyDef propertyDef in propertiesThatReferenceThisObjType )
					{
						if( ovap.Properties.IndexOf( propertyDef.ID ) == -1 )
							continue;
						if( ovap.Properties.SearchForProperty( propertyDef.ID ).Value.IsNULL() )
							continue;
						if( propertyDef.DataType == MFDataType.MFDatatypeMultiSelectLookup )
						{
							foreach( Lookup valueAsLookup in ovap.Properties.SearchForProperty( propertyDef.ID ).Value.GetValueAsLookups() )
							{
								if( valueAsLookup.Item != objVer.ID )
									continue;
								if( relationships.SingleOrDefault( obj => obj.ObjVer.ID == ovap.ObjVer.ID && obj.ObjVer.Type == ovap.ObjVer.Type ) == null )
								{
									relationships.Add( ovap.VersionData );
								}
							}
						}
						else if( propertyDef.DataType == MFDataType.MFDatatypeLookup )
						{
							if( ovap.Properties.SearchForProperty( propertyDef.ID ).Value.GetLookupID() != objVer.ID )
								continue;
							if( relationships.SingleOrDefault( obj => obj.ObjVer.ID == ovap.ObjVer.ID && obj.ObjVer.Type == ovap.ObjVer.Type ) == null )
							{
								relationships.Add( ovap.VersionData );
							}
						}
					}
				}
			}

			TestObjectVersions objectVersions = new TestObjectVersions();
			foreach( ObjectVersion objectVersion in relationships )
			{
				objectVersions.Add( -1, objectVersion );
			}

			return objectVersions;
		}

		public byte[] GetThumbnailAsBytes( ObjVer objVer, FileVer fileVer, int width, int height, bool getFileIconThumbnailIfRealThumbnailNotAvailable )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public bool IsCheckedOut( ObjID objID, bool updateFromServer = false )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public bool IsSingleFileObject( ObjVer objVer )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties NotifyObjectAccess( ObjID objID )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public bool ProposeCheckOutForFile( IntPtr parentWindow, ObjectVersionFile objVersionFile, bool canCancel )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void RejectCheckInReminder( ObjVer objVer )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties RemoveFavorite( ObjID objID )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndPropertiesOfMultipleObjects RemoveFavorites( ObjIDs objIDs )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersion RemoveObject( ObjID objID )
		{
			vault.MetricGatherer.MethodCalled();

			TestObjectVersionAndProperties ovap = GetLatestTestObjectVersionAndProperties( objID, false, true );
			ovap.versionData.deleted = true;
			return ovap.VersionData;
		}

		public ObjectVersions ResolveConflict( ObjID participantObjID, bool keepThis )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersion Rollback( ObjID objID, int rollbackToVersion )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void SetObjectGUID( ObjID objID, string objectGuid )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void SetOfflineAvailability( ObjID objID, bool availableInOfflineMode )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void SetSingleFileObject( ObjVer objVer, bool singleFile )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectWindowResult ShowBasicEditObjectWindow( IntPtr parentWindow, ObjVer objVer )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectWindowResult ShowBasicNewObjectWindow( IntPtr parentWindow, ObjType objectType )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersion ShowCheckInReminder( IntPtr parentWindow, ObjVer objVer, bool asynchronous )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public bool ShowCheckInReminderDialogModal( IntPtr parentWindow, ObjVer objVer, bool applyEnvironmentConditions )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersion ShowCheckoutPrompt( IntPtr parentWindow, string message, ObjID objID, bool showCancel, bool autoRejectConsequentPrompts = false )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void ShowCollectionMembersDialog( IntPtr parentWindow, ObjVer objectVersion, bool modeless = false )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void ShowCommentsDialogModal( IntPtr parentWindow, ObjID objectID )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectWindowResult ShowEditObjectWindow( IntPtr parentWindow, MFObjectWindowMode mode, ObjVer objVer )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void ShowHistoryDialogModal( IntPtr parentWindow, ObjID objectID )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectWindowResult ShowNewObjectWindow( IntPtr parentWindow, MFObjectWindowMode mode, ObjectCreationInfo objectCreationInfo )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectWindowResult ShowPrefilledNewObjectWindow( IntPtr parentWindow, MFObjectWindowMode mode, ObjectCreationInfo objectCreationInfo, PropertyValues prefilledPropertyValues = null, AccessControlList accessControlList = null )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void ShowRelatedObjects( IntPtr parentWindow, ObjID sourceObject, ObjectTypeTargetForBrowsing objectTypeTargetForBrowsing, string viewSelectionDialogInfoText = "" )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void ShowRelationshipsDialog( IntPtr parentWindow, ObjVer objectVersion, bool modeless = false )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjOrFileVer ShowSelectObjectHistoryDialogModal( IntPtr parentWindow, ObjID objectID, string windowTitle = "" )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void ShowSubObjectsDialogModal( IntPtr parentWindow, ObjVer objectVersion )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersion UndeleteObject( ObjID objID )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersion UndoCheckout( ObjVer objVer )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}
	}
}
