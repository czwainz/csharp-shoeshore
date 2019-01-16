using System.Collections.Generic;

namespace shoestore.Models
{
  public static class FakeDB
  {
    public static List<Shoe> Shoes { get; set; } = new List<Shoe>();
  }
}