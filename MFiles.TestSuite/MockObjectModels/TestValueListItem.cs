using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
	public class TestValueListItem : ValueListItem
	{
		public byte [] GetIconAsPNG( int Width, int Height )
		{
			throw new NotImplementedException();
		}

		public TestValueListItem(ValueListItem vli)
		{
			ID = vli.ID;
			ValueListID = vli.ValueListID;
			Name = vli.Name;
			HasParent = vli.HasParent;
			ParentID = vli.ParentID;
			HasOwner = vli.HasOwner;
			OwnerID = vli.OwnerID;
			DisplayID = vli.DisplayID;
			DisplayIDAvailable = vli.DisplayIDAvailable;
			ACLForObjects = vli.ACLForObjects;
			Icon = vli.Icon;
			AutomaticPermissionsForObjects = vli.AutomaticPermissionsForObjects;
			ItemGUID = vli.ItemGUID;
			Deleted = vli.Deleted;
		}

		public ValueListItem Clone()
		{
			throw new NotImplementedException();
		}

		public int ID { get; set; }
		public int ValueListID { get; set; }
		public string Name { get; set; }
		public bool HasParent { get; set; }
		public int ParentID { get; set; }
		public bool HasOwner { get; set; }
		public int OwnerID { get; set; }
		public string DisplayID { get; private set; }
		public bool DisplayIDAvailable { get; private set; }
		public AccessControlList ACLForObjects { get; set; }
		public byte [] Icon { get; set; }
		public AutomaticPermissions AutomaticPermissionsForObjects { get; set; }
		public string ItemGUID { get; private set; }
		public bool Deleted { get; private set; }
	}
}
