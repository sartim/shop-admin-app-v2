using System;
using System.Collections.Generic;

namespace ShopAdminApp.Models
{
	public class Status
	{
        public required string count { get; set; }
        public required string next { get; set; }
        public required string previous { get; set; }
        public required List<StatusDetail> results { get; set; }

        public string message { get; set; }
    }

    public class StatusDetail
    {
        public required string id { get; set; }
        public required string name { get; set; }
        public required string description { get; set; }
        public required string created_at { get; set; }
        public required string updated_at { get; set; }
    }
}

