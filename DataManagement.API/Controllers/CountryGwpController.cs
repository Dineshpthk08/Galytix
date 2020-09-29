using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataManagement.Business.Interfaces;
using DataManagement.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DataManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryGwpController : Controller
    {
        IGwpManager _gwpManager;
        public CountryGwpController(IGwpManager gwpManager)
        {
            _gwpManager = gwpManager;
        }

        // POST api/user  
        [HttpGet]
        public IList<Gwp> GetGwpAvg([FromRoute] string Country, string lineOfBusiness)
        {
            return _gwpManager.GetGwpAvg(Country, lineOfBusiness);
        }
    }
}