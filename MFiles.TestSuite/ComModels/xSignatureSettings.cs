using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace VaultMockObjects.ComModels
{
    public class xSignatureSettings
    {
        public string AdditionalInfo { get; set; }
        public bool IsRequired { get; set; }
        public bool IsSeparateSignatureObject { get; set; }
        public int ManifestationPropertyID { get; set; }
        public string Meaning { get; set; }
        public string Reason { get; set; }
        public string SignatureIdentifier { get; set; }

        public xSignatureSettings() { }

        public xSignatureSettings(SignatureSettings ss)
        {
            this.AdditionalInfo = ss.AdditionalInfo;
            this.IsRequired = ss.IsRequired;
            this.IsSeparateSignatureObject = ss.IsSeparateSignatureObject;
            this.ManifestationPropertyID = ss.ManifestationPropertyID;
            this.Meaning = ss.Meaning;
            this.Reason = ss.Reason;
            this.SignatureIdentifier = ss.SignatureIdentifier;
        }
    }
}
