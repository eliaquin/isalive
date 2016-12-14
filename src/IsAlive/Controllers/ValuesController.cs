using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IsAlive.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public async Task<bool> Get()
        {
            try
            {
                Solicitud s = new Solicitud();
                var r = await s.HacerRequest();
                return r;
            }
            catch (Exception)
            {

                return false;
            }
        }      
    }
}
