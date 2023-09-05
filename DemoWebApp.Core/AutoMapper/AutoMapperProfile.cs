using AutoMapper;
using DemoWebApp.Core.DTOs;
using DemoWebApp.Core.Domain.Entities;
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
            CreateMap<M_PROGRAM, ProgramDTO>().ReverseMap();
            CreateMap<M_MASTER, MasterDTO>().ReverseMap();
            CreateMap<M_ROLE, RoleDTO>().ReverseMap();
            CreateMap<M_USER, UserDTO>().ReverseMap();
            CreateMap<M_USER_ROLE, UserRoleDTO>().ReverseMap();
            CreateMap<T_CURRENT_LOGIN, CurrentLoginDTO>().ReverseMap();
            CreateMap<M_PARAMETER, ParameterDTO>().ReverseMap();
        }
    }
}
