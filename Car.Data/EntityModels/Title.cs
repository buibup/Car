using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Data.EntityModels
{
    public class Title : BaseEntity
    {
        public string  Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
