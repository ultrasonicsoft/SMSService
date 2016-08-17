﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SMSService.Controllers
{
    [Route("api/[controller]")]
    public class Test : Controller
    {
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            return new List<string> { "jai", "ganesh" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value" + id;
        }
    }
}
