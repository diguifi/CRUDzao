using System.Threading.Tasks;
using Abp.Application.Services;
using CRUDzao.Sessions.Dto;

namespace CRUDzao.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
