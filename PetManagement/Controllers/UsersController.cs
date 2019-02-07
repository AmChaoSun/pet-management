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
        private readonly IUserManager _userManager;        public UsersController(IUserManager userManager)        {            _userManager = userManager;        }        [HttpPost]        [Route("api/test/createuser")]        public IHttpActionResult Post(UserRegisterDto user)        {            var userDisplay = _userManager.CreateUser(user);            return Ok(userDisplay);        }
    }
}
