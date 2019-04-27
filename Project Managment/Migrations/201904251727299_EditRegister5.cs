namespace Project_Managment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditRegister5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "UserType", c => c.String());
            AddColumn("dbo.AspNetUsers", "JDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "JDescription");
            DropColumn("dbo.AspNetUsers", "UserType");
        }
    }
}
