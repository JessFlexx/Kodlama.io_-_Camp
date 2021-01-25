using System;

namespace Metotlar_Csharp_KodlmaIO
{    //Metotlar tekrar tekrar kullanılabilirliği arttırıyor.
    //Dont repeat yourself.
    class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.Stokadeti = 29 - k;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.Stokadeti = 122 - k;

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Stokadeti);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("----------METODLAR----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun1);

            sepetManager.Ekle2("Armut","Bal Armut",12,15);
            sepetManager.Ekle2("Armut", "Bal olamyan Armut", 15, 12);
            //sepetManager.Ekle2("Elma", "Kel Elma", 12)
            //sepetManager.Ekle2("Elma", "Kel olmayan Elma", 12)
            //Ekle2 bize kızdı.Her sayfayı değiştirmen gerekecek.
            //Bu yüzden bu kullanım dinamik değildir.Hatalıdır.
            //Yukarıda 15 yazdım ama her sayafaya gidip 15 yazamam.
            //Class ları kullanıp yukarıdaki gibi kullanırsam 
            //böyle bir sıkıntı yaşamam.Urun.cs'te mevcut olmalı.

        }
    }
}
