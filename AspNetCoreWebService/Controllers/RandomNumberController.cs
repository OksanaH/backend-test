using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreWebService.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetCoreWebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomNumberController : ControllerBase
    {
        private readonly RandomNumberProvider RandomNumberProvider;

        public RandomNumberController(RandomNumberProvider RandomNumberProvider)
        {
            this.RandomNumberProvider = RandomNumberProvider;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok($"Your random number is {RandomNumberProvider.GetRandomNumber()}");
        }
    }
}
