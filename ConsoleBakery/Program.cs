using System;
using ConsoleBakery.Models;
class Program
{
  static void Main() {
    PrintHUD();
    float breadPrice = PromptForBreadQuantity();
    float pastryPrice = PromptForPastryQuantity();
    float grandTotal = breadPrice + pastryPrice;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\nTotal is ${grandTotal}\n");
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

    float PromptForBreadQuantity() {
      Console.WriteLine("How many bread?");
      string breadInput = Console.ReadLine();
      int breadCount = 0;
      try {
        breadCount = int.Parse(breadInput);
      }
      catch {
        Console.WriteLine("Sorry, that's not a number!");
        return PromptForBreadQuantity();
      }
      Bread bread = new Bread(breadCount);
      float breadPrice = bread.PriceForQuantity();
      return breadPrice;
    }

    float PromptForPastryQuantity() {
      Console.WriteLine("\nHow many pastries?");
      string pastryInput = Console.ReadLine();
      int pastryCount = 0;
      try {
        pastryCount = int.Parse(pastryInput);
      }
      catch {
        Console.WriteLine("Sorry, that's not a number!");
        return PromptForPastryQuantity();
      }
      Pastry pastry = new Pastry(pastryCount);
      float pastryPrice = pastry.PriceForQuantity();
      return pastryPrice;
    }
  }
}