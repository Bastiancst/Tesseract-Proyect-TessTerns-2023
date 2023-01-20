using Microsoft.AspNetCore.Identity;

namespace ferreteria_backend.Models
{
    public class ApplicationUser : IdentityUser
    {
         public string Email { get; set; }
           
    }
}
