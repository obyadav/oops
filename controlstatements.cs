using System;

namespace oops
{
    class controlstatements
    {
        // Static method to demonstrate if-else control flow
        public static void Main11()
        {
            int number = 10;

            if (number > 5)
            {
                Console.WriteLine("The number is greater than 5.");
            }
            else if (number > 0)
            {
                Console.WriteLine("The number is greater than 0.");
            }
            else if (number == 10)
            {
                Console.WriteLine("The number is exactly 10.");
            }
            else
            {
                Console.WriteLine("The number is not greater than 5.");
            }
        }

        // Static method to demonstrate switch-case control flow
        public static void Main1()
        {
            int number = 3;

            switch (number)
            {
                case 1:
                    Console.WriteLine("The number is one.");
                    break;
                case 2:
                    Console.WriteLine("The number is two.");
                    break;
                case 3:
                    Console.WriteLine("The number is three.");
                    break;
                default:
                    Console.WriteLine("The number is not 1, 2, or 3.");
                    break;
            }
        }

        // Static method to demonstrate for loop
        public static void Main2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("i = " + i);
            }
        }

        // Static method to demonstrate while loop
        public static void Main4()
        {
            int i = 0;

            while (i < 5)
            {
                Console.WriteLine("i = " + i);
                i++;
            }
        }

        // Static method to demonstrate do-while loop
        public static void Main5()
        {
            int i = 0;

            do
            {
                Console.WriteLine("i = " + i);
                i++;
            } while (i < 5);
        }

        // Static method to demonstrate foreach loop
        public static void Main6()
        {
            string[] fruits = { "Apple", "Banana", "Cherry" };

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }

      public  void m3()
        {
            Console.WriteLine("obulesuyadav");
        }
    }
}

