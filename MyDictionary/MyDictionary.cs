using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Tkey, Tvalue>
    {
        Tkey[] keyArray;
        Tvalue[] valueArray;

        Tkey[] tempKey;
        Tvalue[] tempValue;

        public MyDictionary()
        {
            keyArray = new Tkey[0];
            valueArray = new Tvalue[0];
        }
        public void Add(Tkey key, Tvalue value)
        {
            tempKey = keyArray;
            tempValue = valueArray;

            keyArray = new Tkey[keyArray.Length + 1];
            valueArray = new Tvalue[valueArray.Length + 1];

            for (int i = 0; i < keyArray.Length-1; i++)
            {
                keyArray[i] = tempKey[i];
            }
            keyArray[keyArray.Length - 1] = key;

            for (int i = 0; i < valueArray.Length-1; i++)
            {
                valueArray[i] = tempValue[i];
            }
            valueArray[valueArray.Length - 1] = value;
        }

        
        public Tkey[] itemkey 
        {
            get { return keyArray; }
        }
        public Tvalue[] itemvalue
        {
            get { return valueArray; }
        }
        public int Length
        {
            get { return keyArray.Length; }
        }

    }

}
