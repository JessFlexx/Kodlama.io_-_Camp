using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3._2
{
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri Eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }
}
