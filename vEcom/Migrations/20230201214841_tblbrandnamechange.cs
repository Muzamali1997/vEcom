using Microsoft.EntityFrameworkCore.Migrations;

namespace vEcom.Migrations
{
    public partial class tblbrandnamechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_vEcom_Brand",
                table: "vEcom_Brand");

            migrationBuilder.RenameTable(
                name: "vEcom_Brand",
                newName: "vEcom_Brands");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vEcom_Brands",
                table: "vEcom_Brands",
                column: "BrandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_vEcom_Brands",
                table: "vEcom_Brands");

            migrationBuilder.RenameTable(
                name: "vEcom_Brands",
                newName: "vEcom_Brand");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vEcom_Brand",
                table: "vEcom_Brand",
                column: "BrandId");
        }
    }
}
