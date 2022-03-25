using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("Who is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"A woman named {userName} loves the color {color}.");
            Console.WriteLine($"Her favorite animal is {animal} and the band that she likes the most is {band}.");

            Console.WriteLine("What number would you like to add?");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Pick another number to add");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2, 4, 6);

            Console.WriteLine($"The sum is {sum}.");

            Console.WriteLine("What number would you like to multiply?");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("What is another number you would like to muliply?");
            int y = int.Parse(Console.ReadLine());

            int product = Multiply(x, y);
            Console.WriteLine($"The answer is {product}");

            Console.WriteLine("What number would you like to divide?");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Pick another number to divide");
            int b = int.Parse(Console.ReadLine());

            int divide = Divide(a, b);

            Console.WriteLine($"The answer is {divide}.");

            Console.WriteLine("What number to subtract?");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Pick another number to subtract");
            int d = int.Parse(Console.ReadLine());

            int subtract = Subtract(c, d);
            Console.WriteLine($"The answer is {subtract}");
        }
        public static int Sum(params int[] list)
        
        {

           int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;
         }
        public static int Multiply(int x, int y)
        { 
              return x * y;
        
        }
        public static int Divide(int a, int b)
        { 
             return a / b;
        
        }
        public static int Subtract(int c, int d)
        {
            return c - d;
        }
     }
 }
