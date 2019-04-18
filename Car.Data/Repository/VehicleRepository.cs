using Car.Data.EntityModels;
using Car.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Data.Repository
{
    public class VehicleRepository : Repository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(ApplicationDbContext context)
            : base(context)
        {

        }
    }
}