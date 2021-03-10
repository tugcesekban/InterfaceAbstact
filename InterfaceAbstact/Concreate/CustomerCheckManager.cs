using InterfaceAbstact.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstact.Concreate
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
