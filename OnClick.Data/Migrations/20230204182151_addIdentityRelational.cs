using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnClick.Data.Migrations
{
    /// <inheritdoc />
    public partial class addIdentityRelational : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "User",
                newName: "Number");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "User",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_User_ApplicationUserId",
                table: "User",
                column: "ApplicationUserId",
                unique: true,
                filter: "[ApplicationUserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_User_AspNetUsers_ApplicationUserId",
                table: "User",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_AspNetUsers_ApplicationUserId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_ApplicationUserId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "User",
                newName: "Password");
        }
    }
}
