using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteDotNet.Repositorio.Migrations
{
    public partial class TesteDotNet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caminhao",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(type: "nVARCHAR(250)", nullable: false),
                    Modelo = table.Column<string>(type: "nCHAR(2)", nullable: false),
                    AnoModelo = table.Column<int>(nullable: false),
                    AnoFabricacao = table.Column<int>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    UltimaAtualizacao = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caminhao", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Caminhao");
        }
    }
}
