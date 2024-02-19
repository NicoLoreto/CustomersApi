using CustomersApi.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CustomersApi.Controllers
{
    // Para que sea un controlador de la api se agrega un atributo (decorador) ApiController,
    // estos atributos son clases
    // que se pueden enlazar con metodos u otras clases.
    [ApiController]
    // [controller] se traducirá a Customer.
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        // api/customer
        [HttpGet]
        // Task es una clase que representa una operación asincrónica que puede ser ejecutada de forma paralela o en segundo plano.
        // Para devolver codigos de estado se usa IActionResult, nos permite hacer una respuesta con el objeto y status code.
        public async Task<IActionResult> GetCustomers()
        {
            var customers = new List<CustomerDto>();

            var customer = new CustomerDto { Address = "Ituzaingo 1233", FirsName = "Nico", LastName = "Loreto", Email = "nico@gmail.com", Phone = "123332" };

            customers.Add(customer);

            var response = new OkObjectResult(customers);

            return response;
        }

        // api/customer/{id}
        // Dentro del get va la ruta.
        [HttpGet("{id}")]

        // indico el status que va a devolver en caso de obtener una respuesta exitosa e indico el tipo que va a devolver.
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
        // indico el status que va a devolver en caso de obtener una respuesta falida.
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task <IActionResult> GetById(long id)
        {

            return new OkObjectResult(null);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CustomerDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CreateCustomer(CreateCustomerDto customer)
        {
            var NewCustomer = new CustomerDto();
            NewCustomer.Address = customer.Address;
            NewCustomer.FirsName = customer.FirsName;
            NewCustomer.LastName = customer.LastName;
            NewCustomer.Email = customer.Email;
            NewCustomer.Phone = customer.Phone;

            // CreatedResult recibe argumentos, en este caso podemos pasar en la URL donde podemos consultar el objeto que se ha creado junto al recurso.
            // $ delante para agregar variables en un string.
            var response = new CreatedResult($"http://localhost:7235/api/customers/{NewCustomer.id}", NewCustomer);
            return response;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        public async Task<bool> DeleteCustomer(long id)
        {

            return true;
        }

        // Puedo tomar el id de la url o del objeto.
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateCustomer(CustomerController customer)
        {

            return new OkObjectResult(null);
        }



    }
}
