using Car.Data.EntityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Car.Services.ViewModels
{
    public class CustomerViewModel
    {
        [Key]
        public Guid CustomerGuid { get; set; }
        public string CustomerCodeFrom { get; set; }
        public string EstablishmentType { get; set; }
        public string BranchAt { get; set; }
        public string CustomerCode { get; set; }
        public string TaxIdNo { get; set; }
        public string CustomerType { get; set; }

        #region person

        public int TitleId { get; set; }
        public Title Title { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string GenderType { get; set; }
        public int CustomerGroupId { get; set; }
        public CustomerGroup CustomerGroup { get; set; }

        #endregion


        #region Cooperation

        public string CompanyName { get; set; }

        #endregion

        #region Government

        public string OrganizationName { get; set; }

        #endregion

        public string ContactPerson { get; set; }
        public string Fax { get; set; }


        public string Email { get; set; }
        public string BaseModelCode { get; set; }
        public int SourceId { get; set; }
        public Source Source { get; set; }
        public int ProspectId { get; set; }
        public Prospect Prospect { get; set; }
        public string MobilePhoneNo { get; set; }
        public string SalesPersonCode { get; set; }
        public DateTime AssignDate { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
