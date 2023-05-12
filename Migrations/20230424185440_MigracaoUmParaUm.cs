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
                value: 1);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

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
                value: 4);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 184, 57, 60, 166, 199, 104, 113, 163, 84, 186, 87, 24, 102, 25, 55, 27, 208, 110, 22, 236, 54, 238, 96, 31, 20, 217, 68, 162, 148, 156, 140, 255, 92, 105, 71, 97, 77, 19, 16, 23, 20, 115, 144, 65, 22, 217, 56, 170, 188, 184, 126, 122, 130, 23, 16, 111, 2, 207, 13, 241, 72, 68, 189, 211 }, new byte[] { 200, 228, 146, 193, 218, 246, 227, 119, 27, 78, 117, 52, 189, 92, 80, 251, 137, 119, 222, 199, 114, 171, 147, 64, 160, 176, 78, 23, 246, 245, 14, 204, 130, 82, 181, 198, 47, 115, 169, 171, 14, 225, 154, 52, 164, 220, 55, 189, 91, 152, 114, 45, 1, 120, 169, 250, 239, 222, 146, 44, 105, 43, 10, 139, 135, 55, 84, 214, 156, 232, 90, 21, 180, 47, 240, 63, 185, 14, 158, 27, 102, 101, 192, 74, 153, 250, 127, 253, 91, 90, 84, 183, 153, 254, 0, 112, 88, 255, 122, 247, 162, 102, 247, 180, 132, 137, 125, 193, 245, 111, 27, 4, 8, 31, 135, 185, 202, 71, 186, 140, 175, 63, 222, 185, 185, 4, 0, 208 } });

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
                values: new object[] { new byte[] { 5, 194, 136, 84, 61, 97, 211, 21, 74, 191, 42, 173, 6, 91, 26, 67, 44, 246, 209, 149, 87, 56, 209, 153, 126, 23, 142, 240, 45, 137, 194, 185, 253, 235, 209, 3, 191, 149, 50, 7, 66, 92, 254, 72, 153, 25, 80, 55, 65, 34, 8, 209, 235, 48, 187, 56, 181, 236, 147, 186, 79, 236, 108, 156 }, new byte[] { 56, 152, 222, 253, 159, 134, 71, 2, 192, 67, 155, 193, 103, 204, 167, 11, 138, 203, 39, 14, 49, 188, 179, 201, 45, 174, 43, 5, 67, 69, 210, 128, 108, 155, 163, 230, 31, 160, 130, 77, 166, 58, 108, 153, 153, 210, 28, 148, 85, 87, 210, 113, 61, 90, 172, 39, 15, 80, 42, 48, 174, 90, 29, 13, 78, 57, 242, 197, 237, 167, 163, 43, 130, 104, 184, 39, 32, 239, 84, 231, 162, 159, 19, 102, 32, 223, 254, 70, 107, 201, 69, 158, 103, 53, 2, 254, 37, 229, 44, 170, 53, 225, 193, 49, 242, 250, 230, 36, 170, 102, 86, 49, 72, 105, 92, 79, 197, 45, 174, 151, 225, 23, 62, 136, 213, 29, 91, 123 } });
        }
    }
}
