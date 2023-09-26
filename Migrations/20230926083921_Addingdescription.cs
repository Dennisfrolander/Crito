using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crito.Migrations
{
    /// <inheritdoc />
    public partial class Addingdescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "contacts",
                newName: "description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "description",
                table: "contacts",
                newName: "Description");
        }
    }
}
