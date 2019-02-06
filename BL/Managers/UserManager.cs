﻿using BL.Managers.Interfaces;
using Data.Repositories.interfaces;
using Model.DTOs;
using Model.Models;
using System;
using BL.utils;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BL.Managers
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public UserDisplayDto CreateUser(UserRegisterDto user)
        {
            //User createdUser = new User
                Id = createdUser != null ? createdUser.Id : 0,
        }
    }
}