using System;
using System.Collections.Generic;
using BreadBakery.Models;
using PastryBakery.Models;
using System.Linq;

public class Program
{
  public static void Main()
  {
    while(true)
    {
      Console.WriteLine("Hello and welcome to Pierre's Bakery!");
      Console.WriteLine("Our Bread Prices: $5 Each // Buy 2, get 1 Free!");
      Console.WriteLine("Our Pastry Prices: $2 Each // Every 3rd Pastry ONLY $1!");
      
      Console.WriteLine("How many bread loaves?");
      string userBreadInput = Console.ReadLine();
      Bread newBreadCount = new Bread(userBreadInput);
      newBreadCount.BreadCalc();
      newBreadCount.BreadSaleCalc();

      Console.WriteLine("How many pastries?");
      string userPastryInput = Console.ReadLine();
      Pastry newPastryCount = new Pastry(userPastryInput);
      newPastryCount.PastryCalc();
      newPastryCount.PastrySaleCalc();

      int totalPrice = newBreadCount.BreadSubTotal + newPastryCount.PastrySubTotal;

      Console.WriteLine("GRAND TOTAL: " + totalPrice);
      Console.WriteLine("---------------------------------------------------------------");
      Console.WriteLine("Is this total okay? Enter 'Y' to EXIT, Enter 'N' to restart order");
      string exitResponse = Console.ReadLine();
      while(true)
      {
        if (exitResponse.ToUpper() != "Y" && exitResponse.ToUpper() != "N")
        {
          Console.WriteLine("Please Answer 'Y' or 'N'");
          exitResponse = Console.ReadLine();
        } else
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