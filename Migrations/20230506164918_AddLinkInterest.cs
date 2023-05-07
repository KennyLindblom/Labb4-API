using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb4__API.Migrations
{
    /// <inheritdoc />
    public partial class AddLinkInterest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LinkId",
                table: "PersonInterests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "PersonInterests",
                keyColumn: "Id",
                keyValue: -12,
                column: "LinkId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PersonInterests",
                keyColumn: "Id",
                keyValue: -11,
                column: "LinkId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PersonInterests",
                keyColumn: "Id",
                keyValue: -10,
                column: "LinkId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PersonInterests",
                keyColumn: "Id",
                keyValue: -9,
                column: "LinkId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PersonInterests",
                keyColumn: "Id",
                keyValue: -8,
                column: "LinkId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PersonInterests",
                keyColumn: "Id",
                keyValue: -7,
                column: "LinkId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PersonInterests",
                keyColumn: "Id",
                keyValue: -6,
                column: "LinkId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PersonInterests",
                keyColumn: "Id",
                keyValue: -5,
                column: "LinkId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PersonInterests",
                keyColumn: "Id",
                keyValue: -4,
                column: "LinkId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PersonInterests",
                keyColumn: "Id",
                keyValue: -3,
                column: "LinkId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PersonInterests",
                keyColumn: "Id",
                keyValue: -2,
                column: "LinkId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PersonInterests",
                keyColumn: "Id",
                keyValue: -1,
                column: "LinkId",
                value: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PersonInterests_LinkId",
                table: "PersonInterests",
                column: "LinkId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonInterests_Links_LinkId",
                table: "PersonInterests",
                column: "LinkId",
                principalTable: "Links",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonInterests_Links_LinkId",
                table: "PersonInterests");

            migrationBuilder.DropIndex(
                name: "IX_PersonInterests_LinkId",
                table: "PersonInterests");

            migrationBuilder.DropColumn(
                name: "LinkId",
                table: "PersonInterests");
        }
    }
}
