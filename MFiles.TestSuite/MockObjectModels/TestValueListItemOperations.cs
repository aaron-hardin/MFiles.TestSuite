using System;
using System.Collections.Generic;
using System.Linq;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
	public class TestValueListItemOperations : VaultValueListItemOperations
	{
		private TestVault vault;

		public TestValueListItemOperations( TestVault vault )
		{
			vault.MetricGatherer.MethodCalled();

			this.vault = vault;
		}

		public ValueListItem AddValueListItem( int valueList, ValueListItem valueListItem, bool administrativeOperation = false )
		{
			vault.MetricGatherer.MethodCalled();

			valueListItem.ValueListID = valueList;
			vault.ValueListItems.Add(new TestValueListItem(valueListItem));
			return valueListItem;
		}

		public void ChangeAutomaticPermissionsToACL( int valueList, int valueListItemID, AccessControlList accessControlList, string nameForAutomaticPermissions, bool canDeactivate = true, MFAutomaticPermissionsOperationOptions automaticPermissionsOperationOptions = MFAutomaticPermissionsOperationOptions.MFAutomaticPermissionsOperationOptionsNone )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void ChangeAutomaticPermissionsToItemsOwnPermissions( int valueList, int valueListItemID, bool canDeactivate = true, MFAutomaticPermissionsOperationOptions automaticPermissionsOperationOptions = MFAutomaticPermissionsOperationOptions.MFAutomaticPermissionsOperationOptionsNone )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void ChangeAutomaticPermissionsToNamedACL( int valueList, int valueListItemID, int namedAcl, bool canDeactivate = true, MFAutomaticPermissionsOperationOptions automaticPermissionsOperationOptions = MFAutomaticPermissionsOperationOptions.MFAutomaticPermissionsOperationOptionsNone )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void ChangeDefaultPermissionsToACL( int valueList, int valueListItemID, AccessControlList accessControlList )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void ChangeDefaultPermissionsToNamedACL( int valueList, int valueListItemID, int namedAcl )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void ChangePermissionsToACL( int valueList, int valueListItemID, AccessControlList accessControlList )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void ChangePermissionsToNamedACL( int valueList, int valueListItemID, int namedAcl )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void ClearAutomaticPermissions( int valueList, int valueListItemID )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ValueListItem GetValueListItemByDisplayID( int valueList, string valueListItemDisplayID )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ValueListItem GetValueListItemByDisplayIDEx( int valueList, string valueListItemDisplayID, bool replaceCurrentUserWithCallersIdentity = true )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ValueListItem GetValueListItemByID( int valueList, int valueListItemID )
		{
			vault.MetricGatherer.MethodCalled();

			ValueListItem item =
				vault.ValueListItems.SingleOrDefault( vli => vli.ValueListID == valueList && vli.ID == valueListItemID );
			return item;
		}

		public ValueListItem GetValueListItemByIDEx( int valueList, int valueListItemID, bool replaceCurrentUserWithCallersIdentity = true )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ValueListItems GetValueListItems( int valueList, bool updateFromServer = false, MFExternalDBRefreshType refreshTypeIfExternalValueList = MFExternalDBRefreshType.MFExternalDBRefreshTypeNone )
		{
			vault.MetricGatherer.MethodCalled();

			TestValueListItems results = new TestValueListItems();

			List<TestValueListItem> items = vault.ValueListItems.Where( vli => vli.ValueListID == valueList ).ToList();

			foreach( TestValueListItem testValueListItem in items )
			{
				results.Items.Add( testValueListItem );
			}

			return results;
		}

		public ValueListItems GetValueListItemsEx( int valueList, bool updateFromServer = false, MFExternalDBRefreshType refreshTypeIfExternalValueList = MFExternalDBRefreshType.MFExternalDBRefreshTypeNone, bool replaceCurrentUserWithCallersIdentity = true )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ValueListItems GetValueListItemsEx2( int valueList, bool updateFromServer = false, MFExternalDBRefreshType refreshTypeIfExternalValueList = MFExternalDBRefreshType.MFExternalDBRefreshTypeNone, bool replaceCurrentUserWithCallersIdentity = true, int propertyDef = -1 )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ValueListItemsWithPermissions GetValueListItemsWithPermissions( int valueList, bool updateFromServer = false, MFExternalDBRefreshType refreshTypeIfExternalValueList = MFExternalDBRefreshType.MFExternalDBRefreshTypeNone, bool replaceCurrentUserWithCallersIdentity = true, int propertyDef = -1 )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void RemoveValueListItem( int valueList, int item )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ValueListItemSearchResults SearchForValueListItems( int valueList, SearchConditions searchConditions, bool updateFromServer = false, MFExternalDBRefreshType refreshTypeIfExternalValueList = MFExternalDBRefreshType.MFExternalDBRefreshTypeNone )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ValueListItemSearchResults SearchForValueListItemsEx( int valueList, SearchConditions searchConditions, bool updateFromServer = false, MFExternalDBRefreshType refreshTypeIfExternalValueList = MFExternalDBRefreshType.MFExternalDBRefreshTypeNone, bool replaceCurrentUserWithCallersIdentity = true )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ValueListItemSearchResults SearchForValueListItemsEx2( int valueList, SearchConditions searchConditions, bool updateFromServer = false, MFExternalDBRefreshType refreshTypeIfExternalValueList = MFExternalDBRefreshType.MFExternalDBRefreshTypeNone, bool replaceCurrentUserWithCallersIdentity = true, int propertyDef = -1, int maxResults = 5000 )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ValueListItemSearchResultsWithPermissions SearchForValueListItemsWithPermissions( int valueList, SearchConditions searchConditions, bool updateFromServer = false, MFExternalDBRefreshType refreshTypeIfExternalValueList = MFExternalDBRefreshType.MFExternalDBRefreshTypeNone, bool replaceCurrentUserWithCallersIdentity = true, int propertyDef = -1, int maxResults = 5000 )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void UndeleteValueListItem( int valueList, int valueListItemID )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public void UpdateValueListItem( ValueListItem valueListItem )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}
	}
}
