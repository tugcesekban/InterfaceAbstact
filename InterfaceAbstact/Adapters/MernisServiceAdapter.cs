using InterfaceAbstact.Abstracts;
using MernisServiceReference;
using System;

namespace InterfaceAbstact.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {


            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId),
                                                 customer.FirstName.ToUpper(),
                                                 customer.LastName.ToUpper(),
                                                 customer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
