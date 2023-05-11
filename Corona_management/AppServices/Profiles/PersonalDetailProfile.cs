using AutoMapper;
using Common;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppServices.Profiles
{
    public class PersonalDetailProfile : Profile
    {
        public PersonalDetailProfile()
        {
            CreateMap<PersonalDetail, CPersonalDetail>()
              /* .ForMember(b => b.IdNumber, a => a.MapFrom(b => b.IdNumber))
               .ForMember(b => b.FirstName, a => a.MapFrom(b => b.FirstName))
               .ForMember(b => b.LastName, a => a.MapFrom(b => b.LastName))
               .ForMember(b => b.City, a => a.MapFrom(b => b.City))
               .ForMember(b => b.Street, a => a.MapFrom(b => b.Street))
               .ForMember(b => b.NumberStreet, a => a.MapFrom(b => b.NumberStreet))
               .ForMember(b => b.DateOfBirth, a => a.MapFrom(b => b.DateOfBirth))
               .ForMember(b => b.PhoneNumber, a => a.MapFrom(b => b.PhoneNumber))
               .ForMember(b => b.MobileNumber, a => a.MapFrom(b => b.MobileNumber))*/
               .ReverseMap();
        }
    }
}
