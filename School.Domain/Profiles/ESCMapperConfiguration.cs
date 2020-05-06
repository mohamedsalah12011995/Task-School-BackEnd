using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School.Domain.Profiles
{
    public class ESCMapperConfiguration
    {
        static IList<Profile> profiles;
        static ESCMapperConfiguration()
        {
            profiles = new List<Profile>();
        }

        public static void ConfigMapper(Microsoft.Extensions.DependencyInjection.IServiceCollection services)
        {
            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                var profileType = typeof(Profile);
                var allProfiles = typeof(SchoolProfile).Assembly.GetTypes()
                    .Where(p => profileType.IsAssignableFrom(p) && !p.IsInterface && !p.IsAbstract)
                      .Select(x => (Profile)Activator.CreateInstance(x));

                foreach (var profileInstance in allProfiles)
                {
                    mc.AddProfile(profileInstance);
                }
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
