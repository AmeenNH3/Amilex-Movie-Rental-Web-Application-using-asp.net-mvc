namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TruncateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("TRUNCATE TABLE Movies");
        }
        
        public override void Down()
        {
        }
    }
}
