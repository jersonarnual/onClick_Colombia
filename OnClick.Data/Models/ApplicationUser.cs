using Microsoft.AspNetCore.Identity;

namespace OnClick.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual User? User { get; set; }
    }
}
