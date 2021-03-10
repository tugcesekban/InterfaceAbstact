using InterfaceAbstact.Abstracts;
using InterfaceAbstact.Adapters;
using InterfaceAbstact.Concreate;
using System;

namespace InterfaceAbstact
{
    class Program
    {
        static void Main(string[] args)
        {
            // BaseCustomerManager customerManager = new NeroCustomerManager();
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1990, 1, 6), FirstName = "Ali", LastName = "Veli", NationalityId = "11111111111" });
            Console.ReadLine();
        }
    }
}
