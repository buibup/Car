using Car.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Data.EntityModels
{
    public class Personal : BaseEntity
    {
        public int TitleId { get; set; }
        public Title Title { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MobilePhoneNo { get; set; }
        public int ProspectId { get; set; }
        public Prospect Prospect { get; set; }
        public int SourceId { get; set; }
        public Source Source { get; set; }
        public string BaseModelCode { get; set; }
        public GenderType GenderType { get; set; }
        public int CustomerGroupId { get; set; }
        public CustomerGroup CustomerGroup { get; set; }
        public string Email { get; set; }
        public string SalesPersonCode { get; set; }
        public DateTime AssignDate { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
