using Microsoft.AspNetCore.Mvc;
using Mobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile.API.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class BaseController : ControllerBase
    {

        #region Response

        public IResponse GetFailedResponse(string developerErrorMessage, string friendlyErrorMessage)
        {
            return new ResponseError
            {
                Status = new ErrorStatus
                {
                    Success = false,
                    DeveloperErrorMessage = developerErrorMessage,
                    FriendlyErrorMessage = friendlyErrorMessage
                }
            };
        }

        #endregion
    }
}
