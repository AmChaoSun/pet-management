﻿using BL.Managers;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http.Filters;

namespace PetManagement.Filters
{
    public class BasicAuthenticationAttribute : AuthorizationFilterAttribute
                // Gets header parameters  

                try

                    // Gets username and password  
                    string usrename = originalString.Split(':')[0];

                    // Validate username and password  
                    if (user == null)
                        // returns unauthorized error  
                        actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
}