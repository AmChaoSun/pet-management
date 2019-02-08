﻿using BL.Managers;
using Microsoft.Owin.Security.OAuth;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace PetManagement.Providers
{
    public class TokenBasedOAuthProvider : OAuthAuthorizationServerProvider
            // Resource owner password credentials does not provide a client ID.
            context.Validated();
}