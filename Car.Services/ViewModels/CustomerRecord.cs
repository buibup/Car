using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Services.ViewModels
{
    public class CustomerRecord
    {
        public string CustomerCode { get; set; }
        public string FullName { get; set; }
        public string IDCardNumber { get; set; }
        public string MobileNo { get; set; }
        public DateTime CrateDate { get; set; }
    }
}
