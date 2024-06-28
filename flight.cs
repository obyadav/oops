using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class flight
    {
      
            static Dictionary<string, Dictionary<string, decimal>> ticketPrices = new Dictionary<string, Dictionary<string, decimal>>()
    {
        // Prices for flights from one state to another within the same country
        { "USA", new Dictionary<string, decimal>() {
                { "New York", 300.00m },
                { "California", 350.00m },
                { "Texas", 320.00m }
            }
        },
        // Prices for flights between countries
        { "Canada", new Dictionary<string, decimal>() {
                { "Toronto", 400.00m },
                { "Vancouver", 450.00m },
                { "Montreal", 420.00m }
            }
        }
    };

            static Dictionary<string, string> bookedTickets = new Dictionary<string, string>();

           public void King()
            {
                Console.WriteLine("Welcome to the Airplane Ticket Booking System");
                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine("\nChoose an option:");
                    Console.WriteLine("1. Book a ticket");
                    Console.WriteLine("2. Cancel a ticket");
                    Console.WriteLine("3. View booked tickets");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice (1-4): ");

                    int choice;
                    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                    {
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                        Console.Write("Enter your choice again: ");
                    }

                    switch (choice)
                    {
                        case 1:
                        BookTicket();
                            break;
                        case 2:
                            CancelTicket();
                            
                        
                        break;
                        case 3:
                            ViewBookedTickets();
                            break;
                        case 4:
                            exit = true;
                            Console.WriteLine("Thank you for using the Airplane Ticket Booking System. Goodbye!");
                            break;
                    }
                }
            }

           public void BookTicket()
            {
                Console.WriteLine("\nBooking a Ticket:");
                Console.Write("Enter your country: ");
                string country = Console.ReadLine().Trim();

                if (!ticketPrices.ContainsKey(country))
                {
                    Console.WriteLine("We do not provide services for this country.");
                    return;
                }

                Console.Write("Enter your destination state/country: ");
                string destination = Console.ReadLine().Trim();

                if (!ticketPrices[country].ContainsKey(destination))
                {
                    Console.WriteLine("Destination not available for booking.");
                    return;
                }

                decimal price = ticketPrices[country][destination];
                string ticketKey = $"{country} - {destination}";

                bookedTickets[ticketKey] = price.ToString("C2");
                Console.WriteLine($"Ticket booked successfully from {country} to {destination}. Price: {price:C2}");
            }

            public void CancelTicket()
            {
                Console.WriteLine("\nCanceling a Ticket:");
                Console.Write("Enter your country: ");
                string country = Console.ReadLine().Trim();

                Console.Write("Enter your destination state/country: ");
                string destination = Console.ReadLine().Trim();

                string ticketKey = $"{country} - {destination}";

                if (bookedTickets.ContainsKey(ticketKey))
                {
                    bookedTickets.Remove(ticketKey);
                    Console.WriteLine($"Ticket from {country} to {destination} canceled successfully.");
                }
                else
                {
                    Console.WriteLine($"No ticket found from {country} to {destination}.");
                }
            }

            public void ViewBookedTickets()
            {
                Console.WriteLine("\nBooked Tickets:");
                if (bookedTickets.Count == 0)
                {
                    Console.WriteLine("No tickets booked yet.");
                }
                else
                {
                    foreach (var ticket in bookedTickets)
                    {
                        Console.WriteLine($"- {ticket.Key}, Price: {ticket.Value}");
                    }
                }
            }
        }
    }
        



