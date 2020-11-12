using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebService.Providers
{
    public class RandomNumberProvider
    {
        public string GetRandomNumber()
        {
            Random rnd = new Random();

            return rnd.Next(9999999).ToString();
        }
    }
}
