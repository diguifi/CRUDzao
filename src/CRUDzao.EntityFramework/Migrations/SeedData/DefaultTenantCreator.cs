using System.Linq;
using CRUDzao.EntityFramework;
using CRUDzao.MultiTenancy;

namespace CRUDzao.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly CRUDzaoDbContext _context;

        public DefaultTenantCreator(CRUDzaoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
