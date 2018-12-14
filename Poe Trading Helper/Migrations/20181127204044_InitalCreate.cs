using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PoeTradingHelper.Migrations
{
    public partial class InitalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CurrencyId",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    IngameId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Price",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PriceInChaos = table.Column<float>(nullable: false),
                    PriceInExalted = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Price", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurrencyRatios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PayId = table.Column<int>(nullable: true),
                    PayAmount = table.Column<float>(nullable: false),
                    GetId = table.Column<int>(nullable: true),
                    GetAmount = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyRatios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrencyRatios_Currencies_GetId",
                        column: x => x.GetId,
                        principalTable: "CurrencyId",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CurrencyRatios_Currencies_PayId",
                        column: x => x.PayId,
                        principalTable: "CurrencyId",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DivinationCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IngameId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PriceId = table.Column<int>(nullable: true),
                    FlavorText = table.Column<string>(nullable: true),
                    CardsPerSet = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivinationCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DivinationCards_Price_PriceId",
                        column: x => x.PriceId,
                        principalTable: "Price",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CurrencyRatios_GetId",
                table: "CurrencyRatios",
                column: "GetId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrencyRatios_PayId",
                table: "CurrencyRatios",
                column: "PayId");

            migrationBuilder.CreateIndex(
                name: "IX_DivinationCards_PriceId",
                table: "DivinationCards",
                column: "PriceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrencyRatios");

            migrationBuilder.DropTable(
                name: "DivinationCards");

            migrationBuilder.DropTable(
                name: "CurrencyId");

            migrationBuilder.DropTable(
                name: "Price");
        }
    }
}
