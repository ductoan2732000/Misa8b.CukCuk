using Microsoft.AspNetCore.Mvc;
using Misa.CukCuk.Common;
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
        [HttpGet("id")]
        public IActionResult Get(Guid id)
        {
            var data = _bankBL.GetDataById(id);
            switch (data.MisaCode)
            {
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Success:
                    return Ok(data);
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Validate:
                    return Ok(data);
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Error:
                    return Ok(data);
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Exception:
                    return Ok(data);
                default:
                    return NoContent();
            }
        }
        [HttpGet("EmployeeId")]
        public IActionResult GetBankByEmployeeId(Guid id)
        {
            var data = _bankBL.GetBankByEmployeeId(id);
            switch (data.MisaCode)
            {
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Success:
                    return Ok(data);
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Validate:
                    return Ok(data);
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Error:
                    return Ok(data);
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Exception:
                    return Ok(data);
                default:
                    return NoContent();
            }
        }

        // POST api/<BanksController>
        [HttpPost]
        public IActionResult Post([FromBody] Bank bank)
        {
            var data = _bankBL.InsertData(bank);
            return Ok(data);
        }

        // PUT api/<BanksController>/5
        [HttpPut]
        public IActionResult Put([FromBody] Bank bank)
        {
            var data = _bankBL.UpdateData(bank);
            switch (data.MisaCode)
            {
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Success:
                    return Ok(data);
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Validate:
                    return Ok(data);
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Error:
                    return Ok(data);
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Exception:
                    return Ok(data);
                default:
                    return NoContent();
            }
        }

        // DELETE api/<BanksController>/5
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            var data = _bankBL.DeleteBank(id);
            switch (data.MisaCode)
            {
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Success:
                    return Ok(data);
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Validate:
                    return Ok(data);
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Error:
                    return Ok(data);
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Exception:
                    return Ok(data);
                default:
                    return NoContent();
            }
        }
        [HttpDelete("id")]
        public IActionResult DeleteDataById(Guid id)
        {
            var data = _bankBL.DeleteBankByEmployeeId(id);
            switch (data.MisaCode)
            {
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Success:
                    return Ok(data);
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Validate:
                    return Ok(data);
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Error:
                    return Ok(data);
                case Misa.CukCuk.Common.Enum.Enumarations.MisaCode.Exception:
                    return Ok(data);
                default:
                    return NoContent();
            }
        }
    }
}
