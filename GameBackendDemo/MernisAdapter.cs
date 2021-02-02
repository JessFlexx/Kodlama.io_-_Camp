using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendDemo
{
    class MernisAdapter : ICustomerCheckService
    {
        public bool CheckRealPersonAsync(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName, customer.LastName, customer.DateOfBirth.Year).Result;
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
