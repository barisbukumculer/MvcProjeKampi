namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class skills2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Skills", "Skill4", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Skills", "Skill4");
        }
    }
}
