using InterfaceAbstact.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstact.Concreate
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckPerson;
        public StarbucksCustomerManager(ICustomerCheckService customerCheckPerson)
        {
            _customerCheckPerson = customerCheckPerson;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckPerson.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            throw new Exception("Not a valid person");
         
        }

      
    }
}
