using System;
using System.Collections.Generic;
using System.Linq;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestObjectTypeOperations : VaultObjectTypeOperations
    {
        private TestVault vault;

        public TestObjectTypeOperations(TestVault vault)
        {
            this.vault = vault;
        }

        public ObjTypeAdmin AddObjectTypeAdmin(ObjTypeAdmin ObjectType)
        {
            if (ObjectType.ObjectType.RealObjectType)
            {
                throw new NotImplementedException();
            }
            else
            {
                this.vault.objTypes.Add(ObjectType);
                return ObjectType;
            }
        }

        public ObjType GetBuiltInObjectType(MFBuiltInObjectType ObjectType)
        {
            throw new NotImplementedException();
        }

        public ObjType GetObjectType(int ObjectType)
        {
            List<ObjTypeAdmin> objectTypes = vault.objTypes.Where(obj => obj.ObjectType.ID == ObjectType).ToList();
            if(objectTypes.Count > 1)
                throw new Exception("hi");
            ObjTypeAdmin ota = vault.objTypes.SingleOrDefault(obj => obj.ObjectType.ID == ObjectType);
            return ota == null ? null : ota.ObjectType;
        }

        public ObjTypeAdmin GetObjectTypeAdmin(int ObjectType)
        {
            throw new NotImplementedException();
        }

        public int GetObjectTypeIDByAlias(string Alias)
        {
            // TODO: check that i did not do "obj.SemanticAliases.Value.Contains(Alias)" anywhere, thats not correct...not sure how many times i did that
            try
            {
                return this.vault.objTypes
                    .Single(obj => obj.SemanticAliases != null 
                    && obj.SemanticAliases.Value.Split(';').Contains(Alias)).ObjectType.ID;
            }
            catch
            {
                return -1;
            }
        }

        public int GetObjectTypeIDByGUID(string ObjectTypeGUID)
        {
            throw new NotImplementedException();
        }

        public ObjTypes GetObjectTypes()
        {
            throw new NotImplementedException();
        }

        public ObjTypesAdmin GetObjectTypesAdmin()
        {
            throw new NotImplementedException();
        }

        public void RefreshExternalObjectType(int ObjectType, MFExternalDBRefreshType RefreshType)
        {
            throw new NotImplementedException();
        }

        public void RemoveObjectTypeAdmin(int ObjectTypeID)
        {
            throw new NotImplementedException();
        }

        public ObjTypeAdmin UpdateObjectTypeAdmin(ObjTypeAdmin ObjectType)
        {
            throw new NotImplementedException();
        }

        public ObjTypeAdmin UpdateObjectTypeWithAutomaticPermissionsAdmin(ObjTypeAdmin ObjectType, bool AutomaticPermissionsForcedActive = false)
        {
            throw new NotImplementedException();
        }
    }
}
