using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter the name of an item");
    string item = Console.ReadLine();
    Console.WriteLine("Enter the quanity of " + item + "s");
    double quanity = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the price for a" + item);
    double price = Convert.ToDouble(Console.ReadLine());
    double total_price = (quanity * price);
    Console.WriteLine("The total price of the" + item + "s is " + total_price);

  }
}