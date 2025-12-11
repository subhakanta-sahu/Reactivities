using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class tablecloumechanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Activities",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "Catagory",
                table: "Activities",
                newName: "Category");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Activities",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Activities",
                newName: "Catagory");
        }
    }
}
