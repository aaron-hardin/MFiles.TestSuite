using System;
using System.Linq;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestValueListItemOperations : VaultValueListItemOperations
    {
        private TestVault vault;

        public TestValueListItemOperations(TestVault vault)
        {
            this.vault = vault;
        }

        public ValueListItem AddValueListItem(int ValueList, ValueListItem ValueListItem, bool AdministrativeOperation = false)
        {
            ValueListItem.ValueListID = ValueList;
            this.vault.valueListItems.Add(ValueListItem);
            return ValueListItem;
        }

        public void ChangeAutomaticPermissionsToACL(int ValueList, int ValueListItemID, AccessControlList AccessControlList, string NameForAutomaticPermissions, bool CanDeactivate = true, MFAutomaticPermissionsOperationOptions AutomaticPermissionsOperationOptions = MFAutomaticPermissionsOperationOptions.MFAutomaticPermissionsOperationOptionsNone)
        {
            throw new NotImplementedException();
        }

        public void ChangeAutomaticPermissionsToItemsOwnPermissions(int ValueList, int ValueListItemID, bool CanDeactivate = true, MFAutomaticPermissionsOperationOptions AutomaticPermissionsOperationOptions = MFAutomaticPermissionsOperationOptions.MFAutomaticPermissionsOperationOptionsNone)
        {
            throw new NotImplementedException();
        }

        public void ChangeAutomaticPermissionsToNamedACL(int ValueList, int ValueListItemID, int NamedACL, bool CanDeactivate = true, MFAutomaticPermissionsOperationOptions AutomaticPermissionsOperationOptions = MFAutomaticPermissionsOperationOptions.MFAutomaticPermissionsOperationOptionsNone)
        {
            throw new NotImplementedException();
        }

        public void ChangeDefaultPermissionsToACL(int ValueList, int ValueListItemID, AccessControlList AccessControlList)
        {
            throw new NotImplementedException();
        }

        public void ChangeDefaultPermissionsToNamedACL(int ValueList, int ValueListItemID, int NamedACL)
        {
            throw new NotImplementedException();
        }

        public void ChangePermissionsToACL(int ValueList, int ValueListItemID, AccessControlList AccessControlList)
        {
            throw new NotImplementedException();
        }

        public void ChangePermissionsToNamedACL(int ValueList, int ValueListItemID, int NamedACL)
        {
            throw new NotImplementedException();
        }

        public void ClearAutomaticPermissions(int ValueList, int ValueListItemID)
        {
            throw new NotImplementedException();
        }

        public ValueListItem GetValueListItemByDisplayID(int ValueList, string ValueListItemDisplayID)
        {
            throw new NotImplementedException();
        }

        public ValueListItem GetValueListItemByDisplayIDEx(int ValueList, string ValueListItemDisplayID, bool ReplaceCurrentUserWithCallersIdentity = true)
        {
            throw new NotImplementedException();
        }

        public ValueListItem GetValueListItemByID(int ValueList, int ValueListItemID)
        {
            ValueListItem item =
                this.vault.valueListItems.SingleOrDefault(vli => vli.ValueListID == ValueList && vli.ID == ValueListItemID);
            return item;
        }

        public ValueListItem GetValueListItemByIDEx(int ValueList, int ValueListItemID, bool ReplaceCurrentUserWithCallersIdentity = true)
        {
            throw new NotImplementedException();
        }

        public ValueListItems GetValueListItems(int ValueList, bool UpdateFromServer = false, MFExternalDBRefreshType RefreshTypeIfExternalValueList = MFExternalDBRefreshType.MFExternalDBRefreshTypeNone)
        {
            throw new NotImplementedException();
        }

        public ValueListItems GetValueListItemsEx(int ValueList, bool UpdateFromServer = false, MFExternalDBRefreshType RefreshTypeIfExternalValueList = MFExternalDBRefreshType.MFExternalDBRefreshTypeNone, bool ReplaceCurrentUserWithCallersIdentity = true)
        {
            throw new NotImplementedException();
        }

        public ValueListItems GetValueListItemsEx2(int ValueList, bool UpdateFromServer = false, MFExternalDBRefreshType RefreshTypeIfExternalValueList = MFExternalDBRefreshType.MFExternalDBRefreshTypeNone, bool ReplaceCurrentUserWithCallersIdentity = true, int PropertyDef = -1)
        {
            throw new NotImplementedException();
        }

        public ValueListItemsWithPermissions GetValueListItemsWithPermissions(int ValueList, bool UpdateFromServer = false, MFExternalDBRefreshType RefreshTypeIfExternalValueList = MFExternalDBRefreshType.MFExternalDBRefreshTypeNone, bool ReplaceCurrentUserWithCallersIdentity = true, int PropertyDef = -1)
        {
            throw new NotImplementedException();
        }

        public void RemoveValueListItem(int ValueList, int Item)
        {
            throw new NotImplementedException();
        }

        public ValueListItemSearchResults SearchForValueListItems(int ValueList, SearchConditions SearchConditions, bool UpdateFromServer = false, MFExternalDBRefreshType RefreshTypeIfExternalValueList = MFExternalDBRefreshType.MFExternalDBRefreshTypeNone)
        {
            throw new NotImplementedException();
        }

        public ValueListItemSearchResults SearchForValueListItemsEx(int ValueList, SearchConditions SearchConditions, bool UpdateFromServer = false, MFExternalDBRefreshType RefreshTypeIfExternalValueList = MFExternalDBRefreshType.MFExternalDBRefreshTypeNone, bool ReplaceCurrentUserWithCallersIdentity = true)
        {
            throw new NotImplementedException();
        }

        public ValueListItemSearchResults SearchForValueListItemsEx2(int ValueList, SearchConditions SearchConditions, bool UpdateFromServer = false, MFExternalDBRefreshType RefreshTypeIfExternalValueList = MFExternalDBRefreshType.MFExternalDBRefreshTypeNone, bool ReplaceCurrentUserWithCallersIdentity = true, int PropertyDef = -1, int MaxResults = 5000)
        {
            throw new NotImplementedException();
        }

        public ValueListItemSearchResultsWithPermissions SearchForValueListItemsWithPermissions(int ValueList, SearchConditions SearchConditions, bool UpdateFromServer = false, MFExternalDBRefreshType RefreshTypeIfExternalValueList = MFExternalDBRefreshType.MFExternalDBRefreshTypeNone, bool ReplaceCurrentUserWithCallersIdentity = true, int PropertyDef = -1, int MaxResults = 5000)
        {
            throw new NotImplementedException();
        }

        public void UndeleteValueListItem(int ValueList, int ValueListItemID)
        {
            throw new NotImplementedException();
        }

        public void UpdateValueListItem(ValueListItem ValueListItem)
        {
            throw new NotImplementedException();
        }
    }
}
