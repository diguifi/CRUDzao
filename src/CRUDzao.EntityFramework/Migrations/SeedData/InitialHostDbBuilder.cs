using CRUDzao.EntityFramework;
using EntityFramework.DynamicFilters;

namespace CRUDzao.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly CRUDzaoDbContext _context;

        public InitialHostDbBuilder(CRUDzaoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
