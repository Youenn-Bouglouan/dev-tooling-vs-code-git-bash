using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DevTooling.Demo.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevTooling.Demo.Core.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public static List<Customer> CustomersStore = new List<Customer>()
        {
            new Customer { Id = 1, Name = "John Doe", Tags = new [] { "VIP", "Swag" }, Address = new Address { City = "London", Country = "England" } }
        };

        [HttpGet]
        public IActionResult Get()
        {
            var allCustomers = CustomersStore;
            return Ok(allCustomers);
        }

        [HttpGet("{customerId}")]
        public IActionResult Get([Required] int customerId)
        {
            var customer = CustomersStore.FirstOrDefault(c => c.Id == customerId);
            if (customer == null)
                return NotFound($"could not find customer '{customerId}'");

            return Ok(customer);
        }

        [HttpPut]
        public IActionResult Create([Required] Customer customer)
        {
            var customerId = CustomersStore.Count + 1;
            customer.Id = customerId;
            CustomersStore.Add(customer);

            return StatusCode(201, $"customer '{customerId}' created");
        }

        [HttpPost("{customerId}/address")]
        public IActionResult UpdateAddress([Required] int customerId, [Required, FromBody] Address updatedAddress)
        {
            var customer = CustomersStore.FirstOrDefault(c => c.Id == customerId);
            if (customer == null)
                return NotFound($"could not find customer '{customerId}'");

            customer.Address = updatedAddress;

            return Ok($"customer's address updated successfully");
        }
    }
}
