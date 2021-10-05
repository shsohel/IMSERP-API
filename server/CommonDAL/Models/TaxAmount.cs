﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CommonDAL.Models
{
    public class TaxAmount
    {
        public long Id { get; set; }
        public int TaxId { get; set; }
        public int OrganizationId { get; set; }
        public int ShopId { get; set; }
        public decimal Amount { get; set; }
        public bool IsPercent { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool IsCurrent { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte Status { get; set; }
    }
}
