using Microsoft.EntityFrameworkCore;

namespace PdxBusiness.Models
{
  public class PdxBusinessContext : DbContext
  {
    public PdxBusinessContext(DbContextOptions<PdxBusinessContext> options) : base(options)
    {

    }

    public DbSet<Business> Businesses { get; set; }
    public DbSet<Owner> Owners { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>()
        .HasData(
          new Business { BusinessId = 1, Name = "Bahia Honey Beauty and Well-being", Owner = "Bahia Overton", Address = "online only", PhoneNumber = "(503) 395-7090", Description = "Skincare for all skin types, all natural.", Url = "https://bahiahoney.com/"},
          new Business { BusinessId = 2, Name = "Epif", Owner = "Pepe and Nicolle", Address = "404 NE 28th Ave, Portland, OR. 97232", PhoneNumber = "(971) 254-8680", Description = "Vegan restaurant and pico lounge serving 'dishes inspired by the Andes region of South America, but with our own twist.' POC and woman-owned.", Url = "https://www.epifpdx.com/"},
          new Business { BusinessId = 3, Name = "Fully", Owner = "David Kahl", Address = "1010 SE Water Ave, Portland, OR. 97214", PhoneNumber = "(888) 508-3725", Description = "Business providing standing desks, chairs and ergonomic furniture.", Url = "https://www.fully.com/"},
          new Business { BusinessId = 4, Name = "Chick Of All Trades, LLC", Owner = "Val Solorzano", Address = "5521 SE Woodstock Blvd, Portland, OR. 97206", PhoneNumber = "(503) 467-6386", Description = "Full-service traffic control and equipment rental company", Url = "http://www.coatflagging.com/"},
          new Business { BusinessId = 5, Name = "Cultural Blends", Owner = "Troy Douglass", Address = "1061 Lloyd Center, Portland, OR. 97232", PhoneNumber = "(503) 572-9757", Description = "Sports merchandise, clothing line", Url = "https://www.culturalblends.net/"},
          new Business { BusinessId = 6, Name = "SomaFlow Health and Massage, LLC", Owner = "Kristi Carlough", Address = "1033 SW Yamhill St., Suite 203, Portland, OR. 97209", PhoneNumber = "(503) 929-3525", Description = "Althernative and holistic health services, health and wellness, massage", Url = "https://www.somaflow.health/"},
          new Business { BusinessId = 7, Name = "Clary Sage Herbarium", Owner = "Laurie Books", Address = "2901 NE Alberta St. Portland, OR. 97211", PhoneNumber = "(503) 236-6737", Description = "Woman owned, Indegenous, two-spirit-owned and operated herb shop", Url = "https://clarysageherbarium.com/"}
          // new Business { BusinessId = , Name = "", Owner = "", Address = "", PhoneNumber = "", Description = "", Url = ""}
        );

        builder.Entity<Owner>()
        .HasData(
          new Owner { OwnerId = 1, Name = "Bahia Overton", Business = "Bahia Honey Beauty and Well-Being", Bio = "Bahia Overton founded Bahia Honey after developing a moisturizure to help treat her daughters eczema, after repeatedly trying other moisturizers on the market with no success."},
          new Owner { OwnerId = 2, Name = "Pepe and Nicolle", Business = "Epif", Bio = "This couple owned and operated an international restaurant and bar for six years in Pepe's hometown of Valparaiso, Chile. After moving to Portland, they designed and created their business right in front of their very own home. The interior of their restaurant and bar is full of gems from Chile and Peru, such as the bar top!"},
          new Owner { OwnerId = 3, Name = "David Kahl", Business = "Fully", Bio = "On September 11th, David Kahl stood on the 56th floor of his office building, four miles away from the Twin Towers in New York city. After that life changing day, he quit his job as an accountant and started down a path that led to the founding of his business, Fully."},
          new Owner { OwnerId = 4, Name = "Val Solorzano", Business = "Chick of All Trades, LLC", Bio = "Val Solorzano started her business in 2006 and focused initially on providing traffic control services. Her business has since grown and expanded and now has a hand in a variety of projects around Portland."},
          new Owner { OwnerId = 5, Name = "Troy Douglass", Business = "Cultural Blends", Bio = "Troy Douglass is a member of the Confederated Tribes of Grand Ronde who owns and operates a sports merchandise store and designs his own apparal. In one of his instagram posts at @culturalblends, he writes about the fact that he is a descendent of Chief Coboway, a Clatsop Chief."},
          new Owner { OwnerId = 6, Name = "Kristi Carlough", Business = "SomaFlow Health and Massage, LLC", Bio = "Before the pandemic, Kristi Carlough was taking coaching and business classes taught by the Native American Youth and Family Center. She prioritizes creating a safe space where BIPOC can feel comfortable going for self-care."},
          new Owner { OwnerId = 7, Name = "Laurie Books", Business = "Clary Sage Herbarium", Bio = "As the Clary Sage Herbarium site states, Clary is an indigenous, two-spirit woman, providing fine quality organic herbal products and focused on promoting local awareness and offering a place of healing."}
          // new Owner { OwnerId = , Name = "", Business = "", Bio = ""}
        );
    }
  }
}