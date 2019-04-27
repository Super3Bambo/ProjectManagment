namespace Project_Managment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditRegister4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "UserType");
            DropColumn("dbo.AspNetUsers", "JDescription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "JDescription", c => c.String());
            AddColumn("dbo.AspNetUsers", "UserType", c => c.String());
        }
    }
}
