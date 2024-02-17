using CustomersApi.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CustomersApi.Controllers
{
    // Para que sea un controlador de la api se agrega un atributo ApiController, estos atributos son clases
    // que se pueden enlazar con metodos u otras clases.
    [ApiController]
    // [controller] se traducirá a Customer
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        // api/customer/{id}
        // Dentro del get va la ruta.
        [HttpGet("{id}")]
        public async Task <CustomerDto> GetById(long id)
        {

            return new CustomerDto();
        }

        // api/customer
        [HttpGet]
        public async Task<List<CustomerDto>> GetCustomers()
        {
            var customer = new CustomerDto { Address = "Ituzaingo 1233", FirsName="Nico", LastName="Loreto", Email="nico@gmail.com", Phone= "123332"};
            return [customer];
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteCustomer(long id)
        {

            return true;
        }

        [HttpPost]
        public async Task<bool> CreateCustomer(CreateCustomerDto customer)
        {

            return true;
        }

        // Puedo tomar el id de la url o del objeto.
        [HttpPut]
        public async Task<bool> UpdateCustomer(CustomerController customer)
        {

            return true;
        }



    }
}
