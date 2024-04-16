namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableCitas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Citas",
                c => new
                    {
                        CitaId = c.Int(nullable: false, identity: true),
                        MedicoId = c.Int(nullable: false),
                        PacienteId = c.Int(nullable: false),
                        Medico = c.String(nullable: false, maxLength: 120),
                        Paciente = c.String(nullable: false, maxLength: 120),
                        FechaCita = c.DateTime(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Medicos_MedicoId = c.Int(),
                        Pacientes_MedicoId = c.Int(),
                    })
                .PrimaryKey(t => t.CitaId)
                .ForeignKey("dbo.Medicos", t => t.Medicos_MedicoId)
                .ForeignKey("dbo.Medicos", t => t.Pacientes_MedicoId)
                .Index(t => t.Medicos_MedicoId)
                .Index(t => t.Pacientes_MedicoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Citas", "Pacientes_MedicoId", "dbo.Medicos");
            DropForeignKey("dbo.Citas", "Medicos_MedicoId", "dbo.Medicos");
            DropIndex("dbo.Citas", new[] { "Pacientes_MedicoId" });
            DropIndex("dbo.Citas", new[] { "Medicos_MedicoId" });
            DropTable("dbo.Citas");
        }
    }
}
