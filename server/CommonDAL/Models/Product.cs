﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CommonDAL.Models
{
    public class Product
    {
        public long Id { get; set; }
        public int OrganizationId { get; set; }
        public int ShopId { get; set; }
        public string ProductNo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte Status { get; set; }
    }
}
