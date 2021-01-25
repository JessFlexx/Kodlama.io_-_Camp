using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Halil", "Kerem" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; //Önceki (101)stringi bıraktık yeni bir (102)string oluştu
            //isimler[4] = "İlker";     //101 belleği ile bağlantıyı kopardık 102 yi kullanıyoruz 0,1,2,3 boş 4te ilker var
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]); //Engini yazmaaycak sadece ilkeri yazar

            //Koleksiyonlar bu konuda yardımcı olacak genelde
            //array kullanılmaz koleksiyonlar kullanılır
            
            List<string> isimler2 = new List<string>() { "Engin", "Murat", "Halil", "Kerem" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
