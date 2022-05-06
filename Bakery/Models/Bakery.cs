

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadCount {get; set;}
    public int BreadSubTotal {get; set;}

    public Bread(string count)
    {
      BreadCount = int.Parse(count);
      BreadSubTotal = 0;
    }

    public int BreadCalc()
    {
      for (int i = 0; i < BreadCount; i++)
      {
        BreadSubTotal += 5;
      }
      return BreadSubTotal;
    }
  }
}