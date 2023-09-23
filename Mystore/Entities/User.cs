using Microsoft.AspNetCore.Identity;

namespace Mystore.Entities
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

    }
}
