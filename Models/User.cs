using System;
using System.Collections.Generic;

namespace ShopAdminApp.Models
{
    public class User
    {
        public required string count { get; set; }

        public required string next { get; set; }

        public required string previous { get; set; }

        public required List<UserDetail> results { get; set; }

    }

    public class UserDetail
    {
        public required string first_name { get; set; }
        public required string last_name { get; set; }
        public required string email { get; set; }
        public required string password { get; set; }
        public required string created_at { get; set; }
        public required string updated_at { get; set; }
    }
}

