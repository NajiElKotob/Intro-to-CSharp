namespace Basic_CRUD_with_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableDOB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "DOB", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "DOB", c => c.DateTime(nullable: false));
        }
    }
}
