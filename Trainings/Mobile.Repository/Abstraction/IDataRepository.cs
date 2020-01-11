using Mobile.DBMap.Northwind_Models;
using System.Collections.Generic;

namespace Mobile.Repository.Abstraction
{
    public interface IDataRepository
    {
        IEnumerable<Customers> GetCustomers();
    }
}
