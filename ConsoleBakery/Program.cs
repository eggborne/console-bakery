using System;
using ConsoleBakery.Models;
class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to the C# Console Bakery!");
    Console.WriteLine("How many bread?");
    int breadCount = int.Parse(Console.ReadLine());
    Bread bread = new Bread(breadCount);
    float breadPrice = bread.PriceForQuantity();
    Console.WriteLine($"Total is ${breadPrice}");
  }
}