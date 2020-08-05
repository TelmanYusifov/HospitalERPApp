namespace HospitalERPNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AppUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AppUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        Surname = c.String(nullable: false, maxLength: 60),
                        Username = c.String(nullable: false, maxLength: 40),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AppUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Receptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AppUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Receptions", "UserId", "dbo.AppUsers");
            DropForeignKey("dbo.Doctors", "UserId", "dbo.AppUsers");
            DropForeignKey("dbo.Admins", "UserId", "dbo.AppUsers");
            DropIndex("dbo.Receptions", new[] { "UserId" });
            DropIndex("dbo.Doctors", new[] { "UserId" });
            DropIndex("dbo.Admins", new[] { "UserId" });
            DropTable("dbo.UserRoles");
            DropTable("dbo.Receptions");
            DropTable("dbo.Doctors");
            DropTable("dbo.AppUsers");
            DropTable("dbo.Admins");
        }
    }
}
