using AutoMapper;
using Esacco.Data;
using Esacco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esacco.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Customer, CustomerVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
            CreateMap<Status, StatusVM>().ReverseMap();
            CreateMap<SysConfig, SysConfigVM>().ReverseMap();

        }
    }
}
