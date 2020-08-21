using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PdxBusiness.Migrations
{
    public partial class SecondModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    OwnerId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Business = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.OwnerId);
                });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "OwnerId", "Bio", "Business", "Name" },
                values: new object[,]
                {
                    { 1, "Bahia Overton founded Bahia Honey after developing a moisturizure to help treat her daughters eczema, after repeatedly trying other moisturizers on the market with no success.", "Bahia Honey Beauty and Well-Being", "Bahia Overton" },
                    { 2, "This couple owned and operated an international restaurant and bar for six years in Pepe's hometown of Valparaiso, Chile. After moving to Portland, they designed and created their business right in front of their very own home. The interior of their restaurant and bar is full of gems from Chile and Peru, such as the bar top!", "Epif", "Pepe and Nicolle" },
                    { 3, "On September 11th, David Kahl stood on the 56th floor of his office building, four miles away from the Twin Towers in New York city. After that life changing day, he quit his job as an accountant and started down a path that led to the founding of his business, Fully.", "Fully", "David Kahl" },
                    { 4, "Val Solorzano started her business in 2006 and focused initially on providing traffic control services. Her business has since grown and expanded and now has a hand in a variety of projects around Portland.", "Chick of All Trades, LLC", "Val Solorzano" },
                    { 5, "Troy Douglass is a member of the Confederated Tribes of Grand Ronde who owns and operates a sports merchandise store and designs his own apparal. In one of his instagram posts at @culturalblends, he writes about the fact that he is a descendent of Chief Coboway, a Clatsop Chief.", "Cultural Blends", "Troy Douglass" },
                    { 6, "Before the pandemic, Kristi Carlough was taking coaching and business classes taught by the Native American Youth and Family Center. She prioritizes creating a safe space where BIPOC can feel comfortable going for self-care.", "SomaFlow Health and Massage, LLC", "Kristi Carlough" },
                    { 7, "As the Clary Sage Herbarium site states, Clary is an indigenous, two-spirit woman, providing fine quality organic herbal products and focused on promoting local awareness and offering a place of healing.", "Clary Sage Herbarium", "Laurie Books" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}
