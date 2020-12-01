using Microsoft.EntityFrameworkCore.Migrations;

namespace WebWarehouse.Data.Migrations
{
    public partial class ChangInGoods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Goods");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Discount",
                table: "Goods",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
