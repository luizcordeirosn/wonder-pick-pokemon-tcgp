using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wonder_pick_pokemon_tcgp.Migrations
{
    /// <inheritdoc />
    public partial class AddWonderPickTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "wonder_picks",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    posicao_inicial = table.Column<int>(type: "integer", nullable: false),
                    posicao_final = table.Column<int>(type: "integer", nullable: false),
                    data_criacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wonder_picks", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wonder_picks");
        }
    }
}
