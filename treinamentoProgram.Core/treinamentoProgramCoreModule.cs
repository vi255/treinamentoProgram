using System.Reflection;
using Abp.Modules;

namespace treinamentoProgram
{
    public class treinamentoProgramCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
