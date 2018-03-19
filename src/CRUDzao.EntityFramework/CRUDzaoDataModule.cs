using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using CRUDzao.EntityFramework;

namespace CRUDzao
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(CRUDzaoCoreModule))]
    public class CRUDzaoDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CRUDzaoDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
