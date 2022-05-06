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
        int saleCount = BreadCount / 3;
        BreadSubTotal -= (saleCount * 5);
      }
      return BreadSubTotal;
    }
    public double ApplyDiscount()
    {
      double discountPrice = 0;
      if (BreadCount >= 5)
      {
        discountPrice = (BreadSubTotal * .25);
        return BreadSubTotal - discountPrice;
      }
      return BreadSubTotal - discountPrice;
    }
  }
}