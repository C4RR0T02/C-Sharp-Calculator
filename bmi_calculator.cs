using System;

namespace bmi_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to Sherlena's BMI Calculator!");
            Console.Write("Enter your weight (in kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your height (in m): ");
            double height = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / (height * height);

            Console.WriteLine("The BMI of a person weighing " + weight + "kg with a height of " + height + " is " + bmi);
        }
    }
}
