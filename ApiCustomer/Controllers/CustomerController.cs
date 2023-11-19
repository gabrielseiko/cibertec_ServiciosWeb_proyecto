using ApiCustomer.Models;
using ApiCustomer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiCustomer.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;   
        }


        [HttpGet]
        [Route("GetCustomers")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            return StatusCode(StatusCodes.Status200OK, await customerRepository.GetCustomers());
        }

        [HttpGet]
        [Route("GetCustomers/page/{page}/size/{size}")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers(int page, int size)
        {
            return StatusCode(StatusCodes.Status200OK, await customerRepository.GetCustomers(page, size));
        }

        [HttpGet]
        [Route("GetCustomerById/{idCustomer}")]
        public async Task<ActionResult<Customer>> GetCustomerById(int idCustomer)
        {
            return StatusCode(StatusCodes.Status200OK, await customerRepository.GetCustomerById(idCustomer));
        }

        [HttpPost]
        [Route("CreateCustomer")]
        public async Task<ActionResult<Customer>> CreateCustomer(Customer customer)
        {
            return StatusCode(StatusCodes.Status201Created, await customerRepository.CreateCustomer(customer));
        }

        [HttpPut]
        [Route("UpdateCustomer")]
        public async Task<ActionResult<Customer>> UpdateCustomer(Customer customer)
        {
            return StatusCode(StatusCodes.Status200OK, await customerRepository.UpdateCustomer(customer));
        }

        [HttpDelete]
        [Route("DeleteCustomer")]
        public async Task<ActionResult<bool>> DeleteCustomer(int idCustomer)
        {
            return StatusCode(StatusCodes.Status200OK, await customerRepository.DeleteCustomer(idCustomer));
        }
    }
}
