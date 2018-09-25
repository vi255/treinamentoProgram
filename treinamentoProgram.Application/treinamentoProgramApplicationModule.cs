using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using treinamentoProgram.Entities.ProductEntity;
using treinamentoProgram.ProductServices.DTOs;

namespace treinamentoProgram
{
    [DependsOn(typeof(treinamentoProgramCoreModule), typeof(AbpAutoMapperModule))]
    public class treinamentoProgramApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(config =>
            {
                config.CreateMap<CreateProductInput, Product>()
                .ConstructUsing(x => new Product(x.Nome, x.Descricao, x.Valor));

                config.CreateMap<UpdateProductInput, Product>()
                .ConstructUsing(x => new Product(x.Nome, x.Descricao, x.Valor));
            });
        }


        public override void Initialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(configuration => {
                configuration.CreateMissingTypeMaps = true;
            });

            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
