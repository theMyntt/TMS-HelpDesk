using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMS.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_USUARIOS",
                columns: table => new
                {
                    ID_USUARIO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TX_NOME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TX_EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TX_SENHA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TX_REGISTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TX_ATUALIZACAO = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_USUARIOS", x => x.ID_USUARIO);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_USUARIOS");
        }
    }
}
