using System;
using System.Collections.Generic;
using System.Linq;
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

			List<TestObjectVersionAndProperties> results = new List<TestObjectVersionAndProperties>(vault.ovaps);

			foreach( SearchCondition searchCondition in searchConditions )
			{
				List<TestObjectVersionAndProperties> remainingResults = new List<TestObjectVersionAndProperties>( results );
				foreach( TestObjectVersionAndProperties testOvap in remainingResults )
				{
					// Latest version only
					List<TestObjectVersionAndProperties> thisObj =
						vault.ovaps.Where( obj => obj.ObjVer.ID == testOvap.ObjVer.ID && obj.ObjVer.Type == testOvap.ObjVer.Type )
							.ToList();
					int maxVersion = thisObj.Max( obj => obj.ObjVer.Version );
					if( testOvap.ObjVer.Version != maxVersion )
					{
						results.Remove( testOvap );
						continue;
					}

					switch( searchCondition.Expression.Type )
					{
						case MFExpressionType.MFExpressionTypePropertyValue:
						{
							int propId = searchCondition.Expression.DataPropertyValuePropertyDef;

							if( testOvap.Properties.IndexOf( propId ) != -1 )
							{
								PropertyValue pv = testOvap.Properties.SearchForProperty( propId );
								switch( searchCondition.TypedValue.DataType )
								{
									case MFDataType.MFDatatypeLookup:
										if(pv.TypedValue.DataType == MFDataType.MFDatatypeMultiSelectLookup)
										{
											Lookups lks = pv.TypedValue.GetValueAsLookups();
											bool exists = false;
											foreach( Lookup lookup in lks )
											{
												if(lookup.Item == searchCondition.TypedValue.GetLookupID())
												{
													exists = true;
												}
											}
											if(!exists)
											{
												results.Remove( testOvap );
											}
										}
										else if( pv.TypedValue.DataType == MFDataType.MFDatatypeLookup )
										{
											if( searchCondition.TypedValue.GetLookupID()
											    != testOvap.Properties.SearchForProperty( propId ).Value.GetLookupID() )
												if( searchCondition.ConditionType == MFConditionType.MFConditionTypeEqual )
												{
													results.Remove( testOvap );
												}
												else
												{
													throw new Exception( "ConditionType not yet supported in Search Conditions :: DataType lookup" );
												}
										}
										else
										{
											throw new Exception("Parameter incorrect");
										}
										break;
									default:
										throw new Exception( "Datatype not yet supported in Search Conditions" );
								}
								//if(searchCondition.TypedValue.Value == testOvap.Properties.SearchForProperty( propId ).Value.Value)
								//{
								//	osr.Add( testOvap );
								//}
							}
							else
							{
								results.Remove(testOvap);
							}
						}
							break;
						case MFExpressionType.MFExpressionTypeStatusValue:
							switch( searchCondition.ConditionType )
							{
								case MFConditionType.MFConditionTypeEqual:
									switch( searchCondition.Expression.DataStatusValueType )
									{
										case MFStatusType.MFStatusTypeDeleted:
											if(testOvap.VersionData.Deleted)
											{
												results.Remove(testOvap);
											}
											break;
										case MFStatusType.MFStatusTypeObjectTypeID:
											if(testOvap.ObjVer.Type != searchCondition.TypedValue.GetLookupID())
											{
												results.Remove( testOvap );
											}
											break;
										default:
											throw new Exception("MFStatusType not yet supported in Search Conditions for MFExpressionTypeStatusValue::MFConditionTypeEqual");
									}
									break;
								default:
									throw new Exception( "ConditionType not yet supported in Search Conditions for MFExpressionTypeStatusValue" );
							}
							break;
						default:
							throw new Exception( "Expression Type not yet supported in SearchForObjects::" + searchCondition.Expression.Type );
					}  // End Switch ExpressionType
				}  // End iteration of objects
			}  // End iteration of Search Conditions

			//if(SearchFlags != MFSearchFlags.MFSearchFlagNone)
			//    throw new NotImplementedException();

			//List<ObjectVersionAndProperties> objects = vault.ovaps.Where()

			TestObjectSearchResults osr = new TestObjectSearchResults();

			foreach( TestObjectVersionAndProperties testOvap in results )
			{
				osr.Add( testOvap );
			}

			return osr;
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
