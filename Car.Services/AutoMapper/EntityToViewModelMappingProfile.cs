using AutoMapper;
using Car.Data.EntityModels;
using Car.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Services.AutoMapper
{
    public class EntityToViewModelMappingProfile : Profile
    {
        public EntityToViewModelMappingProfile()
        {
            //CreateMap<Customer, CustomerViewModel>();
        }
    }
}
