using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Phamquangha_2122110195_1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Orderdetail");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Orderdetail");

            migrationBuilder.DropColumn(
                name: "ProductDescription",
                table: "Orderdetail");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Orderdetail");

            migrationBuilder.DropColumn(
                name: "CategoryDescription",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "UserPassword",
                table: "Users",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "ProductOrderId",
                table: "Orders",
                newName: "User_id");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Orders",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "ProductDescription",
                table: "Orders",
                newName: "Shipping_address");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Orders",
                newName: "Note");

            migrationBuilder.RenameColumn(
                name: "ProductOrderId",
                table: "Orderdetail",
                newName: "Product_id");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Orderdetail",
                newName: "Product");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Orderdetail",
                newName: "Order_id");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "Slug");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created_at",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Phone",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated_at",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<int>(
                name: "Category_id",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created_at",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated_at",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Created_at",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Orderdate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "Total_amount",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated_at",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Created_at",
                table: "Orderdetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Orderdetail",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<decimal>(
                name: "Quantity",
                table: "Orderdetail",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated_at",
                table: "Orderdetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Created_at",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated_at",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created_at",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Updated_at",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Category_id",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Created_at",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Updated_at",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Created_at",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Orderdate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Total_amount",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Updated_at",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Created_at",
                table: "Orderdetail");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Orderdetail");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Orderdetail");

            migrationBuilder.DropColumn(
                name: "Updated_at",
                table: "Orderdetail");

            migrationBuilder.DropColumn(
                name: "Created_at",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Updated_at",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Users",
                newName: "UserPassword");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Users",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "User_id",
                table: "Orders",
                newName: "ProductOrderId");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Orders",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "Shipping_address",
                table: "Orders",
                newName: "ProductDescription");

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "Orders",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Product_id",
                table: "Orderdetail",
                newName: "ProductOrderId");

            migrationBuilder.RenameColumn(
                name: "Product",
                table: "Orderdetail",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "Order_id",
                table: "Orderdetail",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "Categories",
                newName: "CategoryName");

            migrationBuilder.AlterColumn<double>(
                name: "Password",
                table: "Users",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Products",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Orderdetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Orderdetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductDescription",
                table: "Orderdetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Orderdetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CategoryDescription",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
