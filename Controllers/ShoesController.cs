using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shoestore.Models;

namespace shoestore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ShoesController : ControllerBase
  {
    public List<Shoe> Shoes = new List<Shoe>()
    {
      new Shoe("Booties", "Women's", "Lucky", 100f),
      new Shoe("Slides", "Men's", "Sanuk", 45.99f),
      new Shoe("Ugg Boots", "Women's", "Ugg", 125f)
    };
    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<Shoe>> Get()
    {
      return Shoes;
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      return "value";
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody] string value)
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
