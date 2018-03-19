using System.Threading.Tasks;
using Abp.Application.Services;
using CRUDzao.Authorization.Accounts.Dto;

namespace CRUDzao.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
