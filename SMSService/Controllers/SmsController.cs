using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;
using Mitto.SMSService.Models;
using Mitto.SMSService.Providers;

namespace Mitto.SMSService.Controllers
{
    [Route("mitto/[controller]")]
    public class SmsController : Controller
    {
        ILogger logger;
        private readonly ICountryProvider countryProvider;
        public SmsController(ICountryProvider countryProvider, ILoggerFactory loggerFactory)
        {
            //Logger: logs information in console window.
            logger = loggerFactory.CreateLogger("SmsControllerLogger");
            this.countryProvider = countryProvider;
        }

        [HttpGet("countries.json")]
        public IEnumerable<Country> GetCountries()
        {
            logger.LogInformation("GetCountries request received.");
            return countryProvider.GetAllCountries();
        }

        [HttpGet("send.json")]
        public State SendSMS([FromQuery]string from, [FromQuery]string to, [FromQuery]string text)
        {
            logger.LogInformation("SendSMS request received.");
            var smsDetails = string.Format("From: {0}, To: {1}, Message Text: {2}", from, to, text);
            logger.LogInformation("SMS Details: "+ smsDetails);

            return State.Success;
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
