using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
          Random random = new Random();

          // Create a list
          List<int> randNums = new List<int>();

          // Populate the list
          for (int r = 0; r < 20; r++)
          {
            randNums.Add(random.Next(51));
          }

          Console.WriteLine($"Twenty random numbers between 1 and 50: {String.Join(", ", randNums)}");

          List<int> rSquared = new List<int>();

          foreach (int num in randNums)
          {
              int newNum = num * num;
              rSquared.Add(newNum);
          }

          Console.WriteLine($"The twenty random numbers, squared: {String.Join(", ", rSquared)}");
          List<int> evens = new List<int>();
          foreach (int s in rSquared)
          {
              if (s % 2 == 0) {
                evens.Add(s);
              }
          }

          Console.WriteLine($"Squares with odd numbers removed: {String.Join(", ", evens)}");
        }
    }
}
