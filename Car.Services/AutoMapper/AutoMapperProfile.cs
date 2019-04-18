using AutoMapper;
using Car.Common.Enums;
using Car.Data.EntityModels;
using Car.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Services.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CustomerViewModel, Customer>()
            .ForMember(
                dest => dest.Cooperation,
                            otp => otp.MapFrom(src =>
                            new Cooperation
                            {
                                AssignDate = src.AssignDate,
                                BaseModelCode = src.BaseModelCode,
                                CompanyName = src.CompanyName,
                                ContactPerson = src.ContactPerson,
                                Email = src.Email,
                                Fax = src.Fax,
                                MobilePhoneNo = src.MobilePhoneNo,
                                ProspectId = src.ProspectId,
                                Prospect = src.Prospect,
                                SalesPersonCode = src.SalesPersonCode,
                                SourceId = src.SourceId,
                                Source = src.Source,
                                VehicleId = src.VehicleId,
                                Vehicle = src.Vehicle
                            })
                )
                .ForMember(
                    dest => dest.Personal,
                        otp => otp.MapFrom(src =>
                        new Personal
                        {
                            AssignDate = src.AssignDate,
                            BaseModelCode = src.BaseModelCode,
                            CustomerGroupId = src.CustomerGroupId,
                            Email = src.Email,
                            GenderType = (GenderType)Enum.Parse(typeof(GenderType), src.GenderType),
                            LastName = src.LastName,
                            MobilePhoneNo = src.MobilePhoneNo,
                            Name = src.Name,
                            ProspectId = src.ProspectId,
                            Prospect = src.Prospect,
                            SalesPersonCode = src.SalesPersonCode,
                            SourceId = src.SourceId,
                            Source = src.Source,
                            TitleId = src.TitleId,
                            Title = src.Title,
                            VehicleId = src.VehicleId,
                            Vehicle = src.Vehicle
                        })
                )
                .ForMember(
                    dest => dest.Government,
                        otp => otp.MapFrom(src =>
                        new Government
                        {
                            AssignDate = src.AssignDate,
                            ContactPerson = src.ContactPerson,
                            Email = src.Email,
                            Fax = src.Fax,
                            MobilePhoneNo = src.MobilePhoneNo,
                            OrganizationName = src.OrganizationName,
                            ProspectId = src.ProspectId,
                            Prospect = src.Prospect,
                            SalesPersonCode = src.SalesPersonCode,
                            SourceId = src.SourceId,
                            Source = src.Source,
                            VehicleId = src.VehicleId,
                            Vehicle = src.Vehicle
                        })
                )
                .ReverseMap();
        }
    }
}
