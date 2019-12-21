using System;
using System.Text;
using System.Collections.Generic;
using Mobile.Models;

namespace Mobile.Abstraction
{
    public interface IDataService
    {
        IEnumerable<CustomerModel> GetCustomers();
    }
}
