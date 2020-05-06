using Autofac;
using Microsoft.AspNetCore.Http;
using School.Service;

namespace Task_School.API
{
    public class AutoFacContainerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<EmailSender>().As<IEmailSender>();

            //for  register all interfaces for all services 
            builder.RegisterAssemblyTypes(typeof(MaterialService).Assembly).AsImplementedInterfaces();

            //builder.RegisterType<JwtFactory>().As<IJwtFactory>().SingleInstance();

            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>().InstancePerLifetimeScope();

        }
    }
}