﻿using Autofac;
using Autofac.Integration.WebApi;
using BL;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace PetManagement.App_Start
{
    public class AutofacWebapiConfig
            //Register your Web API controllers.  
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();
}