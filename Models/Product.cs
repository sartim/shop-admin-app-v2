using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ShopAdminApp.Models
{
    public class Product
	{
        public required string count { get; set; }

        public required string next { get; set; }

        public required string previous { get; set; }

        public required List<ProductDetail> results { get; set; }
       
    }

    public class ProductDetail
    {
        public required string name { get; set; }

        public required string image_urls { get; set; }

        //public CategoryDetail category { get; set; }

        public required string brand { get; set; }

        public required string price { get; set; }

        public required string created_at { get; set; }

        public required string updated_at { get; set; }
    }
}

