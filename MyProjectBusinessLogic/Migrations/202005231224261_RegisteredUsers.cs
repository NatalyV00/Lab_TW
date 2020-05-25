namespace MyProject.BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RegisteredUsers : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UsersDbTables", "LastLogin", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UsersDbTables", "LastLogin", c => c.DateTime(nullable: false));
        }
    }
}
