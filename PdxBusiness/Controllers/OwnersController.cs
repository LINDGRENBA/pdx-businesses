using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PdxBusiness.Models;
using Microsoft.EntityFrameworkCore;
using PdxBusiness.Wrappers;
using System.Threading.Tasks;

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
    {
      return _db.Owners.ToList();
    }

    // PAGINATION
    // GET api/owners/pages
    [HttpGet("pages/")]
    public async Task<IActionResult> GetAll([FromQuery] PaginationFilter filter)
    {
      var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
      var pagedData = await _db.Owners
        .Skip((validFilter.PageNumber - 1) * validFilter.PageSize) // calculates how many results/pages to skip
        .Take(validFilter.PageSize)
        .ToListAsync();
      var totalRecords = await _db.Owners.CountAsync();
      return Ok(new PagedResponse<List<Owner>>(pagedData, validFilter.PageNumber, validFilter.PageSize));
    }

    // POST api/owners
    [HttpPost]
    public void Post([FromBody] Owner owner)
    {
      _db.Owners.Add(owner);
      _db.SaveChanges();
    }

    // GET api/owners/#
    [HttpGet("{id}")]
    public ActionResult<Owner> Get(int id) 
    {
      return _db.Owners.FirstOrDefault(owner => owner.OwnerId == id);
    }

    // PUT api/owners/# 
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Owner owner) 
    {
      owner.OwnerId = id;
      _db.Entry(owner).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/owners/#
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var ownerToDelete = _db.Owners.FirstOrDefault(owner => owner.OwnerId == id);
      _db.Owners.Remove(ownerToDelete);
      _db.SaveChanges();
    }
  }
}