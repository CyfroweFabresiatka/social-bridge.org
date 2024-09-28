using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialBridge.Main.Migrations
{
    /// <inheritdoc />
    public partial class MakeReferencesNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_applications_grants_grant_id",
                table: "applications");

            migrationBuilder.DropForeignKey(
                name: "FK_applications_projects_project_id",
                table: "applications");

            migrationBuilder.DropForeignKey(
                name: "FK_users_companies_company_id",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "FK_users_ngos_ngo_id",
                table: "users");

            migrationBuilder.AlterColumn<Guid>(
                name: "ngo_id",
                table: "users",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "company_id",
                table: "users",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "project_id",
                table: "applications",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "grant_id",
                table: "applications",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_applications_grants_grant_id",
                table: "applications",
                column: "grant_id",
                principalTable: "grants",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_applications_projects_project_id",
                table: "applications",
                column: "project_id",
                principalTable: "projects",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_users_companies_company_id",
                table: "users",
                column: "company_id",
                principalTable: "companies",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_users_ngos_ngo_id",
                table: "users",
                column: "ngo_id",
                principalTable: "ngos",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_applications_grants_grant_id",
                table: "applications");

            migrationBuilder.DropForeignKey(
                name: "FK_applications_projects_project_id",
                table: "applications");

            migrationBuilder.DropForeignKey(
                name: "FK_users_companies_company_id",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "FK_users_ngos_ngo_id",
                table: "users");

            migrationBuilder.AlterColumn<Guid>(
                name: "ngo_id",
                table: "users",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "company_id",
                table: "users",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "project_id",
                table: "applications",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "grant_id",
                table: "applications",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_applications_grants_grant_id",
                table: "applications",
                column: "grant_id",
                principalTable: "grants",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_applications_projects_project_id",
                table: "applications",
                column: "project_id",
                principalTable: "projects",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_companies_company_id",
                table: "users",
                column: "company_id",
                principalTable: "companies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_ngos_ngo_id",
                table: "users",
                column: "ngo_id",
                principalTable: "ngos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
