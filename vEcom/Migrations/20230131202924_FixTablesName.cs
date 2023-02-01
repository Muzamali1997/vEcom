using Microsoft.EntityFrameworkCore.Migrations;

namespace vEcom.Migrations
{
    public partial class FixTablesName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Product_ProductsProductId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Color_Product_ProductsProductId",
                table: "Color");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_Category_CategoryId",
                table: "Product_Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_Product_ProductId",
                table: "Product_Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehModel",
                table: "VehModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product_Category",
                table: "Product_Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Color",
                table: "Color");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brand",
                table: "Brand");

            migrationBuilder.RenameTable(
                name: "VehModel",
                newName: "vEcom_VehModel");

            migrationBuilder.RenameTable(
                name: "Vehicle",
                newName: "vEcom_Vehicle");

            migrationBuilder.RenameTable(
                name: "Product_Category",
                newName: "vEcom_Product_Category");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "vEcom_Product");

            migrationBuilder.RenameTable(
                name: "Color",
                newName: "vEcom_Color");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "vEcom_Category");

            migrationBuilder.RenameTable(
                name: "Brand",
                newName: "vEcom_Brand");

            migrationBuilder.RenameIndex(
                name: "IX_Product_Category_CategoryId",
                table: "vEcom_Product_Category",
                newName: "IX_vEcom_Product_Category_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Color_ProductsProductId",
                table: "vEcom_Color",
                newName: "IX_vEcom_Color_ProductsProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Category_ProductsProductId",
                table: "vEcom_Category",
                newName: "IX_vEcom_Category_ProductsProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vEcom_VehModel",
                table: "vEcom_VehModel",
                column: "ModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vEcom_Vehicle",
                table: "vEcom_Vehicle",
                column: "VehicleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vEcom_Product_Category",
                table: "vEcom_Product_Category",
                columns: new[] { "ProductId", "CategoryId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_vEcom_Product",
                table: "vEcom_Product",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vEcom_Color",
                table: "vEcom_Color",
                column: "ColorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vEcom_Category",
                table: "vEcom_Category",
                column: "CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vEcom_Brand",
                table: "vEcom_Brand",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_vEcom_Category_vEcom_Product_ProductsProductId",
                table: "vEcom_Category",
                column: "ProductsProductId",
                principalTable: "vEcom_Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_vEcom_Color_vEcom_Product_ProductsProductId",
                table: "vEcom_Color",
                column: "ProductsProductId",
                principalTable: "vEcom_Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_vEcom_Product_Category_vEcom_Category_CategoryId",
                table: "vEcom_Product_Category",
                column: "CategoryId",
                principalTable: "vEcom_Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vEcom_Product_Category_vEcom_Product_ProductId",
                table: "vEcom_Product_Category",
                column: "ProductId",
                principalTable: "vEcom_Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vEcom_Category_vEcom_Product_ProductsProductId",
                table: "vEcom_Category");

            migrationBuilder.DropForeignKey(
                name: "FK_vEcom_Color_vEcom_Product_ProductsProductId",
                table: "vEcom_Color");

            migrationBuilder.DropForeignKey(
                name: "FK_vEcom_Product_Category_vEcom_Category_CategoryId",
                table: "vEcom_Product_Category");

            migrationBuilder.DropForeignKey(
                name: "FK_vEcom_Product_Category_vEcom_Product_ProductId",
                table: "vEcom_Product_Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vEcom_VehModel",
                table: "vEcom_VehModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vEcom_Vehicle",
                table: "vEcom_Vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vEcom_Product_Category",
                table: "vEcom_Product_Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vEcom_Product",
                table: "vEcom_Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vEcom_Color",
                table: "vEcom_Color");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vEcom_Category",
                table: "vEcom_Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vEcom_Brand",
                table: "vEcom_Brand");

            migrationBuilder.RenameTable(
                name: "vEcom_VehModel",
                newName: "VehModel");

            migrationBuilder.RenameTable(
                name: "vEcom_Vehicle",
                newName: "Vehicle");

            migrationBuilder.RenameTable(
                name: "vEcom_Product_Category",
                newName: "Product_Category");

            migrationBuilder.RenameTable(
                name: "vEcom_Product",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "vEcom_Color",
                newName: "Color");

            migrationBuilder.RenameTable(
                name: "vEcom_Category",
                newName: "Category");

            migrationBuilder.RenameTable(
                name: "vEcom_Brand",
                newName: "Brand");

            migrationBuilder.RenameIndex(
                name: "IX_vEcom_Product_Category_CategoryId",
                table: "Product_Category",
                newName: "IX_Product_Category_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_vEcom_Color_ProductsProductId",
                table: "Color",
                newName: "IX_Color_ProductsProductId");

            migrationBuilder.RenameIndex(
                name: "IX_vEcom_Category_ProductsProductId",
                table: "Category",
                newName: "IX_Category_ProductsProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehModel",
                table: "VehModel",
                column: "ModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle",
                column: "VehicleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product_Category",
                table: "Product_Category",
                columns: new[] { "ProductId", "CategoryId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Color",
                table: "Color",
                column: "ColorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brand",
                table: "Brand",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Product_ProductsProductId",
                table: "Category",
                column: "ProductsProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Color_Product_ProductsProductId",
                table: "Color",
                column: "ProductsProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_Category_CategoryId",
                table: "Product_Category",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_Product_ProductId",
                table: "Product_Category",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
