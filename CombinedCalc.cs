using System;

namespace CombinedCalc
{
    internal class Program
    {
        // Pseudo Code: 
        //      Step 1: Prompt Menu
        //      Step 2: Select option from Menu
        //      Step 3: Check if option is 0 (if it is 0 break if not continue program)
        //      Step 4: Perform action based on what is entered by users
        //      Step 5: Repeat Steps 1 to 4


        // Main Method codes will start from here usually
        static void Main(string[] args)
        {
            // Declaring of Variables
            bool exit = false; // Assigning value to this variable so it can be reassigned to end the loop

            // Loop to constantly continue program till 0 is selected

            // Menu Looping Option 1 (Using Switch)
            while (exit == false)
            {
                // Prompt display of Menu and user input
                Menu();
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                    {
                        CalcBMI();
                        Console.WriteLine();
                        exit = false;
                        break;
                    }
                    case "2":
                    {
                        CalcDiscount();
                        Console.WriteLine();
                        exit = false;
                        break;
                    }
                    case "3":
                    {
                        MultiplicationTable();
                        Console.WriteLine();
                        exit = false;
                        break;
                    }
                    case "0":
                    {
                        // end of program;
                        Console.WriteLine("Bye");
                        exit = true;
                        break;
                    }
                    default: 
                    {
                        Console.WriteLine("Invalid Option! Please try again.");
                        Console.WriteLine();
                        break;
                    }
                }
            }


            /*
            // Menu Looping Option 2 (Using if-else)
            while (exit == false)
            {
                // Prompt display of Menu and user input
                Menu();
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();
                if (choice == "1") {
                    CalcBMI();
                    Console.WriteLine();
                    exit = false;
                }
                else if (choice == "2") {
                    CalcDiscount();
                    Console.WriteLine();
                    exit = false;
                }
                else if (choice == "3") {
                    MultiplicationTable();
                    Console.WriteLine();
                    exit = false;
                }
                else if (choice == "0") {
                    // end of program;
                    Console.WriteLine("Bye");
                    exit = true;
                }
                else {
                    Console.WriteLine("Invalid Option! Please try again.");
                    Console.WriteLine();
                }
            }
            */
        }


        // Code for Main Menu
        public static void Menu()
        {
            Console.WriteLine("----------------------- MENU -----------------------");
            Console.WriteLine("[1] Calculate Body Mass Index");
            Console.WriteLine("[2] Calculate Discount");
            Console.WriteLine("[3] Display Multiplication Table");
            Console.WriteLine("[0] Exit");
            Console.WriteLine("----------------------------------------------------");
        }

        // Code for BMI Calculator
        public static void CalcBMI()
        {
            // try catch statements are for exception handling
            try
            {
                Console.Write("Enter your heuight in meters: ");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter your weight in kg: ");
                double weight = Convert.ToDouble(Console.ReadLine());
                double BMI = weight / (height * height);
                Console.WriteLine("The BMI of a person with the height of " + height + " and weight of " + weight + "kg is " + BMI);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        // Code to Calculate Discount
        public static void CalcDiscount()
        {
            // try catch statements are for exception handling
            try
            {
                Console.Write("Enter the price of product: ");
                double cost = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the discount percentage (%): ");
                double discountpercentage = Convert.ToDouble(Console.ReadLine());
                double totalprice = cost * ((100 - discountpercentage) / 100);
                Console.WriteLine("The cost of the product after " + discountpercentage + "% is " + totalprice);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        // Code for Displaying of Multiplication Table
        public static void MultiplicationTable()
        {
            // try catch statements are for exception handling
            try
            {
                Console.Write("Enter number to multiply: ");
                int numbertomultiply = Convert.ToInt32(Console.ReadLine());
                // looping to print out the multiplication table up to 15)
                for (int i = 0; i < 16; i++)
                {
                    int product = i * numbertomultiply;
                    Console.WriteLine(i + " X " + numbertomultiply + " = " + product);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
