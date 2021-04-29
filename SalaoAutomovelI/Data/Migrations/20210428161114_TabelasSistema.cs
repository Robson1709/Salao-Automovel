using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalaoAutomovelI.Data.Migrations
{
    public partial class TabelasSistema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(maxLength: 150, nullable: false),
                    CPF = table.Column<string>(maxLength: 14, nullable: false),
                    Telefone = table.Column<string>(maxLength: 11, nullable: false),
                    CarroId = table.Column<Guid>(nullable: true),
                    MotoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carros",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Placa = table.Column<string>(maxLength: 7, nullable: false),
                    Ano = table.Column<string>(nullable: false),
                    Cor = table.Column<string>(maxLength: 20, nullable: false),
                    KM = table.Column<int>(maxLength: 6, nullable: false),
                    TipoCambio = table.Column<int>(nullable: false),
                    TipoCombustivel = table.Column<int>(nullable: false),
                    PrecoCompra = table.Column<decimal>(nullable: false),
                    PrecoVenda = table.Column<decimal>(nullable: false),
                    ClienteId = table.Column<Guid>(nullable: false),
                    TipoCarroceria = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carros_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Motos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Placa = table.Column<string>(maxLength: 7, nullable: false),
                    Ano = table.Column<string>(nullable: false),
                    Cor = table.Column<string>(maxLength: 20, nullable: false),
                    KM = table.Column<int>(maxLength: 6, nullable: false),
                    TipoCambio = table.Column<int>(nullable: false),
                    TipoCombustivel = table.Column<int>(nullable: false),
                    PrecoCompra = table.Column<decimal>(nullable: false),
                    PrecoVenda = table.Column<decimal>(nullable: false),
                    ClienteId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carros_ClienteId",
                table: "Carros",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CarroId",
                table: "Clientes",
                column: "CarroId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_MotoId",
                table: "Clientes",
                column: "MotoId");

            migrationBuilder.CreateIndex(
                name: "IX_Motos_ClienteId",
                table: "Motos",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Carros_CarroId",
                table: "Clientes",
                column: "CarroId",
                principalTable: "Carros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Motos_MotoId",
                table: "Clientes",
                column: "MotoId",
                principalTable: "Motos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carros_Clientes_ClienteId",
                table: "Carros");

            migrationBuilder.DropForeignKey(
                name: "FK_Motos_Clientes_ClienteId",
                table: "Motos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Carros");

            migrationBuilder.DropTable(
                name: "Motos");
        }
    }
}
