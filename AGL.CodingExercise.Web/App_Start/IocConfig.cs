using System.Web.Mvc;
using AGL.CodingExercise.Domain.Abstractions;
using AGL.CodingExercise.Domain.Implementations;
using AGL.CodingExercise.Infrastructure.RepoImplementations;
using Autofac;
using Autofac.Integration.Mvc;

namespace AGL.CodingExercise.Web.App_Start
{
    public class IocConfig
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinderProvider();

            builder.RegisterModule<AutofacWebTypesModule>();
            builder.RegisterSource(new ViewRegistrationSource());
            builder.RegisterFilterProvider();

            builder.RegisterType<PeopleRepository>().As<IPeopleRepository>();
            builder.RegisterType<PeopleService>().As<IPeopleService>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}