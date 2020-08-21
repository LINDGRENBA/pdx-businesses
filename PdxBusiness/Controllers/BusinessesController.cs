using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PdxBusiness.Models;

namespace PdxBusiness.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BusinessesController : ControllerBase
  {
    private PdxBusinessContext _db;

    public BusinessesController(PdxBusinessContext db)
    {
      _db = db;
    }

    // GET api/businesses
    public ActionResult<IEnumerable<Business>> Get()
    {
      return _db.Businesses.ToList();
    }

    // POST api/businesses
    [HttpPost]
    public void Post([FromBody] Business business) //expect business object from body
    {
      _db.Businesses.Add(business);
      _db.SaveChanges();
    }
  }
}