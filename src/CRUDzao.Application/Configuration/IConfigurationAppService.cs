using System.Threading.Tasks;
using Abp.Application.Services;
using CRUDzao.Configuration.Dto;

namespace CRUDzao.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}