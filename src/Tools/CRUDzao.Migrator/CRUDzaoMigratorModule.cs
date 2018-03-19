using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using CRUDzao.EntityFramework;

namespace CRUDzao.Migrator
{
    [DependsOn(typeof(CRUDzaoDataModule))]
    public class CRUDzaoMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<CRUDzaoDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}