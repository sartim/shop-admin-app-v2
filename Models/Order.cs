using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ShopAdminApp.Models
{
    public class Order
    {
        public required string count { get; set; }
        public required string next { get; set; }
        public required string previous { get; set; }
        public required List<OrderDetail> results { get; set; }

        public required string message { get; set; }
    }

    public class OrderDetail
    {
        public required string id { get; set; }
        public required string order_total { get; set; }
        public required string status_id { get; set; }
        public required StatusDetail status { get; set; }
        public required UserDetail user { get; set; }
        public required string created_at { get; set; }
        public required string updated_at { get; set; }
    }
}

