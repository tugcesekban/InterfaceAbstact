using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstact.Abstracts
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
