using Microsoft.AspNetCore.Identity;

namespace InternshipPlatform_API.Models
{
    public class ExtendUser : IdentityUser
    {

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public Company? Company { get; set; }
    }
}
