using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendDemo
{
    class CustomerManager : BaseCustomerManager


    {

        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckRealPersonAsync(customer))
            {
                
                base.Save(customer);

                
            }
            else
            {
                throw new Exception("Not a valid person!");
               
            }
        }


    }
}
