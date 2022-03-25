using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace JslApi.Migrations
{
    public partial class Inicializacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Motorista",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    Sobrenome = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    CaminhaoMarca = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    CaminhaoModelo = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    CaminhaoPlaca = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false),
                    CaminhaoEixos = table.Column<int>(type: "integer", nullable: false),
                    EndLogradouro = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    EndNumero = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    EndBairro = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    EndCidade = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    EndCep = table.Column<string>(type: "character varying(9)", maxLength: 9, nullable: false),
                    EndUf = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorista", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Viagem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PesoCarga = table.Column<decimal>(type: "numeric(9,4)", nullable: false),
                    DtHrViagem = table.Column<DateTime>(type: "TIMESTAMP WITHOUT TIME ZONE", nullable: false),
                    LocalEntrega = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    LocalSaida = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    TotalKm = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    MotoristaId1 = table.Column<long>(type: "bigint", nullable: true),
                    MotoristaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viagem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Viagem_Motorista_MotoristaId1",
                        column: x => x.MotoristaId1,
                        principalTable: "Motorista",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Viagem_MotoristaId1",
                table: "Viagem",
                column: "MotoristaId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Viagem");

            migrationBuilder.DropTable(
                name: "Motorista");
        }
    }
}
