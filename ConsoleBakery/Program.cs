using System;
using ConsoleBakery.Models;
class Program
{
  static void Main() {
    PrintHUD();

    Console.WriteLine("How many bread?");
    int breadCount = int.Parse(Console.ReadLine());
    Bread bread = new Bread(breadCount);
    float breadPrice = bread.PriceForQuantity();

    Console.WriteLine("\nHow many pastries?");
    int pastryCount = int.Parse(Console.ReadLine());
    Pastry pastry = new Pastry(pastryCount);
    float pastryPrice = pastry.PriceForQuantity();
    
    float grandTotal = breadPrice + pastryPrice;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\nTotal is ${grandTotal}\n");
    Console.ResetColor();

    void PrintHUD() {
      Console.Clear();
      Console.WriteLine("Welcome to the C# Console Bakery!");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("\n=================================================");
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
  }
}