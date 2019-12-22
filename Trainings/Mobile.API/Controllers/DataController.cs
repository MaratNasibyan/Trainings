using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Mobile.Abstraction;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
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

        [HttpGet]
        public Response<IEnumerable<CustomerModel>> GetCustomers()
        {
            var result = this.dataService.GetCustomers();

            Response<IEnumerable<CustomerModel>> response = new Response<IEnumerable<CustomerModel>>(result);

            return response;
        }
    }
}