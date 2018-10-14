using AutoMapper;
using GoData.Entities.Entities;
using GoData.Portal.Dtos;
using GoData.Portal.Extensions;
using Ninject;
using Ninject.Modules;
using System.Collections.Generic;

namespace GoData.Portal.NinjectModules
{
    public class AutoMapperModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMapper>().ToMethod(AutoMapper).InSingletonScope();
        }

        private IMapper AutoMapper(Ninject.Activation.IContext context)
        {
            Mapper.Initialize(config =>
            {
                config.ConstructServicesUsing(type => context.Kernel.Get(type));

                config.CreateMap<OrganizationDto, Organization>();
                //config.CreateMap<OrganizationDto, Organization>();
                // .... other mappings, Profiles, etc.              

            });

            //Mapper.AssertConfigurationIsValid(); // optional
            return Mapper.Instance;
        }
    }
}
