using Car.Data.EntityModels;
using Car.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Data.Repository
{
    public class CustomerGroupRepository : Repository<CustomerGroup>, ICustomerGroupRepository
    {
        public CustomerGroupRepository(ApplicationDbContext context)
            :base(context)
        {

        }
    }
}
