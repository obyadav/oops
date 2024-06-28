using System;

namespace oops
{
    class Hotel
    {
        private double totalAmount = 0.0; // Total amount to be calculated

        public void m3()
        {
            // Display menu and get user input
            int choice;
            do
            {
                DisplayMenu();
                choice = GetChoice();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You ordered Fried Rice.");
                        totalAmount += CalculateAmount(10.0); // Assuming Fried Rice costs $10
                        break;
                    case 2:
                        Console.WriteLine("You ordered Pizza.");
                        totalAmount += CalculateAmount(15.0); // Assuming Pizza costs $15
                        break;
                    case 3:
                        Console.WriteLine("You ordered Salad.");
                        totalAmount += CalculateAmount(8.0); // Assuming Salad costs $8
                        break;
                    case 4:
                        Console.WriteLine("You ordered Pasta.");
                        totalAmount += CalculateAmount(12.0); // Assuming Pasta costs $12
                        break;
                    case 5:
                        Console.WriteLine($"Total Amount: ${totalAmount}");
                        Console.WriteLine("Thank you for your order. Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }

                Console.WriteLine();
            } while (choice != 5);
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("Welcome to Hotel Food Ordering System");
            Console.WriteLine("1. Fried Rice");
            Console.WriteLine("2. Pizza");
            Console.WriteLine("3. Salad");
            Console.WriteLine("4. Pasta");
            Console.WriteLine("5. Exit");
        }

        public static int GetChoice()
        {
            Console.Write("Enter your choice (1-5): ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                Console.Write("Enter your choice again: ");
            }
            return choice;
        }

        // Method to calculate amount including extra charges
        public double CalculateAmount(double baseAmount)
        {
            double amount = baseAmount;

            // Ask if user wants to add extra item
            Console.Write("Do you want to add extra item? (Y/N): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "y")
            {
                Console.Write("Enter extra item amount: ");
                double extraAmount;
                while (!double.TryParse(Console.ReadLine(), out extraAmount) || extraAmount < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid amount.");
                    Console.Write("Enter extra item amount: ");
                }

                amount += extraAmount;
            }
            if (input.ToLower() == "n")
            {
                Console.WriteLine("your order item price is:"+" " + amount);
                Console.WriteLine("thanks for visiting");

            }
                return amount;
            
        }
    }
}

