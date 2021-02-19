using Microsoft.AspNetCore.Mvc;
using Misa8b.CukCuk.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Misa8b.CukCuk.Web.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BanksController : ControllerBase
    {
        IBankBL _bankBL;
        public BanksController(IBankBL bankBL)
        {
            _bankBL = bankBL;
        }
        // GET: api/<BanksController>
        [HttpGet]
        public IActionResult Get()
        {
            var datas = _bankBL.GetAllData();
            switch (datas.MisaCode)
            {
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Success:
                    return Ok(datas);
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Validate:
                    return Ok(datas);
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Error:
                    return Ok(datas);
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Exception:
                    return Ok(datas);
                default:
                    return NoContent();
            }
        }

        // GET api/<BanksController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BanksController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BanksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BanksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
