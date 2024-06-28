using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class Phonepay
    {
   


        static Dictionary<string, decimal> userWallets = new Dictionary<string, decimal>();

    static void Mainphonepay()
        {
            Console.WriteLine("Welcome to Phone Pay Backend Operations");

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add money to wallet");
                Console.WriteLine("2. Transfer money");
                Console.WriteLine("3. Check balance");
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
                        AddMoneyToWallet();
                        break;
                    case 2:
                        TransferMoney();
                        break;
                    case 3:
                        CheckBalance();
                        break;
                    case 4:
                        exit = true;
                        Console.WriteLine("Thank you for using Phone Pay. Goodbye!");
                        break;
                }
            }
        }

       public static void AddMoneyToWallet()
        {
            Console.WriteLine("\nAdd Money to Wallet:");
            Console.Write("Enter your phone number: ");
            string phoneNumber = Console.ReadLine().Trim();

            Console.Write("Enter amount to add: ");
            decimal amount;
            while (!decimal.TryParse(Console.ReadLine(), out amount) || amount <= 0)
            {
                Console.WriteLine("Invalid amount. Please enter a positive number.");
                Console.Write("Enter amount to add: ");
            }

            if (!userWallets.ContainsKey(phoneNumber))
            {
                userWallets[phoneNumber] = 0;
            }

            userWallets[phoneNumber] += amount;
            Console.WriteLine($"Amount ${amount} added to wallet of phone number {phoneNumber}. Current Balance: ${userWallets[phoneNumber]}");
        }

     public   static void TransferMoney()
        {
            Console.WriteLine("\nTransfer Money:");
            Console.Write("Enter your phone number: ");
            string senderPhoneNumber = Console.ReadLine().Trim();

            Console.Write("Enter recipient's phone number: ");
            string recipientPhoneNumber = Console.ReadLine().Trim();

            if (!userWallets.ContainsKey(senderPhoneNumber))
            {
                Console.WriteLine("Sender's wallet does not exist.");
                return;
            }

            Console.Write("Enter amount to transfer: ");
            decimal amount;
            while (!decimal.TryParse(Console.ReadLine(), out amount) || amount <= 0)
            {
                Console.WriteLine("Invalid amount. Please enter a positive number.");
                Console.Write("Enter amount to transfer: ");
            }

            if (userWallets[senderPhoneNumber] < amount)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            if (!userWallets.ContainsKey(recipientPhoneNumber))
            {
                userWallets[recipientPhoneNumber] = 0;
            }

            userWallets[senderPhoneNumber] -= amount;
            userWallets[recipientPhoneNumber] += amount;
            Console.WriteLine($"Amount ${amount} transferred from {senderPhoneNumber} to {recipientPhoneNumber}. Sender's Balance: ${userWallets[senderPhoneNumber]}, Recipient's Balance: ${userWallets[recipientPhoneNumber]}");
        }

     public   static void CheckBalance()
        {
            Console.WriteLine("\nCheck Balance:");
            Console.Write("Enter your phone number: ");
            string phoneNumber = Console.ReadLine().Trim();

            if (!userWallets.ContainsKey(phoneNumber))
            {
                Console.WriteLine("Wallet does not exist.");
            }
            else
            {
                Console.WriteLine($"Current Balance for phone number {phoneNumber}: ${userWallets[phoneNumber]}");
            }
        }

           public void mm2()
            {
                Mainphonepay();
            AddMoneyToWallet();
            TransferMoney();
            CheckBalance();

            }
        
    }

}

