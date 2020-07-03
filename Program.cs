using System;

namespace App38
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int points = number + 1;
            for (int i = 0; i <= number; i++)
            {
                points += number - i;
            }
            Console.WriteLine(points);
        }
    }
}
