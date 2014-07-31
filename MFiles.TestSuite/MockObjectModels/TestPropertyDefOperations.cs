using System;
using System.Linq;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestPropertyDefOperations : VaultPropertyDefOperations
    {
        private TestVault vault;

        public TestPropertyDefOperations(TestVault vault)
        {
            this.vault = vault;
        }

        public PropertyDefAdmin AddPropertyDefAdmin(PropertyDefAdmin PropertyDefAdmin, TypedValue ResetLastUsedValue = null)
        {
            // TODO: use arguments
            // TODO: error checking
            this.vault.propertyDefs.Add(PropertyDefAdmin);
            return PropertyDefAdmin;
        }

        public PropertyDef GetBuiltInPropertyDef(MFBuiltInPropertyDef PropertyDefType)
        {
            throw new NotImplementedException();
        }

        public PropertyDef GetPropertyDef(int PropertyDef)
        {
            // TODO: verify functionality
            if(PropertyDef < 0)
                throw new IndexOutOfRangeException("ID out of range");
            PropertyDefAdmin pda = this.vault.propertyDefs.SingleOrDefault(pdef => pdef.PropertyDef.ID == PropertyDef);
            return pda == null ? null : pda.PropertyDef;
        }

        public PropertyDefAdmin GetPropertyDefAdmin(int PropertyDef)
        {
            throw new NotImplementedException();
        }

        public int GetPropertyDefIDByAlias(string Alias)
        {
            try
            {
                // TODO: check all properties that use alias, following does not work
                //return this.vault.propertyDefs.Single(pdef => pdef.SemanticAliases.Value.Contains(Alias)).PropertyDef.ID;
                return this.vault.propertyDefs.Single(pdef => pdef.SemanticAliases.Value.Split(';').Contains(Alias)).PropertyDef.ID;
            }
            catch
            {
                return -1;
            }
        }

        public int GetPropertyDefIDByGUID(string PropertyDefGUID)
        {
            throw new NotImplementedException();
        }

        public PropertyDefs GetPropertyDefs()
        {
            throw new NotImplementedException();
        }

        public PropertyDefsAdmin GetPropertyDefsAdmin()
        {
            throw new NotImplementedException();
        }

        public void RemovePropertyDefAdmin(int PropertyDef, bool CopyToAnotherPropertyDef = false, int TargetPropertyDef = 0, bool Append = false, bool DeleteFromClassesIfNecessary = false)
        {
            throw new NotImplementedException();
        }

        public void UpdatePropertyDefAdmin(PropertyDefAdmin PropertyDefAdmin, TypedValue ResetLastUsedValue = null)
        {
            throw new NotImplementedException();
        }

        public void UpdatePropertyDefWithAutomaticPermissionsAdmin(PropertyDefAdmin PropertyDefAdmin, TypedValue ResetLastUsedValue = null, bool AutomaticPermissionsForcedActive = false)
        {
            throw new NotImplementedException();
        }
    }
}
