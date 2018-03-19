using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CRUDzao.MultiTenancy.Dto;

namespace CRUDzao.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
