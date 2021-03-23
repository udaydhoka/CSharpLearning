using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippets
{
    static class General
    {
        //fibonacci
        public static void Fibonacci()
        {
            int n1 = 0, n2 = 1, number, n3;
            number = int.Parse(Console.ReadLine());
            Console.Write($"{n1}\t{n2}\t");
            for (int i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                Console.Write($"{n3}\t");
                n1 = n2;
                n2 = n3;
            }
        }


        /// to check if its a prime
        public static void CheckPrimeNumber()
        {
            int num, flag = 0;
            num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"{num} is not a prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine($"{num} is a prime");
        }



        /// to find primes till a given number
        public static void PrintPrimeNumbers()
        {
            int n, isPrime = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                isPrime = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = 1;
                        break;
                    }
                }

                if (isPrime == 0)
                    Console.WriteLine($"{i} \t");
            }
        }

        ///number palindrome
        public static void NumberPalindrome()
        {
            int num, temp, sum = 0, inter;
            num = int.Parse(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                inter = num % 10;
                sum = (sum * 10) + inter;
                num = num / 10;
            }
            if (temp == sum)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }

        ///factorial
        public static void Factorial()
        {
            int num, fact = 1;
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }


        //armstrongnumber 
        public static void IsArmStrongNumber()
        {
            int num, temp, sum = 0, inter;
            num = int.Parse(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                inter = num % 10;
                sum = sum + (inter * inter * inter);
                num = num / 10;
            }
            if (temp == sum)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }

        //sum of digits
        public static void SumofDigits()
        {
            int num, temp, sum = 0, inter;
            num = int.Parse(Console.ReadLine());
            if (num >= 10)
            {
                while (num > 0 || sum > 9)
                {
                    if (num == 0)
                    {
                        num = sum;
                        sum = 0;
                    }
                    inter = num % 10;
                    sum = sum + inter;
                    num = num / 10;
                }
            }
            else
                sum = num;

            Console.WriteLine(sum);
        }


        // swapping variables without using 3rd var

        public static void SwapVariables()
        {
            int a = 5, b = 10;
            Console.WriteLine($"a = {a} , b = {b}");
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine($"a = {a} , b = {b}");
        }

        public static void Conversions()
        {
            //decimal to binary, oct, hexa
            int i = 10;
            Console.WriteLine(Convert.ToString(i, 2));
            Console.WriteLine(Convert.ToString(i, 8));
            Console.WriteLine(Convert.ToString(i, 16));
        }

        public static void FizzBuzz()
        {
            for (int i = 1; i < 100; i++)
            {
                if(i%3 == 0 && i%5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i%3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
