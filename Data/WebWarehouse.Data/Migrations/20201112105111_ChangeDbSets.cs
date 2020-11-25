namespace WebWarehouse.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class ChangeDbSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_City_CityId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Country_CountryId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Warehouse_WarehouseId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_City_CityId",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_Country_CountryId",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_Delivery_Partner_PartnerId",
                table: "Delivery");

            migrationBuilder.DropForeignKey(
                name: "FK_Delivery_AspNetUsers_UserId",
                table: "Delivery");

            migrationBuilder.DropForeignKey(
                name: "FK_Delivery_Warehouse_WarehouseId",
                table: "Delivery");

            migrationBuilder.DropForeignKey(
                name: "FK_Good_Delivery_DeliveryId",
                table: "Good");

            migrationBuilder.DropForeignKey(
                name: "FK_Good_Measure_MeasureId",
                table: "Good");

            migrationBuilder.DropForeignKey(
                name: "FK_Good_Sale_SaleId",
                table: "Good");

            migrationBuilder.DropForeignKey(
                name: "FK_Good_Transfer_TransferId",
                table: "Good");

            migrationBuilder.DropForeignKey(
                name: "FK_Good_Warehouse_WarehouseId",
                table: "Good");

            migrationBuilder.DropForeignKey(
                name: "FK_Partner_City_CityId",
                table: "Partner");

            migrationBuilder.DropForeignKey(
                name: "FK_Partner_Country_CountryId",
                table: "Partner");

            migrationBuilder.DropForeignKey(
                name: "FK_Partner_Warehouse_WarehouseId",
                table: "Partner");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Partner_PartnerId",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_AspNetUsers_UserId",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Warehouse_WarehouseId",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfer_Warehouse_InWarehouseId",
                table: "Transfer");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfer_Warehouse_OutWarehouseId",
                table: "Transfer");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfer_AspNetUsers_UserId",
                table: "Transfer");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouse_City_CityId",
                table: "Warehouse");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouse_Company_CompanyId",
                table: "Warehouse");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouse_Country_CountryId",
                table: "Warehouse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Warehouse",
                table: "Warehouse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transfer",
                table: "Transfer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sale",
                table: "Sale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Partner",
                table: "Partner");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Measure",
                table: "Measure");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Good",
                table: "Good");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Delivery",
                table: "Delivery");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.RenameTable(
                name: "Warehouse",
                newName: "Warehouses");

            migrationBuilder.RenameTable(
                name: "Transfer",
                newName: "Transfers");

            migrationBuilder.RenameTable(
                name: "Sale",
                newName: "Sales");

            migrationBuilder.RenameTable(
                name: "Partner",
                newName: "Partners");

            migrationBuilder.RenameTable(
                name: "Measure",
                newName: "Measures");

            migrationBuilder.RenameTable(
                name: "Good",
                newName: "Goods");

            migrationBuilder.RenameTable(
                name: "Delivery",
                newName: "Deliveries");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Countries");

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "Companies");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Cities");

            migrationBuilder.RenameIndex(
                name: "IX_Warehouse_IsDeleted",
                table: "Warehouses",
                newName: "IX_Warehouses_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Warehouse_CountryId",
                table: "Warehouses",
                newName: "IX_Warehouses_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Warehouse_CompanyId",
                table: "Warehouses",
                newName: "IX_Warehouses_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Warehouse_CityId",
                table: "Warehouses",
                newName: "IX_Warehouses_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Transfer_UserId",
                table: "Transfers",
                newName: "IX_Transfers_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Transfer_OutWarehouseId",
                table: "Transfers",
                newName: "IX_Transfers_OutWarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_Transfer_IsDeleted",
                table: "Transfers",
                newName: "IX_Transfers_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Transfer_InWarehouseId",
                table: "Transfers",
                newName: "IX_Transfers_InWarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_Sale_WarehouseId",
                table: "Sales",
                newName: "IX_Sales_WarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_Sale_UserId",
                table: "Sales",
                newName: "IX_Sales_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Sale_PartnerId",
                table: "Sales",
                newName: "IX_Sales_PartnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Sale_IsDeleted",
                table: "Sales",
                newName: "IX_Sales_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Partner_WarehouseId",
                table: "Partners",
                newName: "IX_Partners_WarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_Partner_IsDeleted",
                table: "Partners",
                newName: "IX_Partners_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Partner_CountryId",
                table: "Partners",
                newName: "IX_Partners_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Partner_CityId",
                table: "Partners",
                newName: "IX_Partners_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Measure_IsDeleted",
                table: "Measures",
                newName: "IX_Measures_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Good_WarehouseId",
                table: "Goods",
                newName: "IX_Goods_WarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_Good_TransferId",
                table: "Goods",
                newName: "IX_Goods_TransferId");

            migrationBuilder.RenameIndex(
                name: "IX_Good_SaleId",
                table: "Goods",
                newName: "IX_Goods_SaleId");

            migrationBuilder.RenameIndex(
                name: "IX_Good_MeasureId",
                table: "Goods",
                newName: "IX_Goods_MeasureId");

            migrationBuilder.RenameIndex(
                name: "IX_Good_IsDeleted",
                table: "Goods",
                newName: "IX_Goods_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Good_DeliveryId",
                table: "Goods",
                newName: "IX_Goods_DeliveryId");

            migrationBuilder.RenameIndex(
                name: "IX_Delivery_WarehouseId",
                table: "Deliveries",
                newName: "IX_Deliveries_WarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_Delivery_UserId",
                table: "Deliveries",
                newName: "IX_Deliveries_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Delivery_PartnerId",
                table: "Deliveries",
                newName: "IX_Deliveries_PartnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Delivery_IsDeleted",
                table: "Deliveries",
                newName: "IX_Deliveries_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Country_IsDeleted",
                table: "Countries",
                newName: "IX_Countries_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Company_IsDeleted",
                table: "Companies",
                newName: "IX_Companies_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Company_CountryId",
                table: "Companies",
                newName: "IX_Companies_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Company_CityId",
                table: "Companies",
                newName: "IX_Companies_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_City_IsDeleted",
                table: "Cities",
                newName: "IX_Cities_IsDeleted");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Warehouses",
                table: "Warehouses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transfers",
                table: "Transfers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sales",
                table: "Sales",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Partners",
                table: "Partners",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Measures",
                table: "Measures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Goods",
                table: "Goods",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Deliveries",
                table: "Deliveries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Cities_CityId",
                table: "AspNetUsers",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Countries_CountryId",
                table: "AspNetUsers",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Warehouses_WarehouseId",
                table: "AspNetUsers",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Cities_CityId",
                table: "Companies",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Countries_CountryId",
                table: "Companies",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_Partners_PartnerId",
                table: "Deliveries",
                column: "PartnerId",
                principalTable: "Partners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId",
                table: "Deliveries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_Warehouses_WarehouseId",
                table: "Deliveries",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_Deliveries_DeliveryId",
                table: "Goods",
                column: "DeliveryId",
                principalTable: "Deliveries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_Measures_MeasureId",
                table: "Goods",
                column: "MeasureId",
                principalTable: "Measures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_Sales_SaleId",
                table: "Goods",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_Transfers_TransferId",
                table: "Goods",
                column: "TransferId",
                principalTable: "Transfers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_Warehouses_WarehouseId",
                table: "Goods",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partners_Cities_CityId",
                table: "Partners",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partners_Countries_CountryId",
                table: "Partners",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partners_Warehouses_WarehouseId",
                table: "Partners",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Partners_PartnerId",
                table: "Sales",
                column: "PartnerId",
                principalTable: "Partners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_AspNetUsers_UserId",
                table: "Sales",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Warehouses_WarehouseId",
                table: "Sales",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_Warehouses_InWarehouseId",
                table: "Transfers",
                column: "InWarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_Warehouses_OutWarehouseId",
                table: "Transfers",
                column: "OutWarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_AspNetUsers_UserId",
                table: "Transfers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_Cities_CityId",
                table: "Warehouses",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_Companies_CompanyId",
                table: "Warehouses",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_Countries_CountryId",
                table: "Warehouses",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Cities_CityId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Countries_CountryId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Warehouses_WarehouseId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Cities_CityId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Countries_CountryId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_Partners_PartnerId",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_UserId",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_Warehouses_WarehouseId",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Goods_Deliveries_DeliveryId",
                table: "Goods");

            migrationBuilder.DropForeignKey(
                name: "FK_Goods_Measures_MeasureId",
                table: "Goods");

            migrationBuilder.DropForeignKey(
                name: "FK_Goods_Sales_SaleId",
                table: "Goods");

            migrationBuilder.DropForeignKey(
                name: "FK_Goods_Transfers_TransferId",
                table: "Goods");

            migrationBuilder.DropForeignKey(
                name: "FK_Goods_Warehouses_WarehouseId",
                table: "Goods");

            migrationBuilder.DropForeignKey(
                name: "FK_Partners_Cities_CityId",
                table: "Partners");

            migrationBuilder.DropForeignKey(
                name: "FK_Partners_Countries_CountryId",
                table: "Partners");

            migrationBuilder.DropForeignKey(
                name: "FK_Partners_Warehouses_WarehouseId",
                table: "Partners");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Partners_PartnerId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_AspNetUsers_UserId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Warehouses_WarehouseId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_Warehouses_InWarehouseId",
                table: "Transfers");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_Warehouses_OutWarehouseId",
                table: "Transfers");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_AspNetUsers_UserId",
                table: "Transfers");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_Cities_CityId",
                table: "Warehouses");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_Companies_CompanyId",
                table: "Warehouses");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_Countries_CountryId",
                table: "Warehouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Warehouses",
                table: "Warehouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transfers",
                table: "Transfers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sales",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Partners",
                table: "Partners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Measures",
                table: "Measures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Goods",
                table: "Goods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Deliveries",
                table: "Deliveries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.RenameTable(
                name: "Warehouses",
                newName: "Warehouse");

            migrationBuilder.RenameTable(
                name: "Transfers",
                newName: "Transfer");

            migrationBuilder.RenameTable(
                name: "Sales",
                newName: "Sale");

            migrationBuilder.RenameTable(
                name: "Partners",
                newName: "Partner");

            migrationBuilder.RenameTable(
                name: "Measures",
                newName: "Measure");

            migrationBuilder.RenameTable(
                name: "Goods",
                newName: "Good");

            migrationBuilder.RenameTable(
                name: "Deliveries",
                newName: "Delivery");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Country");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Company");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "City");

            migrationBuilder.RenameIndex(
                name: "IX_Warehouses_IsDeleted",
                table: "Warehouse",
                newName: "IX_Warehouse_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Warehouses_CountryId",
                table: "Warehouse",
                newName: "IX_Warehouse_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Warehouses_CompanyId",
                table: "Warehouse",
                newName: "IX_Warehouse_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Warehouses_CityId",
                table: "Warehouse",
                newName: "IX_Warehouse_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Transfers_UserId",
                table: "Transfer",
                newName: "IX_Transfer_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Transfers_OutWarehouseId",
                table: "Transfer",
                newName: "IX_Transfer_OutWarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_Transfers_IsDeleted",
                table: "Transfer",
                newName: "IX_Transfer_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Transfers_InWarehouseId",
                table: "Transfer",
                newName: "IX_Transfer_InWarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_WarehouseId",
                table: "Sale",
                newName: "IX_Sale_WarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_UserId",
                table: "Sale",
                newName: "IX_Sale_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_PartnerId",
                table: "Sale",
                newName: "IX_Sale_PartnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_IsDeleted",
                table: "Sale",
                newName: "IX_Sale_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Partners_WarehouseId",
                table: "Partner",
                newName: "IX_Partner_WarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_Partners_IsDeleted",
                table: "Partner",
                newName: "IX_Partner_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Partners_CountryId",
                table: "Partner",
                newName: "IX_Partner_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Partners_CityId",
                table: "Partner",
                newName: "IX_Partner_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Measures_IsDeleted",
                table: "Measure",
                newName: "IX_Measure_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Goods_WarehouseId",
                table: "Good",
                newName: "IX_Good_WarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_Goods_TransferId",
                table: "Good",
                newName: "IX_Good_TransferId");

            migrationBuilder.RenameIndex(
                name: "IX_Goods_SaleId",
                table: "Good",
                newName: "IX_Good_SaleId");

            migrationBuilder.RenameIndex(
                name: "IX_Goods_MeasureId",
                table: "Good",
                newName: "IX_Good_MeasureId");

            migrationBuilder.RenameIndex(
                name: "IX_Goods_IsDeleted",
                table: "Good",
                newName: "IX_Good_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Goods_DeliveryId",
                table: "Good",
                newName: "IX_Good_DeliveryId");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_WarehouseId",
                table: "Delivery",
                newName: "IX_Delivery_WarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_UserId",
                table: "Delivery",
                newName: "IX_Delivery_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_PartnerId",
                table: "Delivery",
                newName: "IX_Delivery_PartnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_IsDeleted",
                table: "Delivery",
                newName: "IX_Delivery_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Countries_IsDeleted",
                table: "Country",
                newName: "IX_Country_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_IsDeleted",
                table: "Company",
                newName: "IX_Company_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_CountryId",
                table: "Company",
                newName: "IX_Company_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_CityId",
                table: "Company",
                newName: "IX_Company_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_IsDeleted",
                table: "City",
                newName: "IX_City_IsDeleted");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Warehouse",
                table: "Warehouse",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transfer",
                table: "Transfer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sale",
                table: "Sale",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Partner",
                table: "Partner",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Measure",
                table: "Measure",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Good",
                table: "Good",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Delivery",
                table: "Delivery",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_City_CityId",
                table: "AspNetUsers",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Country_CountryId",
                table: "AspNetUsers",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Warehouse_WarehouseId",
                table: "AspNetUsers",
                column: "WarehouseId",
                principalTable: "Warehouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_City_CityId",
                table: "Company",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Country_CountryId",
                table: "Company",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Delivery_Partner_PartnerId",
                table: "Delivery",
                column: "PartnerId",
                principalTable: "Partner",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Delivery_AspNetUsers_UserId",
                table: "Delivery",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Delivery_Warehouse_WarehouseId",
                table: "Delivery",
                column: "WarehouseId",
                principalTable: "Warehouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Good_Delivery_DeliveryId",
                table: "Good",
                column: "DeliveryId",
                principalTable: "Delivery",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Good_Measure_MeasureId",
                table: "Good",
                column: "MeasureId",
                principalTable: "Measure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Good_Sale_SaleId",
                table: "Good",
                column: "SaleId",
                principalTable: "Sale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Good_Transfer_TransferId",
                table: "Good",
                column: "TransferId",
                principalTable: "Transfer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Good_Warehouse_WarehouseId",
                table: "Good",
                column: "WarehouseId",
                principalTable: "Warehouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partner_City_CityId",
                table: "Partner",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partner_Country_CountryId",
                table: "Partner",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partner_Warehouse_WarehouseId",
                table: "Partner",
                column: "WarehouseId",
                principalTable: "Warehouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Partner_PartnerId",
                table: "Sale",
                column: "PartnerId",
                principalTable: "Partner",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_AspNetUsers_UserId",
                table: "Sale",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Warehouse_WarehouseId",
                table: "Sale",
                column: "WarehouseId",
                principalTable: "Warehouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfer_Warehouse_InWarehouseId",
                table: "Transfer",
                column: "InWarehouseId",
                principalTable: "Warehouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfer_Warehouse_OutWarehouseId",
                table: "Transfer",
                column: "OutWarehouseId",
                principalTable: "Warehouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfer_AspNetUsers_UserId",
                table: "Transfer",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouse_City_CityId",
                table: "Warehouse",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouse_Company_CompanyId",
                table: "Warehouse",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouse_Country_CountryId",
                table: "Warehouse",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
