using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CifrOblako1.Migrations
{
    /// <inheritdoc />
    public partial class LastNameToSurName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "SurName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SurName",
                table: "AspNetUsers",
                newName: "LastName");
        }
    }
}
