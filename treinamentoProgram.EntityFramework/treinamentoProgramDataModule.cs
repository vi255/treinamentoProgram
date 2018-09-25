using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using treinamentoProgram.EntityFramework;

namespace treinamentoProgram
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(treinamentoProgramCoreModule))]
    public class treinamentoProgramDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<treinamentoProgramDbContext>(null);
        }
    }
}
