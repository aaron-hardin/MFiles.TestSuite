using System;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
	public class TestLookup : Lookup
	{
		public string GetFormattedDisplayValue( bool Localized, bool EmptyLookupDispValuesAsHidden, bool AddDeletedSuffixIfDeleted )
		{
			throw new NotImplementedException();
		}

		public Lookup Clone()
		{
			TestLookup tLookup = new TestLookup
			{
				Item = Item,
				Version = Version,
				Deleted = Deleted,
				Hidden = Hidden,
				DisplayValue = DisplayValue,
				ObjectType = ObjectType,
				ItemGUID = ItemGUID,
				DisplayID = DisplayID,
				DisplayIDAvailable = DisplayIDAvailable,
				ObjectFlags = ObjectFlags
			};

			return tLookup;
		}

		public int Item { get; set; }
		public int Version { get; set; }
		public bool Deleted { get; set; }
		public bool Hidden { get; private set; }
		public string DisplayValue { get; set; }
		public int ObjectType { get; set; }
		public string ItemGUID { get; set; }
		public string DisplayID { get; private set; }
		public bool DisplayIDAvailable { get; private set; }
		public MFSpecialObjectFlag ObjectFlags { get; private set; }
	}
}
