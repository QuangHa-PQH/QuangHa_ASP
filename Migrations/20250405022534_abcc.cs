using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Phamquangha_2122110195_1.Migrations
{
    /// <inheritdoc />
    public partial class abcc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Product",
                table: "Orderdetail");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Product",
                table: "Orderdetail",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
