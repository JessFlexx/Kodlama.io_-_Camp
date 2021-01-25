using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "Talha";
            int yas = 20;
            
            Kurs kurs1 = new Kurs();
            
            kurs1.KursAdi = "C# Eğitimi";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();

            kurs2.KursAdi = "Java Eğitimi";
            kurs2.Egitmen = "Kerem Emiroğlu";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();

            kurs3.KursAdi = "Pyhton Eğitimi";
            kurs3.Egitmen = "Melis Karabakan";
            kurs3.IzlenmeOrani = 78;

            Console.WriteLine(kurs1.KursAdi + " :" + kurs1.Egitmen);

            

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var x in kurslar)
            {
                Console.WriteLine(x.KursAdi + " ->"+ x.Egitmen + "  " + 
                    "İzlenme Orani= %" + x.IzlenmeOrani);
            }
        }
    }



    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}

