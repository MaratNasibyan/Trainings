﻿using Microsoft.AspNetCore.Mvc;
using Mobile.Abstraction;
using Mobile.Models;
using System;
using System.Net;
using System.Net.Http;

namespace Mobile.API.Controllers
{
   
    public class DataController : BaseController
    {
        private readonly IDataService dataService;                

        public DataController(IDataService dataService)
        {
            this.dataService = dataService;
        }

        [HttpGet]
        public IResponse GetCustomers()
        {
            IResponse response;

            try
            {
                var result = this.dataService.GetCustomers();
                
                response = new ResponseSuccess(result);
            }
            catch (Exception ex)
            {
                response = this.GetFailedResponse("Error", ex.Message);
            }          

            return response;
        }

    }
}