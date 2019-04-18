using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Car.Services.Interfaces;
using Car.Services.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Car.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerAppService _customerAppService;
        public CustomersController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        [HttpPost("RegisterCustomer")]
        public IActionResult RegisterCustomer(CustomerViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.CustomerGuid = Guid.NewGuid();
                model.CreatedDate = DateTime.Now;

                _customerAppService.Register(model);

                return Ok();
            }

            return BadRequest();
        }

        [HttpGet("GetCustomerByGuid/{guid}")]
        public IActionResult GetCustomerByGuid(Guid guid)
        {
            var result = _customerAppService.GetByGuid(guid);

            if (result == null) return NotFound();

            return Ok(result);
        }

        [HttpGet("GetCustomers/{pageNumber:int}/{pageSize:int}")]
        public async Task<IActionResult> GetCustomers(int pageNumber, int pageSize)
        {
            var result = await _customerAppService.GetCustomers(pageNumber, pageSize);

            if (result == null) return NotFound();

            return Ok(result);
        }
    }
}