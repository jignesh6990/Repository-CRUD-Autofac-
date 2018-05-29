using Autofac;
using Autofac.Builder;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using OneWorld.Data;
using OneWorld.Model;
using OneWorld.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
//using System.Web.Http;

namespace OneWorld.WebAPI
{
    public static class Bootstrapper
    {

        public static void Run(HttpConfiguration config)
        {

            SetAutofac(config);
        }
        /// <summary>
        /// Autofac dependency resolve
        /// </summary>
        private static void SetAutofac(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();

            //Register controller
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DatabaseFactory>().As<IDatabaseFactory>().InstancePerRequest();

            

            //Repository
            builder.RegisterAssemblyTypes(Assembly.Load("OneWorld.Data"))
              .Where(t => t.Name.EndsWith("Repository"))
              .AsImplementedInterfaces()
              .InstancePerLifetimeScope();

            //Service
            builder.RegisterAssemblyTypes(Assembly.Load("OneWorld.Service"))
              .Where(t => t.Name.EndsWith("Service"))
              .AsImplementedInterfaces()
              .InstancePerLifetimeScope();

            

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            config.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);
            
        }
    }
}