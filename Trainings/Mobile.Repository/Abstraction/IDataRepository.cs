using System;
using System.Text;
using System.Collections.Generic;
using Mobile.DBMap.Northwind_Models;

namespace Mobile.Repository.Abstraction
{
    public interface IDataRepository
    {
        IEnumerable<Customers> GetCustomers();
    }
}
