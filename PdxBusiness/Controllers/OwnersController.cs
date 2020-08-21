using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PdxBusiness.Models;
using Microsoft.EntityFrameworkCore;

namespace PdxBusiness.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class OwnersController : ControllerBase
  {
    private PdxBusinessContext _db;

    public OwnersController(PdxBusinessContext db)
    {
      _db = db;
    }

    // GET api/owners
    public ActionResult<IEnumerable<Owner>> Get() 
    //specify that our ActionResult is returning type IEnumerable because we are no longer returning Views
    {
      return _db.Owners.ToList();
    }

    // POST api/businesses    -> THIS IS LIKE CREATE
    [HttpPost]
    public void Post([FromBody] Owner owner) //expect business object from body
    {
      _db.Owners.Add(owner);
      _db.SaveChanges();
    }

    // GET api/animals/#
    [HttpGet("{id}")]
    public ActionResult<Owner> Get(int id) 
    // very similar to controller on line 20, but takes in id and returns specific result instead of returning all results
    {
      return _db.Businesses.FirstOrDefault(business => business.BusinessId == id);
    }

    // PUT api/animals/#    -> THIS IS LIKE EDIT
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Business business) 
    // needs an id so it knows which object to edit, changes to be made should be made in the body prior to activating PUT route, which is why we also take in the object from the body - this is how we know what to change
    {
      business.BusinessId = id;
      _db.Entry(business).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/animals/#
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var businessToDelete = _db.Businesses.FirstOrDefault(business => business.BusinessId == id);
      _db.Businesses.Remove(businessToDelete);
      _db.SaveChanges();
    }
  }
}