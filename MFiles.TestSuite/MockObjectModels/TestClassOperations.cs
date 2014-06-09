using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace VaultMockObjects.MockObjectModels
{
    public class TestClassOperations : VaultClassOperations
    {
        private TestVault vault;
 
        public TestClassOperations(TestVault vault)
        {
            this.vault = vault;
        }

        public ObjectClassAdmin AddObjectClassAdmin(ObjectClassAdmin ObjectClassAdmin)
        {
            // TODO: make functionality comparable to API
            this.vault.classes.Add(ObjectClassAdmin);
            return ObjectClassAdmin;
        }

        public ObjectClasses GetAllObjectClasses()
        {
            throw new NotImplementedException();
        }

        public ObjectClassesAdmin GetAllObjectClassesAdmin()
        {
            throw new NotImplementedException();
        }

        public ObjectClass GetObjectClass(int ObjectClass)
        {
            throw new NotImplementedException();
        }

        public ObjectClassAdmin GetObjectClassAdmin(int Class)
        {
            throw new NotImplementedException();
        }

        public int GetObjectClassIDByAlias(string Alias)
        {
            try
            {
                ObjectClassAdmin classAdmin =
                    this.vault.classes.SingleOrDefault(classy => classy.SemanticAliases.Value.Split(';').Contains(Alias));
                return classAdmin == null ? -1 : classAdmin.ID;
            }
            catch
            {
                return -1;
            }
        }

        public int GetObjectClassIDByGUID(string ObjectClassGUID)
        {
            throw new NotImplementedException();
        }

        public ObjectClasses GetObjectClasses(int ObjectType)
        {
            throw new NotImplementedException();
        }

        public ObjectClassesAdmin GetObjectClassesAdmin(int ObjectType)
        {
            throw new NotImplementedException();
        }

        public void RemoveObjectClassAdmin(int ObjectClassID)
        {
            throw new NotImplementedException();
        }

        public void UpdateObjectClassAdmin(ObjectClassAdmin ObjectClass)
        {
            throw new NotImplementedException();
        }
    }
}
