using System;
using System.Collections.Generic;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestPropertyValues : PropertyValues
    {
        private List<TestPropertyValue> properties = new List<TestPropertyValue>();

        public void Add(int Index, PropertyValue propertyValue)
        {
            // TODO: how to handle index?
			TestPropertyValue pval = new TestPropertyValue();
	        pval.PropertyDef = propertyValue.PropertyDef;
	        pval.TypedValue = propertyValue.Value;
            this.properties.Add(pval);
        }

        public PropertyValues Clone()
        {
			TestPropertyValues values = new TestPropertyValues();
	        foreach( TestPropertyValue testPropertyValue in properties )
	        {
		        values.Add( -1, testPropertyValue.Clone() );
	        }
	        return values;
        }

        public int Count
        {
            get { return this.properties.Count; }
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
	        return properties.GetEnumerator();
        }

        public int IndexOf(int PropertyDef)
        {
            for (int i = 0; i < this.properties.Count; i++)
            {
                if (this.properties[i].PropertyDef == PropertyDef)
                    return i;
            }
            return -1;
        }

        public void Remove(int index)
        {
			properties.RemoveAt( index  );
        }

        public PropertyValue SearchForProperty(int PropertyDef)
        {
            for (int i = 0; i < this.properties.Count; i++)
            {
                if (this.properties[i].PropertyDef == PropertyDef)
                    return this.properties[i];
            }
            return null;
        }

		public PropertyValue this[ int index ]
        {
            get
            {
	            return properties[ index ];
            }
            set
            {
				if(index == -1)
				{
					Add( -1, value );
				}
				if(index > properties.Count)
				{
					throw new Exception("Index out of range.");
				}
				if(index == properties.Count)
				{
					Add( -1, value );
				}
				else
				{
					properties.RemoveAt( index );
					Add( -1, value );
				}
            }
        }
    }
}
