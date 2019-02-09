using BL.Managers.Interfaces;
using Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetManagement.Controllers
{
    public class UsersController : ApiController
    {
        private readonly IUserManager _userManager;        public UsersController(IUserManager userManager)        {            _userManager = userManager;        }        [HttpPost]        [Route("api/users")]        public IHttpActionResult CreateUser(UserRegisterDto user)        {            var userDisplay = _userManager.CreateUser(user);            return Ok(userDisplay);        }
        [HttpGet]
        [Route("api/users")]
        public IHttpActionResult GetAll()
        {
            var users = _userManager.GetAll();
            return Ok(users);
        }

        [HttpGet]
        [Route("api/users/{id}")]
        public IHttpActionResult GetUser(int id)
        {
            var user = _userManager.GetUser(id);
            return Ok(user);
        }

        [HttpPut]
        [Route("api/users/{Id}")]
        public IHttpActionResult UpdateUser(int id, UserDisplayDto user)
        {
            var updatedUser = _userManager.UpdateUser(id, user);
            return Ok(updatedUser);
        }
    }
}
