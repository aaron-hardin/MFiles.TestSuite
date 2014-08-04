using System;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
	public class TestObjectSearchOperations : VaultObjectSearchOperations
	{
		private TestVault vault;

		public TestObjectSearchOperations( TestVault vault )
		{
			vault.MetricGatherer.MethodCalled();

			this.vault = vault;
		}

		public ObjectVersionFile FindFile( string relativePath, bool updateFromServer = false )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectVersionAndProperties FindObjectVersionAndProperties( string relativePath, bool updateFromServer = false )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectSearchResults GetObjectsInPath( string relativePath, bool sortResults, bool updateFromServer = false )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public bool IsObjectPathInMFiles( string relativePath )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectSearchResults SearchForObjectsByCondition( SearchCondition searchCondition, bool sortResults )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectSearchResults SearchForObjectsByConditions( SearchConditions searchConditions, MFSearchFlags searchFlags, bool sortResults )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectSearchResults SearchForObjectsByConditionsEx( SearchConditions searchConditions, MFSearchFlags searchFlags, bool sortResults, int maxResultCount = 500, int searchTimeoutInSeconds = 60 )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();

			//if(SearchFlags != MFSearchFlags.MFSearchFlagNone)
			//    throw new NotImplementedException();

			//List<ObjectVersionAndProperties> objects = vault.ovaps.Where()
		}

		public XMLSearchResult SearchForObjectsByConditionsXML( SearchConditions searchConditions, bool sortResults )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectSearchResults SearchForObjectsByExportedSearchConditions( string exportedSearchString, bool sortResults )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public XMLSearchResult SearchForObjectsByExportedSearchConditionsXML( string searchString, bool sortResults )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}

		public ObjectSearchResults SearchForObjectsByString( string searchString, bool sortResults, MFFullTextSearchFlags fullTextSearchFlags )
		{
			vault.MetricGatherer.MethodCalled();

			throw new NotImplementedException();
		}
	}
}
