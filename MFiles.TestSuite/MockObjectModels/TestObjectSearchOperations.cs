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

			if( searchFlags.HasFlag( MFSearchFlags.MFSearchFlagLookInAllVersions ) )
			{
				throw new NotImplementedException();
			}
			if (searchFlags.HasFlag(MFSearchFlags.MFSearchFlagReturnLatestVisibleVersion))
			{
				throw new NotImplementedException();
			}

			TestObjectSearchResults osr = new TestObjectSearchResults();

			if(searchConditions.Count > 1)
				throw new Exception("Currently only one condition is supported.");

			foreach( SearchCondition searchCondition in searchConditions )
			{
				if (searchCondition.Expression.Type == MFExpressionType.MFExpressionTypePropertyValue)
				{
					int propId = searchCondition.Expression.DataPropertyValuePropertyDef;

					foreach( TestObjectVersionAndProperties testOvap in vault.ovaps )
					{
						if(testOvap.Properties.IndexOf( propId ) != -1)
						{
							switch( searchCondition.TypedValue.DataType )
							{
								case MFDataType.MFDatatypeLookup:
									if(searchCondition.TypedValue.GetLookupID() == testOvap.Properties.SearchForProperty( propId ).Value.GetLookupID())
										osr.Add( testOvap );
									break;
								default:
									throw new Exception("Datatype not yet supported in Search Conditions");
							}
							//if(searchCondition.TypedValue.Value == testOvap.Properties.SearchForProperty( propId ).Value.Value)
							//{
							//	osr.Add( testOvap );
							//}
						}
					}
					return osr;
				}
				else
				{
					throw new Exception("Expression Type not yet supported in SearchForObjects::"+searchCondition.Expression.Type);
				}
			}
			
			//if(SearchFlags != MFSearchFlags.MFSearchFlagNone)
			//    throw new NotImplementedException();

			//List<ObjectVersionAndProperties> objects = vault.ovaps.Where()

			throw new NotImplementedException();
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
