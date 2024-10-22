using Microsoft.AspNetCore.Identity;

namespace ProductsAPI.Models
{
    public class AppRole : IdentityRole<int>
    {
        public string FullName { get; set; } = null!;

        public DateTime DateAdded { get; set; }
    }
}