namespace shoestore.Models
{
  public class Shoe
  {
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Brand { get; set; }
    public float Price { get; set; }

    public Shoe(string name, string gender, string brand, float price)
    {
      Name = name;
      Gender = gender;
      Brand = brand;
      Price = price;
    }
  }
}