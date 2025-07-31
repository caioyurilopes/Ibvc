using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ibvc.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPastorEmBatismoEProfissaoDeFe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pastor",
                table: "ProfissaoDeFe");

            migrationBuilder.DropColumn(
                name: "Pastor",
                table: "Batismo");

            migrationBuilder.AddColumn<int>(
                name: "PastorId",
                table: "ProfissaoDeFe",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PastorNomeManual",
                table: "ProfissaoDeFe",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PastorId",
                table: "Batismo",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PastorNomeManual",
                table: "Batismo",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProfissaoDeFe_PastorId",
                table: "ProfissaoDeFe",
                column: "PastorId");

            migrationBuilder.CreateIndex(
                name: "IX_Batismo_PastorId",
                table: "Batismo",
                column: "PastorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Batismo_Usuarios_PastorId",
                table: "Batismo",
                column: "PastorId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfissaoDeFe_Usuarios_PastorId",
                table: "ProfissaoDeFe",
                column: "PastorId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batismo_Usuarios_PastorId",
                table: "Batismo");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfissaoDeFe_Usuarios_PastorId",
                table: "ProfissaoDeFe");

            migrationBuilder.DropIndex(
                name: "IX_ProfissaoDeFe_PastorId",
                table: "ProfissaoDeFe");

            migrationBuilder.DropIndex(
                name: "IX_Batismo_PastorId",
                table: "Batismo");

            migrationBuilder.DropColumn(
                name: "PastorId",
                table: "ProfissaoDeFe");

            migrationBuilder.DropColumn(
                name: "PastorNomeManual",
                table: "ProfissaoDeFe");

            migrationBuilder.DropColumn(
                name: "PastorId",
                table: "Batismo");

            migrationBuilder.DropColumn(
                name: "PastorNomeManual",
                table: "Batismo");

            migrationBuilder.AddColumn<string>(
                name: "Pastor",
                table: "ProfissaoDeFe",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pastor",
                table: "Batismo",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
