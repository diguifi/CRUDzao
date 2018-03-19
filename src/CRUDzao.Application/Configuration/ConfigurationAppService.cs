using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CRUDzao.Configuration.Dto;

namespace CRUDzao.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CRUDzaoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
