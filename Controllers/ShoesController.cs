using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shoestore.Models;
using shoestore.Repositories;

namespace shoestore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ShoesController : ControllerBase
  {


    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<Shoe>> Get()
    {
      return Ok(_shoeRepo.GetAll());
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<Shoe> Get(int id)
    {

    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody] string shoe)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
