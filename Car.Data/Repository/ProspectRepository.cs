using Car.Data.EntityModels;
using Car.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Data.Repository
{
    public class ProspectRepository : Repository<Prospect>, IProspectRepository
    {
        public ProspectRepository(ApplicationDbContext context)
            :base(context)
        {

        }
    }
}
