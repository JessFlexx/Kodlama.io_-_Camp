using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3._2
{
    class EmplpyeeManager : IPersonManager
    {
        public void Add()
        {
            //Çalışan ekleme kodları
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi.");
        }
    }
}
