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
    //specify that our ActionResult is returning type IEnumerable because we are no longer returning Views
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

    // GET api/animals/#
    [HttpGet("{id}")]
    public ActionResult<Business> Get(int id) 
    // very similar to controller on line 20, but takes in id and returns specific result instead of returning all results
    {
      return _db.Businesses.FirstOrDefault(business => business.BusinessId == id);
    }
  }
}