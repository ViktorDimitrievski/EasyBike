using Application.Implementation;
using Autofac;
using Autofac.Integration.Mvc;
using Domain.Interfaces;
using Domain.Repositories;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyBikeWebApp.App_Start
{
    public class AutoFacConfig
    {
        public static void Load()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<Database>().As<Database>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}