namespace Project_Managment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditRegister6 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "FName");
            DropColumn("dbo.AspNetUsers", "LName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "LName", c => c.String());
            AddColumn("dbo.AspNetUsers", "FName", c => c.String());
        }
    }
}
