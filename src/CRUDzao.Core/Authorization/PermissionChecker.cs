using Abp.Authorization;
using CRUDzao.Authorization.Roles;
using CRUDzao.Authorization.Users;

namespace CRUDzao.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
