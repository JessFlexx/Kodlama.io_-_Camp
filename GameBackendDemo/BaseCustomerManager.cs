using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendDemo
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {

            

            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Kayıt işlemi başarılı.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Bilgileriniz başarıyla güncellendi.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Silme işlemi başarıyla gerçekleşti.");
        }
    }
}
