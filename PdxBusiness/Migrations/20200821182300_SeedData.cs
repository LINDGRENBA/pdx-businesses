using Microsoft.EntityFrameworkCore.Migrations;

namespace PdxBusiness.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Address", "Description", "Name", "Owner", "PhoneNumber", "Url" },
                values: new object[,]
                {
                    { 1, "online only", "Skincare for all skin types, all natural.", "Bahia Honey Beauty and Well-being", "Bahia Overton", "(503) 395-7090", "https://bahiahoney.com/" },
                    { 2, "404 NE 28th Ave, Portland, OR. 97232", "Vegan restaurant and pico lounge serving 'dishes inspired by the Andes region of South America, but with our own twist.' POC and woman-owned.", "Epif", "Pepe and Nicolle", "(971) 254-8680", "https://www.epifpdx.com/" },
                    { 3, "1010 SE Water Ave, Portland, OR. 97214", "Business providing standing desks, chairs and ergonomic furniture.", "Fully", "David Kahl", "(888) 508-3725", "https://www.fully.com/" },
                    { 4, "5521 SE Woodstock Blvd, Portland, OR. 97206", "Full-service traffic control and equipment rental company", "Chick Of All Trades, LLC", "Val Solorzano", "(503) 467-6386", "http://www.coatflagging.com/" },
                    { 5, "1061 Lloyd Center, Portland, OR. 97232", "Sports merchandise, clothing line", "Cultural Blends", "Troy Douglass", "(503) 572-9757", "https://www.culturalblends.net/" },
                    { 6, "1033 SW Yamhill St., Suite 203, Portland, OR. 97209", "Althernative and holistic health services, health and wellness, massage", "SomaFlow Health and Massage, LLC", "Kristi Carlough", "(503) 929-3525", "https://www.somaflow.health/" },
                    { 7, "2901 NE Alberta St. Portland, OR. 97211", "Woman owned, Indegenous, two-spirit-owned and operated herb shop", "Clary Sage Herbarium", "Laurie Books", "(503) 236-6737", "https://clarysageherbarium.com/" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 7);
        }
    }
}
