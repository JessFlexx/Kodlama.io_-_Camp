using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar_Csharp_KodlmaIO
{
    class SepetManager
    {
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi : " + urun.Adi);
            Console.WriteLine(urun.Fiyat+"TL");
            Console.WriteLine("Kalan Adet:" + urun.Stokadeti);
            
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokadeti) 
        {
            Console.WriteLine("Sepete Eklendi:" + urunAdi);
            Console.WriteLine("Detay ->" + aciklama);
            Console.WriteLine(fiyat + "TL");
            Console.WriteLine("Kalan stok adeti:"+stokadeti);
        }
    }
}
