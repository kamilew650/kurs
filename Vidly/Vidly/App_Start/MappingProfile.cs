using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Models;
using Vidly.Dtos;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Customer, CustomerDto>());
            Mapper.Initialize(cfg => cfg.CreateMap<CustomerDto, Customer >());

        }
    }
}