using System.Data.Common;
using System.Data.Entity;
using Abp.EntityFramework;
using treinamentoProgram.Entities.ProductEntity;

namespace treinamentoProgram.EntityFramework
{
    public class treinamentoProgramDbContext : AbpDbContext
    {
        public virtual IDbSet<Product> Products { get; set; }

        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public treinamentoProgramDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in treinamentoProgramDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of treinamentoProgramDbContext since ABP automatically handles it.
         */
        public treinamentoProgramDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public treinamentoProgramDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public treinamentoProgramDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
