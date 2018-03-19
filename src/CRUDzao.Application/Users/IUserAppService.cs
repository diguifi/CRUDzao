using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CRUDzao.Roles.Dto;
using CRUDzao.Users.Dto;

namespace CRUDzao.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}