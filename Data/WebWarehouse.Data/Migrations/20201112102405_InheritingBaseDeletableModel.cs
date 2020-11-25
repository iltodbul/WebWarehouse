namespace WebWarehouse.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class InheritingBaseDeletableModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Warehouse",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Warehouse",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Warehouse",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Warehouse",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Transfer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Transfer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Transfer",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Transfer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Sale",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Sale",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Sale",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Sale",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Partner",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Partner",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Partner",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Partner",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Measure",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Measure",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Measure",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Measure",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Good",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Good",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Good",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Good",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Delivery",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Delivery",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Delivery",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Delivery",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Country",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Country",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Country",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Country",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Company",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Company",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Company",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Company",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "City",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "City",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "City",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "City",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_IsDeleted",
                table: "Warehouse",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Transfer_IsDeleted",
                table: "Transfer",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_IsDeleted",
                table: "Sale",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Partner_IsDeleted",
                table: "Partner",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Measure_IsDeleted",
                table: "Measure",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Good_IsDeleted",
                table: "Good",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_IsDeleted",
                table: "Delivery",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Country_IsDeleted",
                table: "Country",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Company_IsDeleted",
                table: "Company",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_City_IsDeleted",
                table: "City",
                column: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Warehouse_IsDeleted",
                table: "Warehouse");

            migrationBuilder.DropIndex(
                name: "IX_Transfer_IsDeleted",
                table: "Transfer");

            migrationBuilder.DropIndex(
                name: "IX_Sale_IsDeleted",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Partner_IsDeleted",
                table: "Partner");

            migrationBuilder.DropIndex(
                name: "IX_Measure_IsDeleted",
                table: "Measure");

            migrationBuilder.DropIndex(
                name: "IX_Good_IsDeleted",
                table: "Good");

            migrationBuilder.DropIndex(
                name: "IX_Delivery_IsDeleted",
                table: "Delivery");

            migrationBuilder.DropIndex(
                name: "IX_Country_IsDeleted",
                table: "Country");

            migrationBuilder.DropIndex(
                name: "IX_Company_IsDeleted",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_City_IsDeleted",
                table: "City");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Transfer");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Transfer");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Transfer");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Transfer");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Partner");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Partner");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Partner");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Partner");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Measure");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Measure");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Measure");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Measure");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Good");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Good");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Good");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Good");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Delivery");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Delivery");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Delivery");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Delivery");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "City");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "City");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "City");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "City");
        }
    }
}
