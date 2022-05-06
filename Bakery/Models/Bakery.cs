namespace BreadBakery.Models
{
  public class Bread
  {
    public int BreadCount {get; set;}
    public int BreadSubTotal {get; set;}

    public Bread(string bread)
    {
      BreadCount = int.Parse(bread);
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
    public int BreadSaleCalc()
    {
      if (BreadCount >= 3)
      {
        int SaleCount = BreadCount / 3;
        BreadSubTotal -= (SaleCount * 5);
      }
      return BreadSubTotal;
    }
  }
}