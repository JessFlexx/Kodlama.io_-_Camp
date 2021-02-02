using InterfaceAndAbstractDemoo.Abstract;
using InterfaceAndAbstractDemoo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstractDemoo.Adapters
{
    public class MernisServiceAdapter : IPersonCheckService
    {
        public void CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            
            var temp = client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
            Console.WriteLine(temp);

           



            // return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId),
            //  customer.FirstName.ToUpper(),
            // customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}
