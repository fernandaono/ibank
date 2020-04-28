using Microsoft.EntityFrameworkCore.Migrations;

namespace IbankLogin.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2,
                columns: new[] { "Conta", "Nome", "Senha" },
                values: new object[] { 456789, "Maria", 2233 });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Agencia", "Conta", "Nome", "Senha" },
                values: new object[] { 1, 1234, 987654, "Antonio", 1122 });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Agencia", "Conta", "Nome", "Senha" },
                values: new object[] { 3, 1234, 111145, "Ana", 4875 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2,
                columns: new[] { "Conta", "Nome", "Senha" },
                values: new object[] { 987654, "Antonio", 1122 });
        }
    }
}
