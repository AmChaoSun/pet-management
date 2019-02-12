using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace PetManagement.Authentication
{
    public class CustomAuthentication: ApiController
    {
        public CustomAuthentication(HttpControllerContext context)
        {
            base.Initialize(context);
        }
        public bool AuthenticateUser(ClaimsIdentity identity, int id, out IHttpActionResult result)
        {
            bool valid = true;
            result = Ok();
            string userIdString = identity.FindFirst("sub").Value;
            if (!Int32.TryParse(userIdString, out int userId))
            {
                valid = false;
                result = BadRequest();
            }
            if (!(id == userId))
            {
                valid = false;
                result = Unauthorized();
            }
            return valid;
        }
    }
}