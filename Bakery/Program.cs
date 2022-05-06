using System;
using BreadBakery.Models;
using PastryBakery.Models;


public class Program
{
  public static void Main()
  {
    while(true)
    {
      Console.WriteLine("Hello and welcome to Pierre's Bakery!");
      Console.WriteLine("Our Bread Prices: $5 Each // Buy 2, get 1 Free and 25% off 5 or more!!");
      Console.WriteLine("Our Pastry Prices: $2 Each // Every 3rd Pastry ONLY $1!");
      Console.WriteLine("Today only! Two types of pastry! Cupcake or Danish!");
      Console.WriteLine("*Cupcakes are $2 extra each // $1 off every 3rd pastry still applies*");
      Console.WriteLine("---------------------------------------------------------------");
      
      Console.WriteLine("How many bread loaves?");
      string userBreadInput = Console.ReadLine();

      while(true)
      {
        long num = 0;
        bool canConvert = long.TryParse(userBreadInput, out num);
        if (canConvert == false)
        {
          Console.WriteLine("Please enter a number");
          userBreadInput = Console.ReadLine();
        }
        else
        {
          break;
        }
      }

      Bread newBread = new Bread(userBreadInput);
      newBread.BreadCalc();
      newBread.BreadSaleCalc();

      Console.WriteLine("How many pastries?");
      string pastryCount = Console.ReadLine();

      while(true)
      {
        long num = 0;
        bool canConvert = long.TryParse(pastryCount, out num);
        if (canConvert == false)
        {
          Console.WriteLine("Please enter a number");
          pastryCount = Console.ReadLine();
        }
        else
        {
          break;
        }
      }

      Console.WriteLine("Cupcake or Danish?");
      string pastryType = Console.ReadLine();

      while(true)
      {
        if (pastryType.ToLower() != "cupcake" && pastryType.ToLower() != "danish")
        {
          Console.WriteLine("Please choose Cupcake or Danish");
          pastryType = Console.ReadLine();
        }
        else
        {
          break;
        }
      }

      Pastry newPastry = new Pastry(pastryCount, pastryType);
      newPastry.PastryCalc();
      newPastry.PastryChoiceAdjust();
      newPastry.PastrySaleCalc();

      int totalPrice = newBread.BreadSubTotal + newPastry.PastrySubTotal;
      if (newBread.BreadCount >= 5)
      {
        double breadDiscount = newBread.ApplyDiscount();
        Console.WriteLine("GRAND TOTAL: " + (breadDiscount + newPastry.PastrySubTotal));
        Console.WriteLine("---------------------------------------------------------------");
      }
      else
      {
        Console.WriteLine("GRAND TOTAL: " + totalPrice);
        Console.WriteLine("---------------------------------------------------------------");
      }

      Console.WriteLine("Is this total okay? Enter 'Y' to EXIT, Enter 'N' to restart order");
      string exitResponse = Console.ReadLine();

      while(true)
      {
        if (exitResponse.ToUpper() != "Y" && exitResponse.ToUpper() != "N")
        {
          Console.WriteLine("Please Answer 'Y' or 'N'");
          exitResponse = Console.ReadLine();
        } 
        else
        {
          break;
        }
    
      }
      if (exitResponse.ToUpper() == "Y")
      {
        break;
      }
    }
  }
}