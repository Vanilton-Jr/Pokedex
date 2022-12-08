using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokemon.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokedex",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Default = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Shiny = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    mega = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    altura = table.Column<double>(type: "float", nullable: true),
                    Peso = table.Column<double>(type: "float", nullable: true),
                    sp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    num = table.Column<int>(type: "int", nullable: false),
                    hp = table.Column<int>(type: "int", nullable: true),
                    atk = table.Column<int>(type: "int", nullable: true),
                    dfs = table.Column<int>(type: "int", nullable: true),
                    vel = table.Column<int>(type: "int", nullable: true),
                    atkE = table.Column<int>(type: "int", nullable: true),
                    dfsE = table.Column<int>(type: "int", nullable: true),
                    move1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    move2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    move3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    move4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    move5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    move6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    move7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    move8 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokedex", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokedex");
        }
    }
}
