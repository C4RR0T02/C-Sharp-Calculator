using System;

namespace Tax_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Sherlena's tax calculator");
            Console.WriteLine();
            TaxCalcMenu();
            Console.WriteLine();
            Console.WriteLine("Enter the industry the payment is for: ");
            string option = Console.ReadLine();
            Console.WriteLine();
            switch (option)
            {
                case "1": {
                        Console.WriteLine("Food & Beverages tax Calculator");
                        Console.WriteLine();
                        Console.WriteLine("Enter the cost of the product: ");
                        double cost = Convert.ToDouble(Console.ReadLine());
                        double costwithgst = (((cost / 100) * 110) / 100) * 107;
                        Console.WriteLine("The cost of the $" + cost + " is " + costwithgst + " after the 10% service charge and 7% gst");
                        break;
                }
                case "2": {
                        Console.WriteLine("Other Industries tax Calculator");
                        Console.WriteLine();
                        Console.WriteLine("Enter the cost of the product: ");
                        double cost = Convert.ToDouble(Console.ReadLine());
                        double costwithgst = (cost / 100) * 107;
                        Console.WriteLine("The cost of the $" + cost + " is " + costwithgst + " after the 7% gst");
                        break;
                }

                default: {
                        Console.WriteLine("Please enter a valid choice");
                        break;
                }
            }
        }

        static void TaxCalcMenu()
        {
            Console.WriteLine("1. Food & Beverages");
            Console.WriteLine("2. Other Industries");
        }
    }
}
