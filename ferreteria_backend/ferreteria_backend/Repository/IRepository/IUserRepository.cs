using ferreteria_backend.Models;
using ferreteria_backend.Models.DTO;

namespace ferreteria_backend.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string Email);

        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<UserDTO> Register(RegisterationRequestDTO registerationRequestDTO);
    }
}
