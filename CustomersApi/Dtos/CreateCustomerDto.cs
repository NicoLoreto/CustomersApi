using System.ComponentModel.DataAnnotations;

namespace CustomersApi.Dtos
{
    public class CreateCustomerDto
    {

        // Model Binding: proceso de creación de objetos que permite asignar los datos de una peticion http a un modelo. Los valores de la vista se convierten en la clase del modelo cuando alcanza al metodo de la acción.

        [Required (ErrorMessage = "El nombre es obligatorio")]
        public string FirsName { get; set; }
        [Required (ErrorMessage ="El apellido es requerido")]
        public string LastName { get; set; }
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage ="El email no es válido")]
        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

    }
}
