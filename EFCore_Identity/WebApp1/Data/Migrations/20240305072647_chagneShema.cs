using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp1.Data.Migrations
{
    public partial class chagneShema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                schema: "Identity",
                newName: "UserTokens",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                schema: "Identity",
                newName: "UserRoles",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                schema: "Identity",
                newName: "UserLogins",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                schema: "Identity",
                newName: "UserClaims",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "User",
                schema: "Identity",
                newName: "User",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Students",
                schema: "Identity",
                newName: "Students",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Role",
                schema: "Identity",
                newName: "Role",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "RoelClaims",
                schema: "Identity",
                newName: "RoelClaims",
                newSchema: "dbo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Identity");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                schema: "dbo",
                newName: "UserTokens",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                schema: "dbo",
                newName: "UserRoles",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                schema: "dbo",
                newName: "UserLogins",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                schema: "dbo",
                newName: "UserClaims",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "User",
                schema: "dbo",
                newName: "User",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Students",
                schema: "dbo",
                newName: "Students",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Role",
                schema: "dbo",
                newName: "Role",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "RoelClaims",
                schema: "dbo",
                newName: "RoelClaims",
                newSchema: "Identity");
        }
    }
}
