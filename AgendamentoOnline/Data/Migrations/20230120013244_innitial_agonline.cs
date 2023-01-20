using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendamentoOnline.Data.Migrations
{
    public partial class innitial_agonline : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Especialidade",
                columns: table => new
                {
                    EspecialidadeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EspecialidadeNome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidade", x => x.EspecialidadeId);
                });

            migrationBuilder.CreateTable(
                name: "Especialista",
                columns: table => new
                {
                    EspecialistaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EspecialistaNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CRM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EspecialidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialista", x => x.EspecialistaId);
                    table.ForeignKey(
                        name: "FK_Especialista_Especialidade_EspecialidadeId",
                        column: x => x.EspecialidadeId,
                        principalTable: "Especialidade",
                        principalColumn: "EspecialidadeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Especialista_EspecialidadeId",
                table: "Especialista",
                column: "EspecialidadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Especialista");

            migrationBuilder.DropTable(
                name: "Especialidade");
        }
    }
}
