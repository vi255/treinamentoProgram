using Abp.Web.Mvc.Controllers;

namespace treinamentoProgram.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class treinamentoProgramControllerBase : AbpController
    {
        protected treinamentoProgramControllerBase()
        {
            LocalizationSourceName = treinamentoProgramConsts.LocalizationSourceName;
        }
    }
}