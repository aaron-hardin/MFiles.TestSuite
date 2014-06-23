using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFiles.TestSuite.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite
{
    public class StructureGenerator
    {
        public static void VaultToJsonFile(Vault vault, string path)
        {
            string json = VaultToJson(vault);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(json);
            }
        }

        public static string VaultToJson(Vault vault)
        {
            VaultJSON jsonObject = DeserializedVault(vault);
            return Newtonsoft.Json.JsonConvert.SerializeObject(jsonObject);
        }

        public static VaultJSON DeserializedVault(Vault vault)
        {
            var vaultJson = new VaultJSON
            {
                Objects = VaultSerializer.Objects(vault),
                Classes = VaultSerializer.Classes(vault),
                Properties = VaultSerializer.Properties(vault),
                ValueLists = VaultSerializer.ValueLists(vault),
                Workflows = VaultSerializer.Workflows(vault)
            };

            return vaultJson;
        }
    }
}
