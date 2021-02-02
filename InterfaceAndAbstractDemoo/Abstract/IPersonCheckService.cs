using InterfaceAndAbstractDemoo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractDemoo.Abstract
{
    public interface IPersonCheckService
    {
        void CheckIfRealPerson(Customer customer);
        
    }
}

