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
            //User createdUser = new User            //{            //    Email = user.Email,            //    PasswordHash = HashHelper.GetMD5HashData(user.Password),            //    UserName = user.UserName,            //    CreateOn = DateTime.Now            //};            var createdUser = Mapper.Map<UserRegisterDto, User>(user);            createdUser = _userRepository.Add(createdUser);            UserDisplayDto displayUser = new UserDisplayDto            {
                Id = createdUser != null ? createdUser.Id : 0,                UserName = createdUser.UserName,                Email = createdUser.Email,            };            return displayUser;
        }
    }
}
