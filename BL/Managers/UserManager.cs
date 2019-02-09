using BL.Managers.Interfaces;
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
            //User createdUser = new User            //{            //    Email = user.Email,            //    PasswordHash = HashHelper.GetMD5HashData(user.Password),            //    UserName = user.UserName,            //    CreateOn = DateTime.Now            //};            User createdUser = Mapper.Map<UserRegisterDto, User>(user);            createdUser = _userRepository.Add(createdUser);

            //UserDisplayDto displayUser = new UserDisplayDto
            //{
            //    Id = createdUser != null ? createdUser.Id : 0,
            //    UserName = createdUser.UserName,
            //    Email = createdUser.Email,
            //};
            UserDisplayDto displayUser = Mapper.Map<User, UserDisplayDto>(createdUser);            return displayUser;
        }

        public void DeleteUser(int Id)
        {
            //need authentication
            var user = _userRepository.GetById(Id);
            _userRepository.Delete(user);
        }

        public IEnumerable<UserDisplayDto> GetAll()
        {
            IEnumerable<User> users = _userRepository.GetAll();
            IEnumerable<UserDisplayDto> userDisplayDtos = Mapper.Map<IEnumerable<User>, IEnumerable<UserDisplayDto>>(users);
            return userDisplayDtos;
        }

        public UserDisplayDto GetUser(int Id)
        {
            var user = _userRepository.GetById(Id);
            UserDisplayDto displayUser = Mapper.Map<User, UserDisplayDto>(user);
            return displayUser;
        }

        public UserDisplayDto UpdateUser(int Id, UserDisplayDto user)
        {
            //need authentication
            User updatedUser = Mapper.Map<UserDisplayDto, User>(user);
            updatedUser = _userRepository.Update(updatedUser);
            UserDisplayDto displayUser = Mapper.Map<User, UserDisplayDto>(updatedUser);
            return displayUser;
        }
    }
}
