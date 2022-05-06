using System;
using System.Collections.Generic;
using Bakery.Models;
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

      // while(true)
      // {
      //   Console.WriteLine("You want " + newBreadCount.BreadCount);
      //   string userResponse = Console.ReadLine();
      //   if(userResponse.ToUpper() == "Y")
      //   {
      //     break;
      //   }
      // }  
      

      
      Console.WriteLine("How many pastries?");
      string userPastryInput = Console.ReadLine();
      Pastry newPastryCount = new Pastry(userPastryInput);
      newPastryCount.PastryCalc();
      newPastryCount.PastrySaleCalc();

      int totalPrice = newBreadCount.BreadSubTotal + newPastryCount.PastrySubTotal;

      Console.WriteLine("GRAND TOTAL: " + totalPrice);
      Console.WriteLine("------------------------------------");
      Console.WriteLine("Is this total okay? Enter 'Y' to EXIT, Enter 'N' to restart order");
      string exitResponse = Console.ReadLine();
      if (exitResponse.ToUpper() == "Y")
      {
        break;
      }
    }
  }
}