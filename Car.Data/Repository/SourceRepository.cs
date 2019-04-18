using Car.Data.EntityModels;
using Car.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Data.Repository
{
    public class SourceRepository : Repository<Source>, ISourceRepository
    {
        public SourceRepository(ApplicationDbContext context)
            :base(context)
        {

        }
    }
}
