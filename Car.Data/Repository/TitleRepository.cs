using Car.Data.EntityModels;
using Car.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Data.Repository
{
    public class TitleRepository : Repository<Title>, ITitleRepository
    {
        public TitleRepository(ApplicationDbContext context)
            :base(context)
        {

        }
    }
}
