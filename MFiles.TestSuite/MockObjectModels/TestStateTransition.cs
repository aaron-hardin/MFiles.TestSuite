using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;
using VaultMockObjects.ComModels;

namespace VaultMockObjects.MockObjectModels
{
    public class TestStateTransition : StateTransition
    {
        public TestStateTransition() { }

        public TestStateTransition(xStateTransition st)
        {
            this.AccessControlList = new TestAccessControlList(st.AccessControlList);
            this.FromState = st.FromState;
            this.SignatureSettings = new TestSignatureSettings(st.SignatureSettings);
            this.ToState = st.ToState;
        }

        public AccessControlList AccessControlList { get; set; }

        public StateTransition Clone()
        {
            TestStateTransition st = new TestStateTransition
            {
                AccessControlList = this.AccessControlList.Clone(),
                FromState = this.FromState,
                SignatureSettings = this.SignatureSettings.Clone(),
                ToState = this.ToState
            };
            return st;
        }

        public int FromState { get; set; }

        public SignatureSettings SignatureSettings { get; set; }

        public int ToState { get; set; }
    }
}
