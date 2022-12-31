using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternshipPlatform_API.Migrations
{
    public partial class EditorRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "413743e0-asd2–42fe-afbf-59kmccmk72cd6", "413743e0-asd2–42fe-afbf-59kmccmk72cd6", "Editor", "EDITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "413743e0-asd2–42fe-afbf-59kmccmk72cd6");
        }
    }
}
