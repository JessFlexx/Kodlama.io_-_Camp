using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendDemo
{
    public interface ICustomerCheckService
    {
        bool CheckRealPersonAsync(Customer customer);
    }
}
