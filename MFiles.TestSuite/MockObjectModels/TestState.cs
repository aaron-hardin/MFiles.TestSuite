using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
	public class TestState : State
	{
		internal TestState(TestStateAdmin sa)
		{
			ID = sa.ID;
			Name = sa.Name;
		}

		public Lookup GetAsLookup()
		{
			TestLookup tLookup = new TestLookup
			{
				Item = ID,
				ObjectType = ( int ) MFBuiltInValueList.MFBuiltInValueListStates,
				DisplayValue = Name
			};

			// TODO: implement remaining fields

			return tLookup;
		}

		public TypedValue GetAsTypedValue()
		{
			TestTypedValue tv = new TestTypedValue
			{
				DisplayValue = Name,
				DataType = MFDataType.MFDatatypeLookup,
				Value = ID
			};

			// TODO: implement remaining fields
			// TODO: verify correctness

			return tv;
		}

		public int ID { get; private set; }
		public string Name { get; set; }
		public bool Selectable { get; set; }
		public bool SelectableFlagAffectedByPseudoUsers { get; set; }
	}
}
