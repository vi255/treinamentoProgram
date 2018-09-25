using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace treinamentoProgram
{
    [DependsOn(typeof(AbpWebApiModule), typeof(treinamentoProgramApplicationModule))]
    public class treinamentoProgramWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(treinamentoProgramApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
