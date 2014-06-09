using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace VaultMockObjects.VaultExtensions
{
    /// <summary>
    /// Defines convenience methods for the Lookups interface.
    /// </summary>
    public static class LookupExtensionMethods
    {
        public static ObjVer GetAsObjVer(this Lookup lookup, Vault vault)
        {
            int version = lookup.Version;
            if (version == -1)
            {
                return vault.ObjectOperations.GetLatestObjVer(new ObjID { ID = lookup.Item, Type = lookup.ObjectType }, true, true);
            }
            ObjVer objver = new ObjVer();
            objver.SetIDs(lookup.ObjectType, lookup.Item, lookup.Version);
            return objver;
        }

        public static ObjID GetAsObjID(this Lookup lookup)
        {
            return new ObjID { ID = lookup.Item, Type = lookup.ObjectType };
        }

        public static ObjectVersion GetAsObjectVersion(this Lookup lookup, Vault vault, bool latestVersion)
        {
            return vault.ObjectOperations.GetObjectInfo(lookup.GetAsObjVer(vault), latestVersion, true);
        }

    }
}
