using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ibvc.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Batismo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Pastor = table.Column<string>(type: "TEXT", nullable: false),
                    Igreja = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batismo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProfissaoDeFe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Pastor = table.Column<string>(type: "TEXT", nullable: false),
                    Igreja = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfissaoDeFe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeCompleto = table.Column<string>(type: "TEXT", nullable: false),
                    Cep = table.Column<string>(type: "TEXT", nullable: false),
                    Logradouro = table.Column<string>(type: "TEXT", nullable: false),
                    Complemento = table.Column<string>(type: "TEXT", nullable: true),
                    Bairro = table.Column<string>(type: "TEXT", nullable: false),
                    Uf = table.Column<string>(type: "TEXT", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", nullable: false),
                    Numero = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Naturalidade = table.Column<string>(type: "TEXT", nullable: true),
                    Genero = table.Column<int>(type: "INTEGER", nullable: false),
                    EstadoCivil = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoUsuario = table.Column<int>(type: "INTEGER", nullable: false),
                    ConjugeId = table.Column<int>(type: "INTEGER", nullable: true),
                    NomeConjuge = table.Column<string>(type: "TEXT", nullable: true),
                    DataCasamento = table.Column<DateTime>(type: "TEXT", nullable: true),
                    NomePai = table.Column<string>(type: "TEXT", nullable: true),
                    NomeMae = table.Column<string>(type: "TEXT", nullable: true),
                    BatismoId = table.Column<int>(type: "INTEGER", nullable: true),
                    ProfissaoDeFeId = table.Column<int>(type: "INTEGER", nullable: true),
                    DataAdmissao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MeioAdmissao = table.Column<string>(type: "TEXT", nullable: false),
                    Celular = table.Column<string>(type: "TEXT", nullable: true),
                    Senha = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Batismo_BatismoId",
                        column: x => x.BatismoId,
                        principalTable: "Batismo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Usuarios_ProfissaoDeFe_ProfissaoDeFeId",
                        column: x => x.ProfissaoDeFeId,
                        principalTable: "ProfissaoDeFe",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Usuarios_Usuarios_ConjugeId",
                        column: x => x.ConjugeId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_BatismoId",
                table: "Usuarios",
                column: "BatismoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ConjugeId",
                table: "Usuarios",
                column: "ConjugeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ProfissaoDeFeId",
                table: "Usuarios",
                column: "ProfissaoDeFeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Batismo");

            migrationBuilder.DropTable(
                name: "ProfissaoDeFe");
        }
    }
}
