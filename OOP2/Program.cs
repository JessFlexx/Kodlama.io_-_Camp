using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer0 = new Customer();
            //customer1.FirstName = "Engin";
            //customer1.LastName = "Demiroğ";
            //customer1.Id = 1;
            //customer1.CitizenshipNum =" 122222222222";
            //customer1.CustomerNumber = "10001";
            //customer1.CompanyName = "?";//Bu kişinin şirketi yok alakasız eşleştirme.
            //Aynı class altında değerlendiremeyiz.
            //Gerçek-Bireysel müşteri -Tüzel müşteri ikiside müşteri ama farklı tipte müşteri.
            //individual customer - corporate customer
            GercekMusteri customer1 = new GercekMusteri();
            customer1.CustomerNum = "12345";
            customer1.Id = 1;
            customer1.FirstName = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.CitizenshipNum = "122222222222";

            TuzelMusteri customer2 = new TuzelMusteri();
            customer2.CustomerNum = "123123";
            customer2.Id = 2;
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNum = "122345";

            Customer customer3 = new GercekMusteri();
            Customer customer4 = new TuzelMusteri();



        }
    }
}
