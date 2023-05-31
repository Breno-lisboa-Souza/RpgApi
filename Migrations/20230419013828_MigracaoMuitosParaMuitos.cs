using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonagemHabilidades",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonagemHabilidades", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_PersonagemHabilidades_Habilidades_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "Habilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonagemHabilidades_Personagens_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 130, 45, 255, 191, 54, 64, 182, 36, 90, 22, 100, 239, 2, 170, 57, 96, 189, 153, 151, 71, 232, 12, 190, 86, 119, 221, 64, 101, 252, 52, 5, 217, 50, 252, 206, 68, 90, 12, 193, 8, 41, 153, 123, 51, 160, 210, 221, 118, 223, 46, 173, 132, 252, 7, 58, 83, 201, 148, 113, 91, 24, 123, 245, 100 }, new byte[] { 17, 61, 28, 79, 14, 128, 148, 162, 11, 85, 111, 169, 202, 166, 106, 200, 115, 162, 25, 115, 239, 156, 101, 245, 181, 35, 164, 193, 21, 20, 11, 90, 19, 25, 191, 172, 234, 201, 121, 49, 182, 35, 231, 191, 95, 86, 135, 7, 255, 124, 219, 139, 33, 13, 193, 241, 74, 252, 115, 160, 246, 192, 180, 232, 76, 130, 108, 202, 236, 11, 86, 128, 186, 64, 227, 55, 172, 234, 203, 165, 142, 75, 199, 190, 217, 18, 226, 36, 163, 230, 4, 20, 177, 115, 196, 44, 3, 40, 107, 92, 5, 197, 155, 107, 41, 225, 58, 240, 246, 12, 242, 195, 36, 52, 143, 1, 230, 110, 250, 55, 201, 167, 29, 189, 16, 17, 25, 148 } });

            migrationBuilder.InsertData(
                table: "PersonagemHabilidades",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonagemHabilidades_HabilidadeId",
                table: "PersonagemHabilidades",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonagemHabilidades");

            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "Personagens");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 175, 97, 169, 53, 50, 112, 36, 153, 139, 21, 243, 31, 58, 84, 134, 228, 251, 30, 46, 14, 95, 38, 23, 114, 217, 206, 175, 170, 252, 63, 19, 138, 112, 109, 190, 224, 99, 23, 143, 162, 70, 36, 217, 0, 35, 87, 243, 59, 50, 57, 159, 63, 161, 30, 234, 42, 59, 241, 35, 60, 82, 30, 225, 138 }, new byte[] { 9, 42, 24, 149, 80, 205, 16, 65, 179, 202, 147, 25, 53, 145, 67, 131, 55, 137, 43, 48, 5, 243, 151, 24, 56, 104, 135, 12, 16, 184, 140, 1, 39, 207, 65, 55, 114, 146, 131, 25, 106, 143, 254, 184, 156, 221, 60, 45, 79, 147, 39, 22, 28, 111, 72, 60, 233, 190, 72, 77, 207, 31, 40, 86, 45, 190, 190, 122, 132, 151, 106, 114, 44, 140, 218, 226, 205, 94, 226, 115, 183, 249, 120, 133, 223, 232, 239, 52, 52, 191, 38, 217, 67, 66, 235, 204, 38, 178, 135, 247, 117, 207, 159, 251, 169, 63, 71, 121, 234, 64, 192, 32, 93, 159, 95, 101, 61, 221, 9, 123, 161, 47, 180, 73, 70, 26, 213, 168 } });
        }
    }
}
