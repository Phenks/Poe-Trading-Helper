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
                table: "CurrencyId");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CurrencyId");

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
                table: "CurrencyId",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "IconUrl",
                table: "CurrencyId",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currencies",
                table: "CurrencyId",
                column: "PoeNinjaId");

            migrationBuilder.AddForeignKey(
                name: "FK_CurrencyRatios_Currencies_GetInGameId",
                table: "CurrencyRatios",
                column: "GetInGameId",
                principalTable: "CurrencyId",
                principalColumn: "PoeNinjaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CurrencyRatios_Currencies_PayInGameId",
                table: "CurrencyRatios",
                column: "PayInGameId",
                principalTable: "CurrencyId",
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
                table: "CurrencyId");

            migrationBuilder.DropColumn(
                name: "IconUrl",
                table: "CurrencyId");

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
                table: "CurrencyId",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CurrencyId",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currencies",
                table: "CurrencyId",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CurrencyRatios_Currencies_GetId",
                table: "CurrencyRatios",
                column: "GetId",
                principalTable: "CurrencyId",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CurrencyRatios_Currencies_PayId",
                table: "CurrencyRatios",
                column: "PayId",
                principalTable: "CurrencyId",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
