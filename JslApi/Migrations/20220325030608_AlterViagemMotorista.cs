using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JslApi.Migrations
{
    public partial class AlterViagemMotorista : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Viagem_Motorista_MotoristaId1",
                table: "Viagem");

            migrationBuilder.DropIndex(
                name: "IX_Viagem_MotoristaId1",
                table: "Viagem");

            migrationBuilder.DropColumn(
                name: "MotoristaId1",
                table: "Viagem");

            migrationBuilder.AlterColumn<long>(
                name: "MotoristaId",
                table: "Viagem",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_Viagem_MotoristaId",
                table: "Viagem",
                column: "MotoristaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Viagem_Motorista_MotoristaId",
                table: "Viagem",
                column: "MotoristaId",
                principalTable: "Motorista",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Viagem_Motorista_MotoristaId",
                table: "Viagem");

            migrationBuilder.DropIndex(
                name: "IX_Viagem_MotoristaId",
                table: "Viagem");

            migrationBuilder.AlterColumn<int>(
                name: "MotoristaId",
                table: "Viagem",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "MotoristaId1",
                table: "Viagem",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Viagem_MotoristaId1",
                table: "Viagem",
                column: "MotoristaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Viagem_Motorista_MotoristaId1",
                table: "Viagem",
                column: "MotoristaId1",
                principalTable: "Motorista",
                principalColumn: "Id");
        }
    }
}
