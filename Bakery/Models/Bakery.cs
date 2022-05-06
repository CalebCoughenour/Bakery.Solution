using System;

namespace Bakery.Models
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

  public class Pastry
  {
    public int PastryCount {get; set;}
    public int PastrySubTotal {get; set;}

    public Pastry(string pastries)
    {
      PastryCount = int.Parse(pastries);
      PastrySubTotal = 0;
    }
    public int PastryCalc()
    {
      for (int i = 0; i < PastryCount; i++)
      {
        PastrySubTotal += 2;
      }
      return PastrySubTotal;
    }
     public int PastrySaleCalc()
    {
      if (PastryCount >= 3)
      {
        int SaleCount = PastryCount / 3;
        PastrySubTotal -= (SaleCount * 1);
      }
      return PastrySubTotal;
    }
  }
}