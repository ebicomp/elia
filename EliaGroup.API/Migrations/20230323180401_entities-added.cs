using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EliaGroup.API.Migrations
{
    /// <inheritdoc />
    public partial class entitiesadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asset_AssetType_AssetTypeId",
                table: "Asset");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssetType",
                table: "AssetType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Asset",
                table: "Asset");

            migrationBuilder.RenameTable(
                name: "AssetType",
                newName: "AssetTypes");

            migrationBuilder.RenameTable(
                name: "Asset",
                newName: "Assets");

            migrationBuilder.RenameIndex(
                name: "IX_Asset_AssetTypeId",
                table: "Assets",
                newName: "IX_Assets_AssetTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssetTypes",
                table: "AssetTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assets",
                table: "Assets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_AssetTypes_AssetTypeId",
                table: "Assets",
                column: "AssetTypeId",
                principalTable: "AssetTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_AssetTypes_AssetTypeId",
                table: "Assets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssetTypes",
                table: "AssetTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assets",
                table: "Assets");

            migrationBuilder.RenameTable(
                name: "AssetTypes",
                newName: "AssetType");

            migrationBuilder.RenameTable(
                name: "Assets",
                newName: "Asset");

            migrationBuilder.RenameIndex(
                name: "IX_Assets_AssetTypeId",
                table: "Asset",
                newName: "IX_Asset_AssetTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssetType",
                table: "AssetType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Asset",
                table: "Asset",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_AssetType_AssetTypeId",
                table: "Asset",
                column: "AssetTypeId",
                principalTable: "AssetType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
