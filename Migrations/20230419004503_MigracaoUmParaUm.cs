using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "Armas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 175, 97, 169, 53, 50, 112, 36, 153, 139, 21, 243, 31, 58, 84, 134, 228, 251, 30, 46, 14, 95, 38, 23, 114, 217, 206, 175, 170, 252, 63, 19, 138, 112, 109, 190, 224, 99, 23, 143, 162, 70, 36, 217, 0, 35, 87, 243, 59, 50, 57, 159, 63, 161, 30, 234, 42, 59, 241, 35, 60, 82, 30, 225, 138 }, new byte[] { 9, 42, 24, 149, 80, 205, 16, 65, 179, 202, 147, 25, 53, 145, 67, 131, 55, 137, 43, 48, 5, 243, 151, 24, 56, 104, 135, 12, 16, 184, 140, 1, 39, 207, 65, 55, 114, 146, 131, 25, 106, 143, 254, 184, 156, 221, 60, 45, 79, 147, 39, 22, 28, 111, 72, 60, 233, 190, 72, 77, 207, 31, 40, 86, 45, 190, 190, 122, 132, 151, 106, 114, 44, 140, 218, 226, 205, 94, 226, 115, 183, 249, 120, 133, 223, 232, 239, 52, 52, 191, 38, 217, 67, 66, 235, 204, 38, 178, 135, 247, 117, 207, 159, 251, 169, 63, 71, 121, 234, 64, 192, 32, 93, 159, 95, 101, 61, 221, 9, 123, 161, 47, 180, 73, 70, 26, 213, 168 } });

            migrationBuilder.CreateIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Armas_Personagens_PersonagemId",
                table: "Armas",
                column: "PersonagemId",
                principalTable: "Personagens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armas_Personagens_PersonagemId",
                table: "Armas");

            migrationBuilder.DropIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "Armas");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 238, 31, 230, 166, 72, 80, 8, 247, 105, 47, 209, 65, 194, 143, 140, 158, 245, 135, 100, 169, 54, 249, 233, 110, 240, 149, 20, 103, 58, 244, 151, 246, 72, 234, 185, 44, 28, 187, 86, 128, 245, 221, 171, 75, 167, 239, 202, 16, 122, 220, 72, 124, 5, 181, 237, 176, 144, 236, 198, 71, 202, 227, 34, 220 }, new byte[] { 34, 4, 238, 42, 197, 202, 240, 115, 79, 2, 32, 251, 233, 118, 45, 208, 93, 6, 83, 21, 89, 242, 190, 163, 52, 162, 18, 198, 35, 53, 35, 248, 115, 174, 177, 63, 180, 10, 185, 155, 97, 146, 124, 99, 252, 71, 161, 233, 5, 54, 177, 35, 93, 161, 250, 214, 172, 104, 150, 232, 210, 168, 101, 2, 105, 151, 54, 237, 56, 239, 94, 27, 109, 123, 99, 129, 35, 164, 199, 77, 121, 206, 23, 34, 210, 83, 246, 203, 223, 190, 93, 14, 39, 237, 89, 168, 159, 99, 210, 232, 60, 150, 208, 117, 4, 110, 45, 201, 23, 209, 218, 117, 60, 131, 240, 101, 64, 219, 207, 173, 100, 231, 225, 156, 246, 93, 197, 3 } });
        }
    }
}
