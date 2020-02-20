using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Admin.Data.Migrations
{
    public partial class creadb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ae5e975-91b0-4928-a843-595748e554d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8af30aa-7ee4-4197-a353-4455a92c6086");

            migrationBuilder.CreateTable(
                name: "StaffUserRegs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateSuspended = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Suspended = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    OtherNames = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffUserRegs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dd1b6f1e-60bb-4a03-8467-6103e015f9e5", "30325233-d6dd-472b-85c6-985285700b93", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "087bbc3a-ad43-4c06-88ed-233a1ce1d33c", "d9a75555-9d6f-4907-abec-d9955d6e57f0", "Staff", "STAFF" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StaffUserRegs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "087bbc3a-ad43-4c06-88ed-233a1ce1d33c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd1b6f1e-60bb-4a03-8467-6103e015f9e5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8af30aa-7ee4-4197-a353-4455a92c6086", "4d607965-e2fa-40fb-8715-b03493f5a920", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ae5e975-91b0-4928-a843-595748e554d3", "7d69bda4-01a1-4e4f-861a-ab1c03e7f77a", "Staff", "STAFF" });
        }
    }
}
