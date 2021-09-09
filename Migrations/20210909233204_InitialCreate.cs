using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectServBeer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pagamentos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fornecedorid = table.Column<int>(type: "int", nullable: true),
                    dataEmissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataVencimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    valor = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamentos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pagamentos_Fornecedores_fornecedorid",
                        column: x => x.fornecedorid,
                        principalTable: "Fornecedores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_prod = table.Column<int>(type: "int", nullable: false),
                    tipo_prodid = table.Column<int>(type: "int", nullable: true),
                    fornecedorid = table.Column<int>(type: "int", nullable: true),
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    valor_prod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Produtos_Categorias_tipo_prodid",
                        column: x => x.tipo_prodid,
                        principalTable: "Categorias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Produtos_Fornecedores_fornecedorid",
                        column: x => x.fornecedorid,
                        principalTable: "Fornecedores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    valor = table.Column<float>(type: "real", nullable: false),
                    valor_promocao = table.Column<float>(type: "real", nullable: false),
                    funcionarioid = table.Column<int>(type: "int", nullable: true),
                    clienteid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Servicos_Clientes_clienteid",
                        column: x => x.clienteid,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Servicos_Funcionarios_funcionarioid",
                        column: x => x.funcionarioid,
                        principalTable: "Funcionarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItensVendas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    valor = table.Column<float>(type: "real", nullable: false),
                    produtoid = table.Column<int>(type: "int", nullable: true),
                    servicoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensVendas", x => x.id);
                    table.ForeignKey(
                        name: "FK_ItensVendas_Produtos_produtoid",
                        column: x => x.produtoid,
                        principalTable: "Produtos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItensVendas_Servicos_servicoid",
                        column: x => x.servicoid,
                        principalTable: "Servicos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recebimentos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    servicoid = table.Column<int>(type: "int", nullable: true),
                    valor = table.Column<float>(type: "real", nullable: false),
                    data_recebimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recebimentos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Recebimentos_Servicos_servicoid",
                        column: x => x.servicoid,
                        principalTable: "Servicos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItensVendas_produtoid",
                table: "ItensVendas",
                column: "produtoid");

            migrationBuilder.CreateIndex(
                name: "IX_ItensVendas_servicoid",
                table: "ItensVendas",
                column: "servicoid");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_fornecedorid",
                table: "Pagamentos",
                column: "fornecedorid");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_fornecedorid",
                table: "Produtos",
                column: "fornecedorid");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_tipo_prodid",
                table: "Produtos",
                column: "tipo_prodid");

            migrationBuilder.CreateIndex(
                name: "IX_Recebimentos_servicoid",
                table: "Recebimentos",
                column: "servicoid");

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_clienteid",
                table: "Servicos",
                column: "clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_funcionarioid",
                table: "Servicos",
                column: "funcionarioid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItensVendas");

            migrationBuilder.DropTable(
                name: "Pagamentos");

            migrationBuilder.DropTable(
                name: "Recebimentos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Servicos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Fornecedores");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Funcionarios");
        }
    }
}
