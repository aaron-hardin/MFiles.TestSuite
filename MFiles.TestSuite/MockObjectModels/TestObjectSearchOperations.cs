using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestObjectSearchOperations : VaultObjectSearchOperations
    {
        private TestVault vault;

        public TestObjectSearchOperations(TestVault vault)
        {
            this.vault = vault;
        }

        public ObjectVersionFile FindFile(string RelativePath, bool UpdateFromServer = false)
        {
            throw new NotImplementedException();
        }

        public ObjectVersionAndProperties FindObjectVersionAndProperties(string RelativePath, bool UpdateFromServer = false)
        {
            throw new NotImplementedException();
        }

        public ObjectSearchResults GetObjectsInPath(string RelativePath, bool SortResults, bool UpdateFromServer = false)
        {
            throw new NotImplementedException();
        }

        public bool IsObjectPathInMFiles(string RelativePath)
        {
            throw new NotImplementedException();
        }

        public ObjectSearchResults SearchForObjectsByCondition(SearchCondition SearchCondition, bool SortResults)
        {
            throw new NotImplementedException();
        }

        public ObjectSearchResults SearchForObjectsByConditions(SearchConditions SearchConditions, MFSearchFlags SearchFlags, bool SortResults)
        {
            throw new NotImplementedException();
        }

        public ObjectSearchResults SearchForObjectsByConditionsEx(SearchConditions SearchConditions, MFSearchFlags SearchFlags, bool SortResults, int MaxResultCount = 500, int SearchTimeoutInSeconds = 60)
        {
            throw new NotImplementedException();

            //if(SearchFlags != MFSearchFlags.MFSearchFlagNone)
            //    throw new NotImplementedException();

            //List<ObjectVersionAndProperties> objects = vault.ovaps.Where()
        }

        public XMLSearchResult SearchForObjectsByConditionsXML(SearchConditions SearchConditions, bool SortResults)
        {
            throw new NotImplementedException();
        }

        public ObjectSearchResults SearchForObjectsByExportedSearchConditions(string ExportedSearchString, bool SortResults)
        {
            throw new NotImplementedException();
        }

        public XMLSearchResult SearchForObjectsByExportedSearchConditionsXML(string SearchString, bool SortResults)
        {
            throw new NotImplementedException();
        }

        public ObjectSearchResults SearchForObjectsByString(string SearchString, bool SortResults, MFFullTextSearchFlags FullTextSearchFlags)
        {
            throw new NotImplementedException();
        }
    }
}
