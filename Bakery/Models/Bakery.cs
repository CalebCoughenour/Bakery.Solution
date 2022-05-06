

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadCount {get; set;}

    public Bread(string count)
    {
      BreadCount = int.Parse(count);
    }
  }
}