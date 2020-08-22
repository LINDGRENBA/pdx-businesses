using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PdxBusiness.Models;
using Microsoft.EntityFrameworkCore;
using PdxBusiness.Wrappers;
using System.Threading.Tasks;

using System;
using System.Net.WebSockets;
using Microsoft.AspNetCore.Http;


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

    // POST api/businesses    -> THIS IS LIKE CREATE
    [HttpPost]
    public void Post([FromBody] Business business) //expect business object from body
    {
      _db.Businesses.Add(business);
      _db.SaveChanges();
    }

    // GET api/businesses/#
    [HttpGet("{id}")]
    public ActionResult<Business> Get(int id) 
    // very similar to controller on line 20, but takes in id and returns specific result instead of returning all results
    {
      return _db.Businesses.FirstOrDefault(business => business.BusinessId == id);
    }

    // PUT api/businesses/#    -> THIS IS LIKE EDIT
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

    // GET api/businesses/pages/#  
    [HttpGet("pages/{id}")]
    public async Task<IActionResult> GetById(int id)
    {
      var business = await _db.Businesses.Where(a => a.BusinessId == id).FirstOrDefaultAsync();
      return Ok(new Response<Business>(business));
    }

  }
}