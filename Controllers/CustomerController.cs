using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace photo_fs_api.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public string GetCustomers()
        {
            return "deneee";
        }

    }
}