using InterfaceAndAbstractDemoo.Abstract;
using InterfaceAndAbstractDemoo.Entities;
using InterfaceAndAbstractDemoo.Adapters;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractDemoo.Concrete
{
    public class StarbucksCustomerManager : Abstract.BaseCustomerManager ,  IPersonCheckService
    {
        IPersonCheckService _personCheckService;
        public StarbucksCustomerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public void CheckIfRealPerson(Customer customer)
        {
            _personCheckService.CheckIfRealPerson(customer);
        }

        public override void Save(Customer customer)
        {
            _personCheckService.CheckIfRealPerson(customer);

        }

        
    }
       
}
