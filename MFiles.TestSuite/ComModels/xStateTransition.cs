using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace VaultMockObjects.ComModels
{
    public class xStateTransition
    {
        public xAccessControlList AccessControlList { get; set; }
        public int FromState { get; set; }
        public xSignatureSettings SignatureSettings { get; set; }
        public int ToState { get; set; }

        public xStateTransition() { }

        public xStateTransition(StateTransition st)
        {
            this.AccessControlList = new xAccessControlList(st.AccessControlList);
            this.FromState = st.FromState;
            this.SignatureSettings = new xSignatureSettings(st.SignatureSettings);
            this.ToState = st.ToState;
        }
    }
}
