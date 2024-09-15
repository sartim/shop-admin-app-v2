using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ShopAdminApp.Models
{
    public class Order
    {
        public string count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<OrderDetail> results { get; set; }

        public string message { get; set; }
    }

    public class OrderDetail
    {
        public string id { get; set; }
        public string order_total { get; set; }
        public string status_id { get; set; }
        public StatusDetail status { get; set; }
        public UserDetail user { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
}

