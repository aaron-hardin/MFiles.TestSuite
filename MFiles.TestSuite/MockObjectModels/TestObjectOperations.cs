using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;
using VaultMockObjects.VaultExtensions;

namespace VaultMockObjects.MockObjectModels
{
    public class TestObjectOperations : VaultObjectOperations
    {
        private TestVault vault;

        public TestObjectOperations(TestVault vault)
        {
            this.vault = vault;
        }

        public ObjectVersionAndProperties AddFavorite(ObjID ObjID)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndPropertiesOfMultipleObjects AddFavorites(ObjIDs ObjIDs)
        {
            throw new NotImplementedException();
        }

        public ObjectVersion ChangePermissionsToACL(ObjVer ObjVer, AccessControlList AccessControlList, bool ChangeAllVersions)
        {
            throw new NotImplementedException();
        }

        public ObjectVersion ChangePermissionsToNamedACL(ObjVer ObjVer, int NamedACL, bool ChangeAllVersions)
        {
            throw new NotImplementedException();
        }

        public ObjectVersion CheckIn(ObjVer ObjVer)
        {
            throw new NotImplementedException();
        }

        public ObjectVersions CheckInMultipleObjects(ObjVers ObjVers)
        {
            throw new NotImplementedException();
        }

        public ObjectVersion CheckOut(ObjID ObjID)
        {
            throw new NotImplementedException();
        }

        public ObjectVersions CheckOutMultipleObjects(ObjIDs ObjIDs)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties CreateNewAssignment(string AssignmentName, string AssignmentDescription, TypedValue AssignedToUser, TypedValue Deadline = null, AccessControlList AccessControlList = null)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties CreateNewEmptySingleFileDocument(PropertyValues PropertyValues, string Title, string Extension, AccessControlList AccessControlList = null)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties CreateNewObject(int ObjectType, PropertyValues PropertyValues, 
            SourceObjectFiles SourceObjectFiles = null, AccessControlList AccessControlList = null)
        {
            // TODO: use parameter args
            int maxId = 0;
            List<ObjectVersionAndProperties> objThisType = this.vault.ovaps.Where(obj => obj.ObjVer.Type == ObjectType).ToList();
            if (objThisType.Count > 0)
                maxId = objThisType.Max(obj => obj.ObjVer.ID);
            TestObjectVersion objectVersion = new TestObjectVersion
            {
                ObjVer = new ObjVer { Type = ObjectType, ID = maxId, Version = 1}
            };
            objectVersion.Class = PropertyValues.SearchForProperty(100).Value.GetLookupID();
            TestObjectVersionAndProperties ovap = new TestObjectVersionAndProperties
            {
                ObjVer = objectVersion.ObjVer,
                Properties = PropertyValues,
                Vault = this.vault,
                VersionData = objectVersion
            };
            this.vault.ovaps.Add(ovap);
            return ovap;
        }

        public ObjectVersionAndProperties CreateNewObjectEx(int ObjectType, PropertyValues Properties, SourceObjectFiles SourceFiles, 
            bool SFD, bool CheckIn, AccessControlList AccessControlList = null)
        {

            throw new NotImplementedException();
        }

        public int CreateNewObjectExQuick(int ObjectType, PropertyValues Properties, SourceObjectFiles SourceFiles, bool SFD, bool CheckIn, AccessControlList AccessControlList = null)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties CreateNewSFDObject(int ObjectType, PropertyValues Properties, SourceObjectFile SourceFile, bool CheckIn, AccessControlList AccessControlList = null)
        {
            throw new NotImplementedException();
        }

        public int CreateNewSFDObjectQuick(int ObjectType, PropertyValues Properties, SourceObjectFile SourceFile, bool CheckIn, AccessControlList AccessControlList = null)
        {
            throw new NotImplementedException();
        }

        public void DelayedCheckIn(ObjVer ObjVer)
        {
            throw new NotImplementedException();
        }

        public void DestroyObject(ObjID ObjID, bool DestroyAllVersions, int ObjectVersion)
        {
            throw new NotImplementedException();
        }

        public void DestroyObjects(ObjIDs ObjIDs)
        {
            throw new NotImplementedException();
        }

        public ObjectVersion ForceUndoCheckout(ObjVer ObjVer)
        {
            throw new NotImplementedException();
        }

        public ObjectVersions GetCollectionMembers(ObjVer ObjVer)
        {
            throw new NotImplementedException();
        }

        public ObjectVersions GetHistory(ObjID ObjID)
        {
            throw new NotImplementedException();
        }

        public ObjVer GetLatestObjVer(ObjID ObjID, bool AllowCheckedOut, bool UpdateFromServer = false)
        {
            // TODO: handle AllowCheckedOut and UpdateFromServer
            List<ObjectVersionAndProperties> thisObj =
                this.vault.ovaps.Where(obj => obj.ObjVer.ID == ObjID.ID && obj.ObjVer.Type == ObjID.Type).ToList();
            if (thisObj.Count == 0)
                return null;
            int maxVersion = thisObj.Max(obj => obj.ObjVer.Version);
            ObjectVersionAndProperties objectVersionAndProperties = thisObj.SingleOrDefault(obj => obj.ObjVer.Version == maxVersion);
            return objectVersionAndProperties == null ? null : objectVersionAndProperties.ObjVer;
        }

        public ObjVer GetLatestObjVerEx(ObjID ObjID, bool AllowCheckedOut, bool UpdateFromServer = false, bool NotifyViews = false)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties GetLatestObjectVersionAndProperties(ObjID ObjID, bool AllowCheckedOut, bool UpdateFromServer = false)
        {
            // TODO: use arguments
            List<ObjectVersionAndProperties> thisObj = this.vault.ovaps.Where(obj => obj.ObjVer.ID == ObjID.ID && obj.ObjVer.Type == ObjID.Type).ToList();
            if (thisObj.Count == 0)
                return null;
            int maxObj = thisObj.Max(obj => obj.ObjVer.Version);
            ObjectVersionAndProperties ovap = thisObj.Single(obj => obj.ObjVer.Version == maxObj);
            return ovap;
        }

        public string GetMFilesURLForObject(ObjID ObjID, int TargetVersion, bool SpecificVersion, MFilesURLType URLType = MFilesURLType.MFilesURLTypeShow)
        {
            throw new NotImplementedException();
        }

        public string GetMFilesURLForObjectOrFile(ObjID ObjID, int TargetVersion = -1, bool SpecificVersion = false, int File = -1, MFilesURLType URLType = MFilesURLType.MFilesURLTypeShow)
        {
            throw new NotImplementedException();
        }

        public ObjID GetObjIDByGUID(string ObjectGUID)
        {
            throw new NotImplementedException();
        }

        public ObjID GetObjIDByOriginalObjID(string OriginalVaultGUID, ObjID OriginalObjID)
        {
            throw new NotImplementedException();
        }

        public string GetObjectGUID(ObjID ObjID)
        {
            throw new NotImplementedException();
        }

        public ObjectVersion GetObjectInfo(ObjVer ObjVer, bool LatestVersion, bool UpdateFromServer = false)
        {
            // TODO: use LatestVersion and UpdateFromServer
            List<ObjectVersionAndProperties> thisObj =
                this.vault.ovaps.Where(obj => obj.ObjVer.ID == ObjVer.ID && obj.ObjVer.Type == ObjVer.Type).ToList();
            if (thisObj.Count == 0)
                return null;
            int lookupVersion = (ObjVer.Version == -1) ? thisObj.Max(obj => obj.ObjVer.Version) : ObjVer.Version;
            ObjectVersionAndProperties objectVersionAndProperties = thisObj.SingleOrDefault(obj => obj.ObjVer.Version == lookupVersion);
            if (objectVersionAndProperties == null)
                return null;
            TestObjectVersion objectVersion = (TestObjectVersion)objectVersionAndProperties.VersionData;
            objectVersion.Class = objectVersionAndProperties.Properties.SearchForProperty(100).Value.GetLookupID();
            objectVersion.Title = objectVersionAndProperties.Properties.SearchForProperty(0).GetValueAsLocalizedText();
            return objectVersion;
        }

        public ObjectVersion GetObjectInfoEx(ObjVer ObjVer, bool LatestVersion, bool UpdateFromServer = false, bool NotifyViews = false)
        {
            throw new NotImplementedException();
        }

        public Strings GetObjectLocationsInView(int View, MFLatestSpecificBehavior LatestSpecificBehavior, ObjVer ObjectVersion)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionPermissions GetObjectPermissions(ObjVer ObjVer)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties GetObjectVersionAndProperties(ObjVer ObjVer, bool UpdateFromServer = false)
        {
            throw new NotImplementedException();
        }

        public ObjectVersions GetRelationships(ObjVer ObjVer, MFRelationshipsMode Mode)
        {
            // TODO: far from optimal, vault.ovaps may need restructuring
            //      MFRelationshipsModeToThisObject is really bad
            List<ObjectVersion> relationships = new List<ObjectVersion>();

            if(Mode == MFRelationshipsMode.MFRelationshipsModeAll || Mode == MFRelationshipsMode.MFRelationshipsModeFromThisObject)
            {
                ObjectVersionAndProperties ovap = this.vault.GetOvap(ObjVer);
                foreach (PropertyValue propertyValue in ovap.Properties)
                {
                    if (propertyValue.Value.IsNULL())
                        continue;
                    PropertyDef pdef = this.vault.propertyDefs.Single(pd => pd.PropertyDef.ID == propertyValue.PropertyDef).PropertyDef;
                    if (pdef.ID <= 101)
                        continue;
                    if(!pdef.BasedOnValueList)
                        continue;
                    ObjType ot = this.vault.objTypes.Single(ota => ota.ObjectType.ID == pdef.ValueList).ObjectType;
                    if (!ot.RealObjectType)
                        continue;
                    if (propertyValue.Value.DataType == MFDataType.MFDatatypeMultiSelectLookup)
                    {
                        foreach (Lookup value in propertyValue.Value.GetValueAsLookups())
                        {
                            // TODO: find out what causes the following line to be necessary
                            value.ObjectType = pdef.ValueList;
                            if (relationships.SingleOrDefault(obj => obj.ObjVer.ID == value.Item && obj.ObjVer.Type == value.ObjectType) == null)
                            {
                                relationships.Add(value.GetAsObjectVersion(this.vault, true));
                            }
                        }
                    }
                    if (propertyValue.Value.DataType == MFDataType.MFDatatypeLookup)
                    {
                        Lookup value = propertyValue.Value.GetValueAsLookup();
                        if(relationships.SingleOrDefault(obj => obj.ObjVer.ID == value.Item && obj.ObjVer.Type == value.ObjectType) == null)
                        {
                            relationships.Add(value.GetAsObjectVersion(this.vault, true));
                        }
                    }
                }
            }
            if(Mode == MFRelationshipsMode.MFRelationshipsModeAll || Mode == MFRelationshipsMode.MFRelationshipsModeToThisObject)
            {
                List<PropertyDef> propertiesThatReferenceThisObjType = this.vault.propertyDefs
                    .Select(pda => pda.PropertyDef)
                    .Where(pd => pd.BasedOnValueList && pd.ValueList == ObjVer.Type)
                    .ToList();
                foreach (ObjectVersionAndProperties ovap in this.vault.ovaps)
                {
                    if(this.vault.ObjectOperations.GetLatestObjVer(ovap.ObjVer.ObjID, true, true).Version != ovap.ObjVer.Version)
                        continue; // Only do latest version
                    foreach (PropertyDef propertyDef in propertiesThatReferenceThisObjType)
                    {
                        if (ovap.Properties.IndexOf(propertyDef.ID) == -1)
                            continue;
                        if(ovap.Properties.SearchForProperty(propertyDef.ID).Value.IsNULL())
                            continue;
                        if(propertyDef.DataType == MFDataType.MFDatatypeMultiSelectLookup)
                        {
                            foreach (Lookup valueAsLookup in ovap.Properties.SearchForProperty(propertyDef.ID).Value.GetValueAsLookups())
                            {
                                if (valueAsLookup.Item != ObjVer.ID)
                                    continue;
                                if (relationships.SingleOrDefault(obj => obj.ObjVer.ID == ovap.ObjVer.ID && obj.ObjVer.Type == ovap.ObjVer.Type) == null)
                                {
                                    relationships.Add(ovap.VersionData);
                                }
                            }
                        }
                        else if(propertyDef.DataType == MFDataType.MFDatatypeLookup)
                        {
                            if(ovap.Properties.SearchForProperty(propertyDef.ID).Value.GetLookupID() != ObjVer.ID)
                                continue;
                            if (relationships.SingleOrDefault(obj => obj.ObjVer.ID == ovap.ObjVer.ID && obj.ObjVer.Type == ovap.ObjVer.Type) == null)
                            {
                                relationships.Add(ovap.VersionData);
                            }
                        }
                    }
                }
            }

            ObjectVersions objectVersions = new ObjectVersions();
            foreach (ObjectVersion objectVersion in relationships)
            {
                objectVersions.Add(-1, objectVersion);
            }

            return objectVersions;
        }

        public byte[] GetThumbnailAsBytes(ObjVer ObjVer, FileVer FileVer, int Width, int Height, bool GetFileIconThumbnailIfRealThumbnailNotAvailable)
        {
            throw new NotImplementedException();
        }

        public bool IsCheckedOut(ObjID ObjID, bool UpdateFromServer = false)
        {
            throw new NotImplementedException();
        }

        public bool IsSingleFileObject(ObjVer ObjVer)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties NotifyObjectAccess(ObjID ObjID)
        {
            throw new NotImplementedException();
        }

        public bool ProposeCheckOutForFile(IntPtr ParentWindow, ObjectVersionFile ObjVersionFile, bool CanCancel)
        {
            throw new NotImplementedException();
        }

        public void RejectCheckInReminder(ObjVer ObjVer)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties RemoveFavorite(ObjID ObjID)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndPropertiesOfMultipleObjects RemoveFavorites(ObjIDs ObjIDs)
        {
            throw new NotImplementedException();
        }

        public ObjectVersion RemoveObject(ObjID ObjID)
        {
            throw new NotImplementedException();
        }

        public ObjectVersions ResolveConflict(ObjID ParticipantObjID, bool KeepThis)
        {
            throw new NotImplementedException();
        }

        public ObjectVersion Rollback(ObjID ObjID, int RollbackToVersion)
        {
            throw new NotImplementedException();
        }

        public void SetObjectGUID(ObjID ObjID, string ObjectGUID)
        {
            throw new NotImplementedException();
        }

        public void SetOfflineAvailability(ObjID ObjID, bool AvailableInOfflineMode)
        {
            throw new NotImplementedException();
        }

        public void SetSingleFileObject(ObjVer ObjVer, bool SingleFile)
        {
            throw new NotImplementedException();
        }

        public ObjectWindowResult ShowBasicEditObjectWindow(IntPtr ParentWindow, ObjVer ObjVer)
        {
            throw new NotImplementedException();
        }

        public ObjectWindowResult ShowBasicNewObjectWindow(IntPtr ParentWindow, ObjType ObjectType)
        {
            throw new NotImplementedException();
        }

        public ObjectVersion ShowCheckInReminder(IntPtr ParentWindow, ObjVer ObjVer, bool Asynchronous)
        {
            throw new NotImplementedException();
        }

        public bool ShowCheckInReminderDialogModal(IntPtr ParentWindow, ObjVer ObjVer, bool ApplyEnvironmentConditions)
        {
            throw new NotImplementedException();
        }

        public ObjectVersion ShowCheckoutPrompt(IntPtr ParentWindow, string Message, ObjID ObjID, bool ShowCancel, bool AutoRejectConsequentPrompts = false)
        {
            throw new NotImplementedException();
        }

        public void ShowCollectionMembersDialog(IntPtr ParentWindow, ObjVer ObjectVersion, bool Modeless = false)
        {
            throw new NotImplementedException();
        }

        public void ShowCommentsDialogModal(IntPtr ParentWindow, ObjID ObjectID)
        {
            throw new NotImplementedException();
        }

        public ObjectWindowResult ShowEditObjectWindow(IntPtr ParentWindow, MFObjectWindowMode Mode, ObjVer ObjVer)
        {
            throw new NotImplementedException();
        }

        public void ShowHistoryDialogModal(IntPtr ParentWindow, ObjID ObjectID)
        {
            throw new NotImplementedException();
        }

        public ObjectWindowResult ShowNewObjectWindow(IntPtr ParentWindow, MFObjectWindowMode Mode, ObjectCreationInfo ObjectCreationInfo)
        {
            throw new NotImplementedException();
        }

        public ObjectWindowResult ShowPrefilledNewObjectWindow(IntPtr ParentWindow, MFObjectWindowMode Mode, ObjectCreationInfo ObjectCreationInfo, PropertyValues PrefilledPropertyValues = null, AccessControlList AccessControlList = null)
        {
            throw new NotImplementedException();
        }

        public void ShowRelatedObjects(IntPtr ParentWindow, ObjID SourceObject, ObjectTypeTargetForBrowsing ObjectTypeTargetForBrowsing, string ViewSelectionDialogInfoText = "")
        {
            throw new NotImplementedException();
        }

        public void ShowRelationshipsDialog(IntPtr ParentWindow, ObjVer ObjectVersion, bool Modeless = false)
        {
            throw new NotImplementedException();
        }

        public ObjOrFileVer ShowSelectObjectHistoryDialogModal(IntPtr ParentWindow, ObjID ObjectID, string WindowTitle = "")
        {
            throw new NotImplementedException();
        }

        public void ShowSubObjectsDialogModal(IntPtr ParentWindow, ObjVer ObjectVersion)
        {
            throw new NotImplementedException();
        }

        public ObjectVersion UndeleteObject(ObjID ObjID)
        {
            throw new NotImplementedException();
        }

        public ObjectVersion UndoCheckout(ObjVer ObjVer)
        {
            throw new NotImplementedException();
        }
    }
}
