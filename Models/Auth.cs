using System;
namespace ShopAdminApp.Models
{
    public class AuthRequest
    {
        public required string email { get; set; }
        public required string password { get; set; }
    }

    public class AuthResponse
    {
        public required string access_token { get; set; }
        public required UserDetail user { get; set; }
    }
}

