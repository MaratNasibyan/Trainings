using Mobile.Abstraction;
using Mobile.Models;
using Mobile.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.BusinessLogic.Services
{
    public class DataService : IDataService
    {
        private readonly IDataRepository dataRepository; 

        public DataService(IDataRepository dataRepository)
        {
            this.dataRepository = dataRepository;
        }

        public IEnumerable<CustomerModel> GetCustomers()
        {
            List<CustomerModel> customers = new List<CustomerModel>();

            var results = this.dataRepository.GetCustomers();

            if (results != null)
            {
                foreach (var result in results)
                {
                    customers.Add(new CustomerModel
                    {
                        Address = result.Address,
                        City = result.City,
                        CompanyName = result.CompanyName,
                        ContactName = result.ContactName,
                        ContactTitle = result.ContactTitle,
                        Country = result.Country,
                        CustomerId = result.CustomerId,
                        Fax = result.Fax,
                        Phone = result.Phone,
                        PostalCode = result.PostalCode,
                        Region = result.Region
                    });
                }               
            }               

            return customers;
        }
    }
}
