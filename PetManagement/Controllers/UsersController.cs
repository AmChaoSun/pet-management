using BL.Managers.Interfaces;
using Microsoft.AspNet.Identity;
using Model.DTOs;
using PetManagement.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace PetManagement.Controllers
{
    [Authorize]
    public class UsersController : ApiController
    {
        private readonly IUserManager _userManager;        public UsersController(IUserManager userManager)        {            _userManager = userManager;        }        [AllowAnonymous]        [HttpPost]        [Route("api/users")]        public IHttpActionResult CreateUser(UserRegisterDto user)        {            var userDisplay = _userManager.CreateUser(user);            return Ok(userDisplay);        }
        [HttpGet]
        [Route("api/users")]
        public IHttpActionResult GetAll()
        {
            //need further admin auth
            var users = _userManager.GetAll();
            return Ok(users);
        }

        
        [HttpGet]
        [Route("api/users/{id}")]
        public IHttpActionResult GetUser(int id)
        {
            var auth = new CustomAuthentication(ControllerContext);
            if (!auth.AuthenticateUser(User.Identity as ClaimsIdentity, id, out IHttpActionResult result))
            {
                return result;
            }
            var user = _userManager.GetUser(id);
            return Ok(user);
        }

        [HttpPut]
        [Route("api/users/{id}")]
        public IHttpActionResult UpdateUser(int id, UserDisplayDto user)
        {
            //authentication
            var auth = new CustomAuthentication(ControllerContext);
            if (!auth.AuthenticateUser(User.Identity as ClaimsIdentity, id, out IHttpActionResult result))
            {
                return result;
            }

            var updatedUser = _userManager.UpdateUser(id, user);
            return Ok(updatedUser);
        }

        [HttpDelete]
        [Route("api/users/{id}")]
        public IHttpActionResult DeleteUser(int id)
        {
            //authentication
            var auth = new CustomAuthentication(ControllerContext);
            if (!auth.AuthenticateUser(User.Identity as ClaimsIdentity, id, out IHttpActionResult result))
            {
                return result;
            }

            bool deleted = _userManager.DeleteUser(id);
            if (deleted) { return Ok("deleted"); }
            return Ok();
        }
    }
}
