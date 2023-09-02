using AutoMapper;
using DemoWebApp.Core.DTOs;
using DemoWebApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApp.Core.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<M_MASTER, MasterDTO>().ReverseMap();
        }
    }
}
