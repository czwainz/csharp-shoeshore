using System;
using System.Collections.Generic;
using shoestore.Models;

namespace shoestore.Repositories
{
  public class ShoeRepository
  {
    private readonly ShoeRepository _shoeRepo;

    public ShoeRepository(ShoeRepository repo)
    {
      _shoeRepo = repo;
    }

    public IEnumerable<Shoe> GetAll()
    {
      return FakeDB.Shoes;
    }

    public Shoe GetById(int id)
    {
      try
      {
        return FakeDB.Shoes[id];
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return null;
      }
    }

    public Shoe EditShoe(int id, Shoe newshoe)
    {
      try
      {
        return FakeDB.Shoes[id] = newshoe;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return null;
      }
    }

    public Shoe AddShoe(Shoe newshoe)
    {
      try
      {
        return FakeDB.Shoes.Add(newshoe);
      }
      catch (Exception ex)
      {
        System.Console.WriteLine(ex);
        return null;
      }
    }

    public bool DeleteShoe(int id)
    {
      try
      {
        FakeDB.Shoes.Remove(FakeDB.Shoes[id]);
        return true;
      }
      catch (System.Exception ex)
      {
        System.Console.WriteLine(ex);
        return false;
      }
    }
  }
}