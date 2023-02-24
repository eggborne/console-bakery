using System;
using ConsoleBakery.Models;
class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to the C# Console Bakery!");
    Console.WriteLine("How many bread?");
    int breadCount = int.Parse(Console.ReadLine());
    float breadPrice = Bread.PriceForQuantity(breadCount);
    Console.WriteLine($"Total is ${breadPrice}");
  }
}