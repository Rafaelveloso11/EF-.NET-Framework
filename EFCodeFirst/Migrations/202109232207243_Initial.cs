namespace EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notas",
                c => new
                    {
                        NotasID = c.Int(nullable: false, identity: true),
                        Nota = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NotasID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Notas");
        }
    }
}
