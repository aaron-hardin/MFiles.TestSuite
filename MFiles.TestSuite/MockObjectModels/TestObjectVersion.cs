﻿using System;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestObjectVersion : ObjectVersion
    {
	    internal bool checkedOut;
	    internal bool deleted;

		internal TestObjectVersion(bool checkedOut)
		{
			this.checkedOut = checkedOut;
		}

		public TestObjectVersion(ObjectVersion objectVersion)
		{
			this.checkedOut = objectVersion.ObjectCheckedOut;
			this.Title = objectVersion.Title;
			this.ObjVer = objectVersion.ObjVer;
		}

		public TestObjectVersion()
		{

		}

        public DateTime AccessedByMeUtc
        {
            get { throw new NotImplementedException(); }
        }

        public DateTime CheckedOutAtUtc
        {
            get { throw new NotImplementedException(); }
        }

        public int CheckedOutTo
        {
            get { throw new NotImplementedException(); }
        }

        public string CheckedOutToHostName
        {
            get { throw new NotImplementedException(); }
        }

        public string CheckedOutToUserName
        {
            get { throw new NotImplementedException(); }
        }

        public int CheckedOutVersion
        {
            get { throw new NotImplementedException(); }
        }

        public int Class { get; set; }

        public ObjectVersion Clone()
        {
            // TODO: far from comprehensive
            TestObjectVersion clone = new TestObjectVersion { ObjVer = ObjVer.Clone() };
            return clone;
        }

        public DateTime CreatedUtc
        {
            get { throw new NotImplementedException(); }
        }

        public bool Deleted
        {
            get { return deleted; }
        }

        public string DisplayID
        {
            get { throw new NotImplementedException(); }
        }

        public bool DisplayIDAvailable
        {
            get { throw new NotImplementedException(); }
        }

        public ObjectFiles Files
        {
            get { throw new NotImplementedException(); }
        }

        public int FilesCount
        {
            get { throw new NotImplementedException(); }
        }

        public string GetNameForFileSystem(bool includeID = true)
        {
            throw new NotImplementedException();
        }

        public string GetNameForFileSystemEx(bool includeID = true, bool useOriginalID = false)
        {
            throw new NotImplementedException();
        }

        public bool HasAssignments
        {
            get { throw new NotImplementedException(); }
        }

        public bool HasRelationshipsFromThis
        {
            get { throw new NotImplementedException(); }
        }

        public bool HasRelationshipsToThis
        {
            get { throw new NotImplementedException(); }
        }

        public bool HasSharedFiles
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsAccessedByMeValid
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsObjectConflict
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsObjectShortcut
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsStub
        {
            get { throw new NotImplementedException(); }
        }

        public DateTime LastModifiedUtc
        {
            get { throw new NotImplementedException(); }
        }

        public int LatestCheckedInVersion
        {
            get { throw new NotImplementedException(); }
        }

        public bool LatestCheckedInVersionOrCheckedOutVersion
        {
            get { throw new NotImplementedException(); }
        }

        public ObjVer ObjVer { get; set; }

        public bool ObjectCheckedOut
        {
            // TODO: fix this
            get 
			{
				return checkedOut;
			}
        }

        public bool ObjectCheckedOutToThisUser
        {
            get { throw new NotImplementedException(); }
        }

        public MFSpecialObjectFlag ObjectFlags
        {
            get { throw new NotImplementedException(); }
        }

        public string ObjectGUID
        {
            get { throw new NotImplementedException(); }
        }

        public MFObjectVersionFlag ObjectVersionFlags
        {
            get { throw new NotImplementedException(); }
        }

        public ObjID OriginalObjID
        {
            get { throw new NotImplementedException(); }
        }

        public string OriginalVaultGUID
        {
            get { throw new NotImplementedException(); }
        }

        public bool SingleFile
        {
            get { throw new NotImplementedException(); }
        }

        public bool ThisVersionCheckedOut
        {
            get { throw new NotImplementedException(); }
        }

        public bool ThisVersionLatestToThisUser
        {
            get { throw new NotImplementedException(); }
        }

        public string Title { get; set; }

        public string VersionGUID
        {
            get { throw new NotImplementedException(); }
        }

        public bool VisibleAfterOperation
        {
            get { throw new NotImplementedException(); }
        }
    }
}
