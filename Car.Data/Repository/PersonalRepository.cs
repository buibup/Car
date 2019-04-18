using Car.Data.EntityModels;
using Car.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Data.Repository
{
    public class PersonalRepository : Repository<Personal>, IPersonalRepository
    {
        public PersonalRepository(ApplicationDbContext context)
            :base(context)
        {

        }
    }
}
