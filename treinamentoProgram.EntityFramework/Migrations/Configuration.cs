using System.Data.Entity.Migrations;

namespace treinamentoProgram.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<treinamentoProgram.EntityFramework.treinamentoProgramDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "treinamentoProgram";
        }

        protected override void Seed(treinamentoProgram.EntityFramework.treinamentoProgramDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
