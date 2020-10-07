namespace CAD_Prof.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Professor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProfessorModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Endereco = c.String(nullable: false),
                        Telefone = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Disciplina = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProfessorModels");
        }
    }
}
