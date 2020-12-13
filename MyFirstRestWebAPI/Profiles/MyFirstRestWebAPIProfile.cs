using AutoMapper;
using MyFirstRestWebAPI.Dtos;
using MyFirstRestWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstRestWebAPI.Profiles
{
    public class MyFirstRestWebAPIProfile : Profile
    {
        public MyFirstRestWebAPIProfile()
        {
            //Source -> Target
            CreateMap<Command, MyFirstRestWebAPIReadDTO>();
            CreateMap<MyFirstRestWebAPICreateDTO, Command>();
            CreateMap<MyFirstRestWebAPIUpdateDTO, Command>();
            CreateMap<Command, MyFirstRestWebAPIUpdateDTO>();
        }
    }
}
