using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Services.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new EntityToViewModelMappingProfile());
                cfg.AddProfile(new ViewModelToEntityMappingProfile());
                cfg.AddProfile(new AutoMapperProfile());
            });
        }
    }
}
