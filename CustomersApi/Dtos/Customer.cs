namespace CustomersApi.Dtos
{
    // Un Dto. son objetos que trasnportan información.
    public class CustomerDto
    {
        // get y set son los geetters y los setters de C# 
        // Sería como tener una propiedad privada en la que set podria modificarla y get devolverla
        // private long _id;
        // set {
        //  _id = value;
        // }
        // get {
        //  return _id;
        // }
        public long id {  get; set; }

        public string FirsName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
        
    }
}
