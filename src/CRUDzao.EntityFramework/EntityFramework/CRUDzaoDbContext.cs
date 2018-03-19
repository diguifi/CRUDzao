using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using CRUDzao.Authorization.Roles;
using CRUDzao.Authorization.Users;
using CRUDzao.Entities.Client;
using CRUDzao.MultiTenancy;

namespace CRUDzao.EntityFramework
{
    public class CRUDzaoDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        public IDbSet<Client> Clients { get; set; }
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public CRUDzaoDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in CRUDzaoDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of CRUDzaoDbContext since ABP automatically handles it.
         */
        public CRUDzaoDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public CRUDzaoDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public CRUDzaoDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
