using Autofac;
using Autofac.Integration.WebApi;

using BookManagementSystem.Application.Services;
using BookManagementSystem.Domain.UnitOfWork;
using BookManagementSystem.Infraestructure.Factories;
using BookManagementSystem.Infraestructure.Repositories;
using BookManagementSystem.Infraestructure.UnitOfWork;
using System.Linq;
using System.Reflection;
using System.Web.Http;

namespace BookManagementSystem.Web
{
    public class AutofacWebapiConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }
        
        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            //builder.RegisterType<RepositoryStoredProcedures>().As<IRepositoryStoredProcedures>().InstancePerRequest();

            // Repositories
            builder.RegisterAssemblyTypes(typeof(UsuarioRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();

            // Services
            builder.RegisterAssemblyTypes(typeof(UsuarioService).Assembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces().InstancePerRequest();

            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();

            return Container;
        }
    }
}