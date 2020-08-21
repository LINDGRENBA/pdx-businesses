using Microsoft.EntityFrameworkCore;

namespace PdxBusiness.Models
{
  public class PdxBusinessContext : DbContext
  {
    public PdxBusinessContext(DbContextOptions<PdxBusinessContext> options) : base(options)
    {

    }

    public DbSet<Business> Businesses { get; set; }
  }
}