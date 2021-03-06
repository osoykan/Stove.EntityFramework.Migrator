using FluentMigrator;

namespace Stove.Migrator.Tests.Domain.FluentMigrator.OneAdminDatabase
{
    [Tags(TagNames.Database.OneAdminDatabase)]
    [Tags(TagNames.Environment.Dev, TagNames.Environment.Stage, TagNames.Environment.Production)]
    [KnownMigration("Oguzhan Soykan", "OAT1-0001", typeof(Mig0002_InsertUserTable), 2017, 03, 12, 18, 32)]
    public class Mig0002_InsertUserTable : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("Mig0002_InsertUserTable.sql");
        }

        public override void Down()
        {
            Execute.EmbeddedScript("Mig0002_InsertUserTable_Rollback.sql");
        }
    }
}
