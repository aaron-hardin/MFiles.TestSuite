using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using MFiles.TestSuite.ComModels;
using MFilesAPI;
using Newtonsoft.Json;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestVault : Vault
    {
        public IList<ObjectVersionAndProperties> ovaps = new List<ObjectVersionAndProperties>(); 
        public IList<ValueListItem> valueListItems = new List<ValueListItem>(); 
        public IList<ObjTypeAdmin> objTypes = new List<ObjTypeAdmin>();
        public IList<PropertyDefAdmin> propertyDefs = new List<PropertyDefAdmin>();
        public IList<WorkflowAdmin> workflows = new List<WorkflowAdmin>();
        public IList<ObjectClassAdmin> classes = new List<ObjectClassAdmin>();
        public Dictionary<string, NamedValues> namedValues = new Dictionary<string, NamedValues>();

        private VaultObjectOperations objectOperations;
        private VaultClassOperations classOperations;
        private VaultObjectPropertyOperations objectPropertyOperations;
        private VaultValueListItemOperations valueListItemOperations;
        private VaultObjectSearchOperations objectSearchOperations;
        private VaultObjectTypeOperations objectTypeOperations;
        private VaultPropertyDefOperations propertyDefOperations;
        private VaultWorkflowOperations workflowOperations;
        private VaultNamedValueStorageOperations namedValueStorageOperations;

        public TestVault()
        {
            // TODO: setup config
            //string approvalModuleConfigKey = new TaskModule().GetConfigKey();
            //// Load configuration from named value storage.
            //NamedValues namedValues = this.NamedValueStorageOperations.GetNamedValues(
            //    MFNamedValueType.MFConfigurationValue, approvalModuleConfigKey);
            //namedValues["configuration"] = GetDefaultConfiguration(approvalModuleConfigKey);
            //// Put the collection back to the vaule.
            //this.NamedValueStorageOperations.SetNamedValues(MFNamedValueType.MFConfigurationValue, approvalModuleConfigKey, namedValues);

        }

        public static TestVault FromFile(string path)
        {
            using(Stream stream = File.OpenRead(path))
            {
                return FromStream(stream);
            }
        }

        public static TestVault Default()
        {
            
            Assembly assembly = Assembly.GetAssembly(typeof(StructureGenerator));
            string structureJson = typeof(StructureGenerator).Namespace + "." + "VaultStructure.json";
            using (Stream stream = assembly.GetManifestResourceStream(structureJson))
            {
                return FromStream(stream);
            }
        }

        public static TestVault FromStream(Stream stream)
        {
            TestVault testVault = new TestVault();
            using (StreamReader reader = new StreamReader(stream))
            {
                string serialized = reader.ReadToEnd();
                VaultJSON vaultJson = JsonConvert.DeserializeObject<VaultJSON>(serialized);
                List<xObjTypeAdmin> objects = JsonConvert.DeserializeObject<List<xObjTypeAdmin>>(vaultJson.Objects);
                foreach (xObjTypeAdmin obj in objects)
                {
                    testVault.objTypes.Add(new TestObjTypeAdmin(obj));
                }

                List<xPropertyDefAdmin> properties = JsonConvert.DeserializeObject<List<xPropertyDefAdmin>>(vaultJson.Properties);
                foreach (xPropertyDefAdmin pda in properties)
                {
                    testVault.propertyDefs.Add(new TestPropertyDefAdmin(pda));
                }

                List<xObjectClassAdmin> classes = JsonConvert.DeserializeObject<List<xObjectClassAdmin>>(vaultJson.Classes);
                foreach (xObjectClassAdmin oClass in classes)
                {
                    testVault.classes.Add(new TestObjectClassAdmin(oClass));
                }

                List<xObjType> valueLists = JsonConvert.DeserializeObject<List<xObjType>>(vaultJson.ValueLists);
                foreach (xObjType valueList in valueLists)
                {
                    TestObjType ot = new TestObjType(valueList);
                    TestObjTypeAdmin ota = new TestObjTypeAdmin { ObjectType = ot };
                    testVault.objTypes.Add(ota);
                }

                List<xWorkflowAdmin> workflows = JsonConvert.DeserializeObject<List<xWorkflowAdmin>>(vaultJson.Workflows);
                foreach (xWorkflowAdmin workflow in workflows)
                {
                    //testVault.workflows.Add(new TestWorkflowAdmin(workflow));
                    testVault.WorkflowOperations.AddWorkflowAdmin(new TestWorkflowAdmin(workflow));
                }
            }

            return testVault;
        }

        private static string GetDefaultConfiguration(string configKey)
        {
            string basePath = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().IndexOf("NUnitTests"));

            basePath = Path.Combine(basePath, @"MFiles.Modules\Packaging\Debug\M-Files_Modules\DefaultConfiguration");

            // Get the default configuration.
            string moduleDefaultConfigName = configKey + ".Configuration.json";

            string pathToConfig = Path.Combine(basePath, moduleDefaultConfigName);

            // Read the file and push it to the named value storage.
            StreamReader sr = new StreamReader(pathToConfig);
            String configurationData = sr.ReadToEnd();
            return configurationData;
        }

        public ObjectVersionAndProperties GetOvap(ObjVer objVer)
        {
            List<ObjectVersionAndProperties> thisObj =
                this.ovaps.Where(obj => obj.ObjVer.ID == objVer.ID && obj.ObjVer.Type == objVer.Type).ToList();
            if (thisObj.Count == 0)
                return null;
            int lookupVersion = (objVer.Version == -1) ? thisObj.Max(obj => obj.ObjVer.Version) : objVer.Version;
            ObjectVersionAndProperties objectVersionAndProperties = thisObj.SingleOrDefault(obj => obj.ObjVer.Version == lookupVersion);
            
            return objectVersionAndProperties;
        }

        public ObjectVersionAndProperties GetOvap(ObjID objId)
        {
            List<ObjectVersionAndProperties> thisObj =
                this.ovaps.Where(obj => obj.ObjVer.ID == objId.ID && obj.ObjVer.Type == objId.Type).ToList();
            if (thisObj.Count == 0)
                return null;
            int maxVersion = thisObj.Max(obj => obj.ObjVer.Version);
            ObjectVersionAndProperties objectVersionAndProperties = thisObj.SingleOrDefault(obj => obj.ObjVer.Version == maxVersion);
            
            return objectVersionAndProperties;
        }

        public dynamic Async
        {
            get { throw new NotImplementedException(); }
        }

        public void ChangePassword(string OldPassword, string NewPassword)
        {
            throw new NotImplementedException();
        }

        public VaultClassGroupOperations ClassGroupOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultClassOperations ClassOperations
        {
            get { return this.classOperations ?? (this.classOperations = new TestClassOperations(this)); }
        }

        public VaultClientOperations ClientOperations
        {
            get { throw new NotImplementedException(); }
        }

        public void CloneFrom(Vault pIVaultSource)
        {
            throw new NotImplementedException();
        }

        public int CurrentLoggedInUserID
        {
            get { throw new NotImplementedException(); }
        }

        public VaultCustomApplicationManagementOperations CustomApplicationManagementOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultDataSetOperations DataSetOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultElectronicSignatureOperations ElectronicSignatureOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultEventLogOperations EventLogOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultExtensionMethodOperations ExtensionMethodOperations
        {
            get { throw new NotImplementedException(); }
        }

        public bool KeepAlive { get; set; }

        public string GetGUID()
        {
            throw new NotImplementedException();
        }

        public string GetMFilesURLForVaultRoot()
        {
            throw new NotImplementedException();
        }

        public MFilesVersion GetServerVersionOfVault()
        {
            throw new NotImplementedException();
        }

        public void LogOutSilent()
        {
            throw new NotImplementedException();
        }

        public bool LogOutWithDialogs(IntPtr ParentWindow)
        {
            throw new NotImplementedException();
        }

        public bool LoggedIn
        {
            get { throw new NotImplementedException(); }
        }

        public VaultManagementOperations ManagementOperations
        {
            get { throw new NotImplementedException(); }
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public VaultNamedACLOperations NamedACLOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultNamedValueStorageOperations NamedValueStorageOperations
        {
            get { return this.namedValueStorageOperations ?? (this.namedValueStorageOperations = new TestNamedValueStorageOperations(this)); }
        }

        public VaultObjectFileOperations ObjectFileOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultObjectOperations ObjectOperations
        {
            get { return this.objectOperations ?? (this.objectOperations = new TestObjectOperations(this)); }
        }

        public VaultObjectPropertyOperations ObjectPropertyOperations
        {
            get { return this.objectPropertyOperations ?? (this.objectPropertyOperations = new TestObjectPropertyOperations(this)); }
        }

        public VaultObjectSearchOperations ObjectSearchOperations
        {
            get { return this.objectSearchOperations ?? (this.objectSearchOperations = new TestObjectSearchOperations(this)); }
        }

        public VaultObjectTypeOperations ObjectTypeOperations
        {
            get { return this.objectTypeOperations ?? (this.objectTypeOperations = new TestObjectTypeOperations(this)); }
        }

        public VaultPropertyDefOperations PropertyDefOperations
        {
            get { return this.propertyDefOperations ?? (this.propertyDefOperations = new TestPropertyDefOperations(this)); }
        }

        public bool ReadOnlyAccess
        {
            get { throw new NotImplementedException(); }
        }

        public VaultScheduledJobManagementOperations ScheduledJobManagementOperations
        {
            get { throw new NotImplementedException(); }
        }

        public SessionInfo SessionInfo
        {
            get { throw new NotImplementedException(); }
        }

        public void TestConnectionToServer()
        {
            throw new NotImplementedException();
        }

        public void TestConnectionToVault()
        {
            throw new NotImplementedException();
        }

        public void TestConnectionToVaultWithTimeout(int TimeoutInMilliseconds)
        {
            throw new NotImplementedException();
        }

        public VaultTraditionalFolderOperations TraditionalFolderOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultUserGroupOperations UserGroupOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultUserOperations UserOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultUserSettingOperations UserSettingOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultValueListItemOperations ValueListItemOperations
        {
            get { return this.valueListItemOperations ?? (this.valueListItemOperations = new TestValueListItemOperations(this)); }
        }

        public VaultValueListOperations ValueListOperations
        {
            get { throw new NotImplementedException(); }
        }

        public Languages VaultLanguages
        {
            get { throw new NotImplementedException(); }
        }

        public VaultViewOperations ViewOperations
        {
            get { throw new NotImplementedException(); }
        }

        public VaultWorkflowOperations WorkflowOperations
        {
            get { return this.workflowOperations ?? (this.workflowOperations = new TestWorkflowOperations(this)); }
        }
    }
}
