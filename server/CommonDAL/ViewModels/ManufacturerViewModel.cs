using System;
using System.Collections.Generic;
using System.Text;

namespace CommonDAL.ViewModels
{
   public class ManufacturerViewModel
    {
        public long? Id { get; set; }
        public int OrganizationId { get; set; }
        public int ShopId { get; set; }
        public string Name { get; set; }
        public string ManufacturerNo { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte Status { get; set; }
    }
    public class ManufacturerDetailsViewModel: ManufacturerViewModel
    {
        public string CreatedByName { get; set; }
        public string ModifiedByName { get; set; }
        public string CreatedDateString { get; set; }
        public string ModifiedDateString { get; set; }
    }
}
