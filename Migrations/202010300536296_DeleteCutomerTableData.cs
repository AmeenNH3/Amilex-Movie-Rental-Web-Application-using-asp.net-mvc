namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCutomerTableData : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Customers WHERE id= 5");
            Sql("DELETE FROM Customers WHERE id= 6");
        }
        
        public override void Down()
        {
            

        }
    }
}
