using System;

namespace ClassYapısıÖdev
{
    class Program
    {
        static void Main(string[] args)
        {

            Products p1 = new Products();
            {
                p1.UrunAdi = "Bianchi 126 Jant Bisiklet";
                p1.UrunKodu = 112200;
                p1.UrunFiyat = 450;
        }
            Products p2 = new Products();
            {
                p2.UrunAdi = "Kinetix Roha Camo Erkek Çocuk Haki Kışlık Bot";
                p2.UrunKodu = 112244;
                p2.UrunFiyat = 120;
            }
            Products p3 = new Products();
            {
                p3.UrunAdi = "HUMMEL Hmldarirel Unisex Sırt Çantası";
                p3.UrunKodu = 113300;
                p3.UrunFiyat = 80;
            }
            Products p4 = new Products();
            {
                p4.UrunAdi = "Ricardo Led Dijital Çift Kol Saati";
                p4.UrunKodu = 125550;
                p4.UrunFiyat = 150;
            }

            Products[] Products_Array = new Products[] { p1, p2, p3, p4 };

            foreach (var x in Products_Array)
            {
                Console.WriteLine(x.UrunKodu + "--> " + x.UrunAdi + "= "+ x.UrunFiyat + " TL \n");

            }

        }
    }

    class Products
    {

        public string UrunAdi { get; set; }

        public int UrunKodu { get; set; }

        public int UrunFiyat { get; set; }
    }
}
