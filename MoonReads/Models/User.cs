using Microsoft.AspNetCore.Identity;

namespace MoonReads.Models
{
    public class User : IdentityUser
    {
        public string? Description { get; set; }
        public string? Avatar { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}

