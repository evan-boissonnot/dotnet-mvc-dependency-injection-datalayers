using Autofac;
using Autofac.Integration.Mvc;
using LesDataLayers;
using LesFactories;
using LesInterfaces;
using LesProviders;
using LesResolvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1
{
    public class InjectionDependenciesConfig
    {
        public static void Register()
        {
            ContainerBuilder builder = new ContainerBuilder();

            DeclareDependencies(builder);
            IContainer container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        private static void DeclareDependencies(ContainerBuilder builder)
        {
            builder.RegisterType<Dal1>();
            builder.RegisterType<Dal2>();

            builder.RegisterType<DefaultWebDalFactory>().As<IDalFactory>();
            builder.RegisterType<UnProvider>().As<IProvider>();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                   .Where(t => t.Name.EndsWith("Controller"));
        }
    }
}