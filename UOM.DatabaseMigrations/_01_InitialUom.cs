using FluentMigrator;

namespace UOM.DatabaseMigrations
{
    [Migration(1)]
    public class _01_InitialUom : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Dimensions")
                .WithColumn("Id").AsGuid().PrimaryKey()
                .WithColumn("Name").AsString(50).NotNullable();
        }
    }
}