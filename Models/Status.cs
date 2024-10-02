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

        public string? message { get; set; }
    }

    public class StatusDetail
    {
        public string? id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public string? created_at { get; set; }
        public string? updated_at { get; set; }
    }
}

