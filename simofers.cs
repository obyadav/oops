using System;

namespace oops
{
    class simofers
    {
        public void Main32()
        {
            Console.WriteLine("Welcome to Mobile SIM Offers!");

            while (true)
            {
                DisplayMenu();
                int choice = GetChoice();

                switch (choice)
                {
                    case 1:
                        DisplayOffer("SIM A", 10, "unlimited", 0, 20);
                        break;
                    case 2:
                        DisplayOffer("SIM B", 5, "500", 100, 15);
                        break;
                    case 3:
                        DisplayOffer("SIM C", 15, "unlimited", "unlimited", 25);
                        break;
                    case 4:
                        DisplayOffer("SIM D", 2, 200, 50, 10);
                        break;
                    case 5:
                        Console.WriteLine("Thank you for using our service. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Available SIM Offers:");
            Console.WriteLine("1. SIM A");
            Console.WriteLine("2. SIM B");
            Console.WriteLine("3. SIM C");
            Console.WriteLine("4. SIM D");
            Console.WriteLine("5. Exit");
        }

        static int GetChoice()
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

        static void DisplayOffer(string simName, int dataGB, object calls, object sms, int price)
        {
            Console.WriteLine($"Offer for {simName}:");
            Console.WriteLine($"Data: {dataGB}GB");
            Console.WriteLine($"Calls: {calls}");
            Console.WriteLine($"SMS: {sms}");
            Console.WriteLine($"Price: ${price}/month");

            // Ask if user wants to add extra plan
            Console.Write("Do you want to add an extra plan? (Y/N): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "y")
            {
                int extraGB = 0;
                int extraCalls = 0;
                int extraSMS = 0;

                Console.WriteLine("Enter extra data GB: ");
                while (!int.TryParse(Console.ReadLine(), out extraGB) || extraGB < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.WriteLine("Enter extra data GB: ");
                }

                Console.WriteLine("Enter extra minutes calls: ");
                while (!int.TryParse(Console.ReadLine(), out extraCalls) || extraCalls < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.WriteLine("Enter extra minutes calls: ");
                }

                Console.WriteLine("Enter extra SMS: ");
                while (!int.TryParse(Console.ReadLine(), out extraSMS) || extraSMS < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.WriteLine("Enter extra SMS: ");
                }

                // Calculate total amount including extra plan
                int totalAmount = price;
                totalAmount += CalculateExtraPlanAmount(extraGB, extraCalls, extraSMS);

                Console.WriteLine($"Total Amount (for 1 month with extra plan): ${totalAmount}");
            }
            else
            {
                Console.WriteLine($"Total Amount (for 1 month): ${price}");
            }
        }

        static int CalculateExtraPlanAmount(int extraGB, int extraCalls, int extraSMS)
        {
            // Example calculation based on additional charges per unit
            int extraDataCharge = 5; // $5 per extra GB
            int extraCallsCharge = 1; // $1 per extra minute
          int extraSMSCharge = 1; // $0.5 per extra SMS

            int totalExtraAmount = extraGB * extraDataCharge +
                                   extraCalls * extraCallsCharge +
                                   extraSMS * extraSMSCharge;

            return totalExtraAmount;
        }
    }
}
