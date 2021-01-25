using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<double,string> myDictionary1 = new MyDictionary<double,string>();
            myDictionary1.Add(1.25, "Su");
            myDictionary1.Add(1.00, "Ekmek");
            myDictionary1.Add(2.00, "Gofret");
            myDictionary1.Add(60.50, "1 kg Et");
            myDictionary1.Add(10.25, "1 kg Muz");

            for (int i = 0; i < myDictionary1.Length; i++)
            {
                Console.WriteLine(myDictionary1.itemvalue[i]+" "+myDictionary1.itemkey[i]+" TL");
            }


        }
    }
}
