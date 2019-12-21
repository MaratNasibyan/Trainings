using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mobile.Abstraction;
using Mobile.Models;

namespace Mobile.API.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class DataController
    {
        private readonly IDataService dataService;

        public DataController(IDataService dataService)
        {
            this.dataService = dataService;
        }

        public IEnumerable<CustomerModel> GetCustomers()
        {
            return this.dataService.GetCustomers();
        }
    }
}