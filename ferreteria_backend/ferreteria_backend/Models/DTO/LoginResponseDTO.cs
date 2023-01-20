namespace ferreteria_backend.Models.DTO
{
    public class LoginResponseDTO
    {
        public UserDTO _Email { get; set; }

        public string Role { get; set; }
        public string Token { get; set; }
    }
}
