using Microsoft.EntityFrameworkCore.Migrations;

namespace PdxBusiness.Migrations
{
    public partial class OwnerProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Businesses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Businesses");
        }
    }
}
