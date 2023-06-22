using Microsoft.AspNetCore.Identity;

namespace CifrOblako1.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
    }
}
