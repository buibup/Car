using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Data.EntityModels
{
    public class Vehicle : BaseEntity
    {
        public string Code { get; set; }
        public string NameTh { get; set; }
        public string NameEn { get; set; }
        public string Description { get; set; }
    }
}
