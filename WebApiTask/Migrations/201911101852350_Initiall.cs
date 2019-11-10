namespace WebApiTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initiall : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "AuthorId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "AuthorId");
        }
    }
}
