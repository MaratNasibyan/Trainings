using System;
using System.Text;
using System.Collections.Generic;
using Mobile.DBMap.Northwind_Models;
using Mobile.Repository.Abstraction;
using System.Linq;

namespace Mobile.Repository.RepositoryCollection
{
    public class DataRepository : IDataRepository
    {
        private readonly NorthwindContext northwindContext;
        
        public DataRepository(NorthwindContext northwindContext)
        {
            this.northwindContext = northwindContext;
        }

        public  IEnumerable<Customers> GetCustomers()
        {
            return northwindContext.Customers.ToList();
        }

    }
}
