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
    public class covidDetailProfile:Profile
    {
        public covidDetailProfile()
        {
            CreateMap<CovidDetail, CCovidDetail>()
               /* .ForMember(b => b.IdNumber, a => a.MapFrom(b => b.IdNumber))
                */
               .ReverseMap();

        }
        
    }
}
