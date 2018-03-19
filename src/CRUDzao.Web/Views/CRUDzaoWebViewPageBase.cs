using Abp.Web.Mvc.Views;

namespace CRUDzao.Web.Views
{
    public abstract class CRUDzaoWebViewPageBase : CRUDzaoWebViewPageBase<dynamic>
    {

    }

    public abstract class CRUDzaoWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected CRUDzaoWebViewPageBase()
        {
            LocalizationSourceName = CRUDzaoConsts.LocalizationSourceName;
        }
    }
}