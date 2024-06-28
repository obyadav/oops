using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class programsforinterview
    {


        // print numbers from 1 to 10
        static void numbers()
        {
            for (int i = 1; i <= 10; i++)
            { // step 1= initilization step2= condition step 3==increment
                Console.WriteLine(i); // print out put1 to 10
            }
        }

        static void Sumnumbers()
        {
            int N = 10; // Example value
            int sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum += i; // here i value is added to the sum
            }

            Console.WriteLine($"Sum of first {N} natural numbers is: {sum}");//embeded expression
        }
        static void factorial()
        {
            int number = 5; // Example value
            int factorial = 1; //starts from 1

            for (int i = 1; i <= number; i++)
            {
                factorial *= i; //multiplied  i value with factorial 
            }

            Console.WriteLine($"Factorial of {number} is: {factorial}");
        }

        static void stringReverse1()
        {
            string str = "hello";
            string reversedStr = " ";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedStr += str[i];
            }

            Console.WriteLine($"Reversed string is: {reversedStr}");
        }

        static void Multiplicationnumber()
        {
            int number = 5; // Example value

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
        //fibnocies
        static void Fibnociesseries()
        {
            int n = 10; // Number of terms
            int a = 0, b = 1;

            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 2; i < n; i++)
            {
                int next = a + b;
                Console.WriteLine(next);
                a = b;
                b = next;
            }
        }
        //count vowels
        static void vowels()
        {
            string str = "Hello World";
            int vowelCount = 0;
            string vowels = "aeiouAEIOU";

            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]))
                {
                    vowelCount++;
                }
            }

            Console.WriteLine($"Number of vowels in the string is: {vowelCount}");
        }

        static void LargeElements()
        {
            int[] numbers = { 3, 5, 7, 2, 8, 1 };
            int largest = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }

            Console.WriteLine($"Largest element in the array is: {largest}");
        }
        static void Evennumber()
        {
            int N = 20; // Example value

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void primenumber()
        {
            int number = 29; // Example value
            bool isPrime = true;

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }

        static  void removeduplicate()
        {
            int[] arr = { 1, 2, 3, 4, 5, 54, 65, 5, 6, 7, 8, 8 };
            List<int> repeatnumbers = new List<int>();

            for(int i=0; i < arr.Length-1 ; i++)
            {
                if (!repeatnumbers.Contains(arr[i]))
                {

                    repeatnumbers.Add(arr[i]);

                }
            }

            // Convert the list back to an array if needed
            int[] result = repeatnumbers.ToArray();
            Console.WriteLine("Array after removing duplicates:");
            foreach (int number in result)
            {
                Console.Write(number + " ");
            }

        }
            
        

    static void duplicateandaccurencenumbers()
        {
            int[] numbers = { 1, 2, 2, 3, 4, 4, 5, 6, 6, 7, 7, 7 };
            Dictionary<int, int> numberCounts = new Dictionary<int, int>();

            // Loop through each number in the array
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numberCounts.ContainsKey(numbers[i]))
                {
                    // Increment the count if the number is already in the dictionary
                    numberCounts[numbers[i]]++;
                }
                else
                {
                    // Add the number to the dictionary with an initial count of 1
                    numberCounts[numbers[i]] = 1;
                }
            }

            // Print the duplicate numbers and their counts
            Console.WriteLine("Duplicate numbers and their counts:");
            foreach (var pair in numberCounts)
            {
                if (pair.Value > 1)
                {
                    Console.WriteLine($"Number: {pair.Key}, Count: {pair.Value}");
                }
            }
        }
        public void getall()
        {
            numbers();
            Sumnumbers();
            duplicateandaccurencenumbers();
            removeduplicate();
            primenumber();
            factorial();
            stringReverse1();
            Multiplicationnumber();
            Fibnociesseries();
            vowels();
            LargeElements();
            Evennumber();
            primenumber();


        }

    }
}



