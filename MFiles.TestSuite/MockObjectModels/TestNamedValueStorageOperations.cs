using System;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestNamedValueStorageOperations : VaultNamedValueStorageOperations
    {
        private TestVault vault;

        public TestNamedValueStorageOperations(TestVault vault)
        {
            this.vault = vault;
        }

        public NamedValues GetNamedValues(MFNamedValueType NamedValueType, string Namespace)
        {
            // TODO: fix this
            switch (NamedValueType)
            {
                case MFNamedValueType.MFConfigurationValue:
                    if (this.vault.namedValues.ContainsKey(Namespace))
                        return this.vault.namedValues[Namespace];
                    return new NamedValues();
                default:
                    throw new NotImplementedException(string.Format("TestNamedValueStorageOperations::GetNamedValues NamedValueType {0} not yet implemented", NamedValueType));
            }
            return new NamedValues();
            //throw new NotImplementedException();
        }

        public void RemoveNamedValues(MFNamedValueType NamedValueType, string Namespace, Strings NamedValueNames)
        {
            throw new NotImplementedException();
        }

        public void SetNamedValues(MFNamedValueType NamedValueType, string Namespace, NamedValues NamedValues)
        {
            // TODO: fix this
            switch (NamedValueType)
            {
                case MFNamedValueType.MFConfigurationValue:
                    if (this.vault.namedValues.ContainsKey(Namespace))
                    {
                        this.vault.namedValues[Namespace] = NamedValues;
                    }
                    else
                    {
                        this.vault.namedValues.Add(Namespace, NamedValues);
                    }
                    break;
                default:
                    throw new NotImplementedException(string.Format("TestNamedValueStorageOperations::GetNamedValues NamedValueType {0} not yet implemented", NamedValueType));
            }
        }
    }
}
