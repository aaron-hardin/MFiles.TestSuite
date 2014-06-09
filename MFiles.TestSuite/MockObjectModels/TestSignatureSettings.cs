using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;
using VaultMockObjects.ComModels;

namespace VaultMockObjects.MockObjectModels
{
    public class TestSignatureSettings : SignatureSettings
    {
        public TestSignatureSettings() { }

        public TestSignatureSettings(xSignatureSettings ss)
        {
            this.AdditionalInfo = ss.AdditionalInfo;
            this.IsRequired = ss.IsRequired;
            this.IsSeparateSignatureObject = ss.IsSeparateSignatureObject;
            this.ManifestationPropertyID = ss.ManifestationPropertyID;
            this.Meaning = ss.Meaning;
            this.Reason = ss.Reason;
            this.SignatureIdentifier = ss.SignatureIdentifier;
        }

        public string AdditionalInfo { get; set; }

        public SignatureSettings Clone()
        {
            TestSignatureSettings ss = new TestSignatureSettings
            {
                AdditionalInfo = this.AdditionalInfo,
                IsRequired = this.IsRequired,
                IsSeparateSignatureObject = this.IsSeparateSignatureObject,
                ManifestationPropertyID = this.ManifestationPropertyID,
                Meaning = this.Meaning,
                Reason = this.Reason,
                SignatureIdentifier = this.SignatureIdentifier
            };
            return ss;
        }

        public bool IsRequired { get; set; }

        public bool IsSeparateSignatureObject { get; set; }

        public string Manifestation { get; set; }

        public int ManifestationPropertyID { get; set; }

        public string Meaning { get; set; }

        public string Reason { get; set; }

        public string SignatureIdentifier { get; set; }
    }
}
