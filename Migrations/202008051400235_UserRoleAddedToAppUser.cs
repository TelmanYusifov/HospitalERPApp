namespace HospitalERPNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserRoleAddedToAppUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AppUsers", "UserRole", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AppUsers", "UserRole");
        }
    }
}
