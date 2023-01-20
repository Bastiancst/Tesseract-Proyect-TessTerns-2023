using Azure.Identity;

namespace ferreteria_backend.Models.DTO
{
    public class RegisterationRequestDTO
    {
        public string Email { get; set ;}

        public string Password { get; set; }

        public string Role { get; set; }
        

    }
}
