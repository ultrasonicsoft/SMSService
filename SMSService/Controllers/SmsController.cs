using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using SMSService.Models;
using SMSService.Providers;

namespace SMSService.Controllers
{
    [Route("mitto/[controller]")]
    public class SmsController : Controller
    {
        private readonly ICountryProvider countryProvider;
        public SmsController(ICountryProvider countryProvider)
        {
            this.countryProvider = countryProvider;
        }

        [HttpGet("countries.json")]
        public IEnumerable<Country> GetCountries()
        {
            return countryProvider.GetAllCountries();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
