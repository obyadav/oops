using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class busbooking
    {

      public  void M2()
        {
            Console.WriteLine("Welcome to Fast Express Booking System");
            Console.WriteLine("Choose your ticket type:");
            Console.WriteLine("1. AC");
            Console.WriteLine("2. Non-AC");
            Console.Write("Enter your choice (1 or 2): ");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                Console.Write("Enter your choice again: ");
            }

            decimal price;
            if (choice == 1)
            {
                price = 150.00m; // Example price for AC ticket
                Console.WriteLine($"You have booked an AC ticket for Fast Express. Price: ${price}");
            }
            else if (choice == 2)
            {
                price = 100.00m; // Example price for Non-AC ticket
                Console.WriteLine($"You have booked a Non-AC ticket for Fast Express. Price: ${price}");
            }

            // Additional processing or actions can be added here based on the choice and price
            else
            {
                Console.WriteLine("Thank you for booking with us. Have a safe journey!");
            }
        }
    }

}
