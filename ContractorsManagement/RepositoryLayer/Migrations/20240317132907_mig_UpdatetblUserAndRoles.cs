using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_UpdatetblUserAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "Users_Tbl");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "Roles_Tbl");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users_Tbl",
                newName: "UserId");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Users_Tbl",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Users_Tbl",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EmployeeDate",
                table: "Users_Tbl",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users_Tbl",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Users_Tbl",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Users_Tbl",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Users_Tbl",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users_Tbl",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NationalCode",
                table: "Users_Tbl",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PersonalCode",
                table: "Users_Tbl",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SignaturePath",
                table: "Users_Tbl",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Roles_Tbl",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RoleLevel",
                table: "Roles_Tbl",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users_Tbl",
                table: "Users_Tbl",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles_Tbl",
                table: "Roles_Tbl",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_Roles_Tbl_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "Roles_Tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_Users_Tbl_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "Users_Tbl",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_Users_Tbl_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "Users_Tbl",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_Roles_Tbl_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "Roles_Tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_Users_Tbl_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "Users_Tbl",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_Users_Tbl_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "Users_Tbl",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_Roles_Tbl_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_Users_Tbl_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_Users_Tbl_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_Roles_Tbl_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_Users_Tbl_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_Users_Tbl_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users_Tbl",
                table: "Users_Tbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles_Tbl",
                table: "Roles_Tbl");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Users_Tbl");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Users_Tbl");

            migrationBuilder.DropColumn(
                name: "EmployeeDate",
                table: "Users_Tbl");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users_Tbl");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Users_Tbl");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Users_Tbl");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Users_Tbl");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users_Tbl");

            migrationBuilder.DropColumn(
                name: "NationalCode",
                table: "Users_Tbl");

            migrationBuilder.DropColumn(
                name: "PersonalCode",
                table: "Users_Tbl");

            migrationBuilder.DropColumn(
                name: "SignaturePath",
                table: "Users_Tbl");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Roles_Tbl");

            migrationBuilder.DropColumn(
                name: "RoleLevel",
                table: "Roles_Tbl");

            migrationBuilder.RenameTable(
                name: "Users_Tbl",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Roles_Tbl",
                newName: "AspNetRoles");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "AspNetUsers",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
