using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace VaultMockObjects.ComModels
{
    public class xAccessControlEntryContainer
    {
        public bool IsEmpty { get; set; }

        public xAccessControlEntryContainer(AccessControlEntryContainer aclEntryContainer)
        {
            if (aclEntryContainer == null)
                return;
            this.IsEmpty = aclEntryContainer.IsEmpty;
        }
    }
}
