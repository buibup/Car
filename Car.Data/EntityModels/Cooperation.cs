using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Data.EntityModels
{
    public class Cooperation : BaseEntity
    {
        public string CompanyName { get; set; }
        public string ContactPerson  { get; set; }
        public string MobilePhoneNo { get; set; }
        public string Fax { get; set; }
        public int ProspectId { get; set; }
        public Prospect Prospect  { get; set; }
        public int SourceId { get; set; }
        public Source Source { get; set; }
        public string BaseModelCode { get; set; }
        public string Email { get; set; }
        public string SalesPersonCode { get; set; }
        public DateTime AssignDate { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
