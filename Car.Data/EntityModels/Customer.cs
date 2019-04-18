using Car.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Data.EntityModels
{
    public class Customer : BaseEntity
    {
        public Customer()
        {

        }
        public Customer(Customer customer)
        {
            switch (customer.CustomerType)
            {
                case CustomerType.None:
                    break;
                case CustomerType.Personal:
                    Personal = customer.Personal;
                    break;
                case CustomerType.Cooperation:
                    Cooperation = customer.Cooperation;
                    break;
                case CustomerType.GovernmentOrStateEnterprise:
                    Government = customer.Government;
                    break;
                default:
                    break;
            }

            switch (customer.EstablishmentType)
            {
                case EstablishmentType.None:
                    break;
                case EstablishmentType.HeadOffice:
                    BranchAt = "";
                    break;
                case EstablishmentType.Branch:
                    BranchAt = customer.BranchAt;
                    break;
                default:
                    break;
            }
        }
        public Guid CustomerGuid { get; set; }
        public string CustomerCodeFrom { get; set; }
        public EstablishmentType EstablishmentType { get; set; }
        public string BranchAt { get; set; }
        public string CustomerCode { get; set; }
        public string TaxIdNo { get; set; }
        public CustomerType CustomerType { get; set; }
        public int? PersonalId { get; set; }
        public Personal Personal { get; set; }
        public int? CooperationId { get; set; }
        public Cooperation Cooperation { get; set; }
        public int? GovernmentId { get; set; }
        public Government Government { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
