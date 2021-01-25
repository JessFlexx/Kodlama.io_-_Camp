using System;

namespace KodlamaIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string ktgr = "Kategoriler";
            int stdntcount = 32000;
            double faiz = 1.45;
            bool login = true;
            double tdy = 7.45;
            double ystdy = 7.45;

            // Console.WriteLine(ktgr);

            if (tdy>ystdy)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if(ystdy>tdy)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }

            if (login == true)
            {
                Console.WriteLine("Ayarlar,Profil,Dersler");
                Console.WriteLine(ktgr);
            }
            else
            {
                Console.WriteLine("Giris yapınız!");
            }


        }
    }
}
