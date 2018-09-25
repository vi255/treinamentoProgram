using Abp.Web.Mvc.Views;

namespace treinamentoProgram.Web.Views
{
    public abstract class treinamentoProgramWebViewPageBase : treinamentoProgramWebViewPageBase<dynamic>
    {

    }

    public abstract class treinamentoProgramWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected treinamentoProgramWebViewPageBase()
        {
            LocalizationSourceName = treinamentoProgramConsts.LocalizationSourceName;
        }
    }
}