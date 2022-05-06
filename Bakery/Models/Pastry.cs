namespace PastryBakery.Models
{
   public class Pastry
  {
    public int PastryCount {get; set;}
    public int PastrySubTotal {get; set;}
    public string PastryType {get; set;}

    public Pastry(string pastries, string type)
    {
      PastryCount = int.Parse(pastries);
      PastrySubTotal = 0;
      PastryType = type;
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