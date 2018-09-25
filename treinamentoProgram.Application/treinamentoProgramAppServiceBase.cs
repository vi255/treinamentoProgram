using Abp.Application.Services;

namespace treinamentoProgram
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class treinamentoProgramAppServiceBase : ApplicationService
    {
        protected treinamentoProgramAppServiceBase()
        {
            LocalizationSourceName = treinamentoProgramConsts.LocalizationSourceName;
        }
    }
}