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
                values: new object[] { new byte[] { 198, 52, 21, 66, 37, 80, 206, 226, 25, 142, 40, 188, 48, 171, 249, 144, 86, 189, 132, 23, 41, 16, 175, 235, 207, 195, 212, 251, 49, 13, 110, 173, 198, 8, 66, 130, 71, 129, 126, 16, 117, 158, 57, 178, 29, 27, 96, 31, 161, 61, 192, 117, 72, 183, 233, 57, 107, 218, 73, 12, 179, 237, 225, 130 }, new byte[] { 67, 136, 126, 218, 38, 223, 74, 204, 209, 197, 172, 185, 92, 38, 98, 96, 199, 194, 222, 40, 236, 118, 114, 227, 79, 93, 29, 61, 189, 245, 100, 24, 225, 65, 47, 185, 182, 217, 28, 146, 245, 145, 236, 56, 86, 41, 221, 30, 54, 145, 31, 28, 166, 58, 11, 137, 86, 220, 137, 58, 244, 145, 192, 115, 118, 213, 192, 98, 19, 236, 129, 119, 69, 9, 157, 227, 49, 84, 78, 148, 212, 17, 48, 75, 15, 27, 236, 205, 91, 158, 120, 121, 183, 170, 248, 228, 220, 125, 128, 91, 196, 153, 72, 37, 68, 0, 3, 117, 19, 195, 60, 33, 200, 230, 204, 35, 31, 48, 163, 145, 82, 140, 94, 35, 86, 101, 167, 143 } });

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
                values: new object[] { new byte[] { 184, 57, 60, 166, 199, 104, 113, 163, 84, 186, 87, 24, 102, 25, 55, 27, 208, 110, 22, 236, 54, 238, 96, 31, 20, 217, 68, 162, 148, 156, 140, 255, 92, 105, 71, 97, 77, 19, 16, 23, 20, 115, 144, 65, 22, 217, 56, 170, 188, 184, 126, 122, 130, 23, 16, 111, 2, 207, 13, 241, 72, 68, 189, 211 }, new byte[] { 200, 228, 146, 193, 218, 246, 227, 119, 27, 78, 117, 52, 189, 92, 80, 251, 137, 119, 222, 199, 114, 171, 147, 64, 160, 176, 78, 23, 246, 245, 14, 204, 130, 82, 181, 198, 47, 115, 169, 171, 14, 225, 154, 52, 164, 220, 55, 189, 91, 152, 114, 45, 1, 120, 169, 250, 239, 222, 146, 44, 105, 43, 10, 139, 135, 55, 84, 214, 156, 232, 90, 21, 180, 47, 240, 63, 185, 14, 158, 27, 102, 101, 192, 74, 153, 250, 127, 253, 91, 90, 84, 183, 153, 254, 0, 112, 88, 255, 122, 247, 162, 102, 247, 180, 132, 137, 125, 193, 245, 111, 27, 4, 8, 31, 135, 185, 202, 71, 186, 140, 175, 63, 222, 185, 185, 4, 0, 208 } });
        }
    }
}
