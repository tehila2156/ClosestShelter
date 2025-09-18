using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dal_Repository_Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Adress_AddressId",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Reviews",
                newName: "addressId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_AddressId",
                table: "Reviews",
                newName: "IX_Reviews_addressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Adress_addressId",
                table: "Reviews",
                column: "addressId",
                principalTable: "Adress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Adress_addressId",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "addressId",
                table: "Reviews",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_addressId",
                table: "Reviews",
                newName: "IX_Reviews_AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Adress_AddressId",
                table: "Reviews",
                column: "AddressId",
                principalTable: "Adress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
