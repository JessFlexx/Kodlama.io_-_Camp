using InterfaceAndAbstractDemoo.Abstract;
using InterfaceAndAbstractDemoo.Entities;
using InterfaceAndAbstractDemoo.Concrete;
using InterfaceAndAbstractDemoo.Adapters;

using System;

namespace InterfaceAndAbstractDemoo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            BaseCustomerManager customerManager1 = customerManager;
            customerManager1.Save(new Customer()
            {
                FirstName = "Talha",
                LastName = "Aydın",
                NationalityId = "12312312312",
                DateOfBirth = new DateTime(1900, 5, 22)
            });
            Console.ReadLine();
        }
    }
}
