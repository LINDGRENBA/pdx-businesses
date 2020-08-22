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
  public class BusinessesController : ControllerBase
  {
    private PdxBusinessContext _db;

    public BusinessesController(PdxBusinessContext db)
    {
      _db = db;
    }

    // GET api/businesses
    [HttpGet]
    public ActionResult<IEnumerable<Business>> Get() 
    // specify that our ActionResult is returning type IEnumerable because we are no longer returning Views
    {
      return _db.Businesses.ToList();
    }

    // PAGINATION
    // GET api/businesses/pages
    [HttpGet("pages/")]
    public async Task<IActionResult> GetAll([FromQuery] PaginationFilter filter)
    {
      var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
      var pagedData = await _db.Businesses
        .Skip((validFilter.PageNumber - 1) * validFilter.PageSize) // calculates how many results/pages to skip
        .Take(validFilter.PageSize)
        .ToListAsync();
      var totalRecords = await _db.Businesses.CountAsync();
      return Ok(new PagedResponse<List<Business>>(pagedData, validFilter.PageNumber, validFilter.PageSize));
    }

    // POST api/businesses  
    [HttpPost]
    public void Post([FromBody] Business business) 
    {
      _db.Businesses.Add(business);
      _db.SaveChanges();
    }

    // GET api/businesses/#
    [HttpGet("{id}")]
    public ActionResult<Business> Get(int id) 
    {
      return _db.Businesses.FirstOrDefault(business => business.BusinessId == id);
    }

    // PUT api/businesses/# 
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Business business) 
    {
      business.BusinessId = id;
      _db.Entry(business).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/businesses/#
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var businessToDelete = _db.Businesses.FirstOrDefault(business => business.BusinessId == id);
      _db.Businesses.Remove(businessToDelete);
      _db.SaveChanges();
    }
  }
}