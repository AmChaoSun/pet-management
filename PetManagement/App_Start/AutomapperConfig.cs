using AutoMapper;
using BL.utils;
using Model.DTOs;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetManagement.App_Start
{
    public class AutomapperConfig    {        public static void Initialize()        {            Mapper.Initialize(config =>            {
                config.CreateMap<UserRegisterDto, User>()                .ForMember(d=>d.PasswordHash, opt => opt.MapFrom(src=> HashHelper.GetMD5HashData(src.Password)))                .ForMember(d=>d.CreateOn, opt=>opt.MapFrom(src=>DateTime.Now));            });        }    }
}