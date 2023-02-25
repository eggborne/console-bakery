using System;
using System.Collections.Generic;
using ConsoleBakery.Models;
class Program
{
  static void Main() {
    PrintHUD();
    int breadQuantity = PromptForProductQuantity("bread");
    int pastryQuantity = PromptForProductQuantity("pastry");
    Bread breadOrder = new Bread(breadQuantity);
    Pastry pastryOrder = new Pastry(pastryQuantity);
    float breadPrice = breadOrder.PriceForQuantity();
    float pastryPrice = pastryOrder.PriceForQuantity();
    float grandTotal = breadPrice + pastryPrice;
    List<Product> orderList = new List<Product>();
    orderList.Add(breadOrder);
    orderList.Add(pastryOrder);

    PrintInvoice(orderList);

    // Console.ForegroundColor = ConsoleColor.Green;
    // Console.WriteLine($"\nTotal is ${grandTotal}\n");
    Console.ResetColor();

    void PrintHUD() {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.WriteLine("        Welcome to the C# Console Bakery!        ");
      Console.ResetColor();
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("=================================================");
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.Write("  Bread:");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write("     $5");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write("     SPECIAL! Buy");
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write(" 2");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write(" get one FREE");
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.Write("\n  Pastries:");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write("  $2");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write("     SPECIAL! Buy");
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write(" 3");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write(" get one FREE");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("\n=================================================\n");
      Console.ResetColor();
    }

    void PrintInvoice(List<Product> orderList) {
      Console.Clear();
      PrintHUD();
      Product breadOrder = orderList[0];
      Product pastryOrder = orderList[1];
      float grandTotal = pastryOrder.PriceForQuantity() + breadOrder.PriceForQuantity();
      Console.BackgroundColor = ConsoleColor.Magenta;
      Console.WriteLine("\n                     INVOICE                     ");
      Console.ResetColor();
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("=================================================");

      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.Write("  Bread:");
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write($"     {breadOrder.quantity} @ ${breadOrder.pricePerUnit}");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write($"     FREE:");
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write($" {breadOrder.CalculateFreeUnits()}");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write($"     Total: ${breadOrder.PriceForQuantity()}");

      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.Write("\n  Pastries:");
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write($"  {pastryOrder.quantity} @ ${pastryOrder.pricePerUnit}");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write($"     FREE:");
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write($" {pastryOrder.CalculateFreeUnits()}");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write($"     Total: ${pastryOrder.PriceForQuantity()}");

      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("\n=================================================");
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write("                              Grand Total:");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write($" ${grandTotal}");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("\n=================================================");
      Console.ResetColor();
    }

    int PromptForProductQuantity(string productName) {
      Console.WriteLine($"How many {productName}?");
      string productInput = Console.ReadLine();
      int productCount = 0;
      try {
        productCount = int.Parse(productInput);
      }
      catch {
        Console.WriteLine("Sorry, that's not a number!");
        return PromptForProductQuantity(productName);
      }
      return productCount;
    }
  }
}