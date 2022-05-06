using System;
using System.Collections.Generic;
using Bakery.Models;
using System.Linq;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Hello and welcome to Pierre's Bakery!");
    Console.WriteLine("Our Bread Prices: $5 Each // Buy 2, get 1 Free!");
    Console.WriteLine("Our Pastry Prices: $2 Each // Every 3rd Pastry ONLY $1!");

    Console.WriteLine("How many bread loafs?");
    string userBreadInput = Console.ReadLine();
    Bread newBreadCount = new Bread(userBreadInput);
    newBreadCount.BreadCalc();
    newBreadCount.BreadSaleCalc();

    
    Console.WriteLine("How many pastries?");
    string userPastryInput = Console.ReadLine();
    Pastry newPastryCount = new Pastry(userPastryInput);
    newPastryCount.PastryCalc();
    newPastryCount.PastrySaleCalc();

    Console.WriteLine("GRAND TOTAL: " + newBreadCount.BreadSubTotal + newPastryCount.PastrySubTotal);

  }
}