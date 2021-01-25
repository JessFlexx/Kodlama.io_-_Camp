using System;

namespace KodlamaIO_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string k1 = "Geliştirme Kampı";
            string k2 = "Temel Kurs";
            string k3 = "Java Kursu";
            
            //DİNAMİKLEŞTİRME
            string[] kurslar = new string[] { k1, k2, k3 };
                                //length dinamikleştirme
            for (int i = 0; i < kurslar.Length ; i+=1)
            {
                Console.WriteLine("###" + i + "###");
                Console.WriteLine(i + "->" + kurslar[i]);
            }

            foreach ( string asdasdas in kurslar)
            {
                Console.WriteLine("\n" + asdasdas);
            }
        }
    }
}
