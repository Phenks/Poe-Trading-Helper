using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PoeTradingHelper.Migrations
{
    public partial class CurrencyModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurrencyRatios_Currencies_GetId",
                table: "CurrencyRatios");

            migrationBuilder.DropForeignKey(
                name: "FK_CurrencyRatios_Currencies_PayId",
                table: "CurrencyRatios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Currencies");

            migrationBuilder.RenameColumn(
                name: "PoeNinjaId",
                table: "DivinationCards",
                newName: "InGameId");

            migrationBuilder.RenameColumn(
                name: "PayId",
                table: "CurrencyRatios",
                newName: "PayInGameId");

            migrationBuilder.RenameColumn(
                name: "GetId",
                table: "CurrencyRatios",
                newName: "GetInGameId");

            migrationBuilder.RenameIndex(
                name: "IX_CurrencyRatios_PayId",
                table: "CurrencyRatios",
                newName: "IX_CurrencyRatios_PayInGameId");

            migrationBuilder.RenameIndex(
                name: "IX_CurrencyRatios_GetId",
                table: "CurrencyRatios",
                newName: "IX_CurrencyRatios_GetInGameId");

            migrationBuilder.AlterColumn<int>(
                name: "PoeNinjaId",
                table: "Currencies",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "IconUrl",
                table: "Currencies",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies",
                column: "PoeNinjaId");

            migrationBuilder.AddForeignKey(
                name: "FK_CurrencyRatios_Currencies_GetInGameId",
                table: "CurrencyRatios",
                column: "GetInGameId",
                principalTable: "Currencies",
                principalColumn: "PoeNinjaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CurrencyRatios_Currencies_PayInGameId",
                table: "CurrencyRatios",
                column: "PayInGameId",
                principalTable: "Currencies",
                principalColumn: "PoeNinjaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurrencyRatios_Currencies_GetInGameId",
                table: "CurrencyRatios");

            migrationBuilder.DropForeignKey(
                name: "FK_CurrencyRatios_Currencies_PayInGameId",
                table: "CurrencyRatios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "IconUrl",
                table: "Currencies");

            migrationBuilder.RenameColumn(
                name: "InGameId",
                table: "DivinationCards",
                newName: "PoeNinjaId");

            migrationBuilder.RenameColumn(
                name: "PayInGameId",
                table: "CurrencyRatios",
                newName: "PayId");

            migrationBuilder.RenameColumn(
                name: "GetInGameId",
                table: "CurrencyRatios",
                newName: "GetId");

            migrationBuilder.RenameIndex(
                name: "IX_CurrencyRatios_PayInGameId",
                table: "CurrencyRatios",
                newName: "IX_CurrencyRatios_PayId");

            migrationBuilder.RenameIndex(
                name: "IX_CurrencyRatios_GetInGameId",
                table: "CurrencyRatios",
                newName: "IX_CurrencyRatios_GetId");

            migrationBuilder.AlterColumn<int>(
                name: "PoeNinjaId",
                table: "Currencies",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Currencies",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CurrencyRatios_Currencies_GetId",
                table: "CurrencyRatios",
                column: "GetId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CurrencyRatios_Currencies_PayId",
                table: "CurrencyRatios",
                column: "PayId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
