using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestPropertyValues : PropertyValues
    {
        private List<TestPropertyValue> properties = new List<TestPropertyValue>();

        public void Add(int Index, PropertyValue PropertyValue)
        {
            // TODO: how to handle index?
            this.properties.Add((TestPropertyValue)PropertyValue);
        }

        public PropertyValues Clone()
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return this.properties.Count; }
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
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

        public void Remove(int Index)
        {
            throw new NotImplementedException();
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

        public PropertyValue this[int Index]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
