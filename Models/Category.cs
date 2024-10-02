using System.Collections.Generic;

namespace ShopAdminApp.Models
{
    public class Category
    {
        public required string count { get; set; }
        public required string next { get; set; }
        public required string previous { get; set; }
        public required List<CategoryDetail> results { get; set; }

        public required string message { get; set; }
    }

    public class CategoryDetail
    {
        public required string id { get; set; }
        public required string name { get; set; }
        public required string description { get; set; }
        public required string deleted { get; set; }
        public required string created_at { get; set; }
        public required string updated_at { get; set; }
    }
}