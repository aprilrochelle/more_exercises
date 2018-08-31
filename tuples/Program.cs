using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>() {
              ("hammer", 5.99, 3),
              ("nails", 2.49, 2),
              ("paint", 49.98, 1),
              ("ceiling fan", 198.97, 1),
              ("wall sconce", 67.89, 4)
            };

            //  ANOTHER WAY TO DO IT:
            // (string product, double amount, int quantity) hammer = ("hammer", 5.99, 3);
            // (string product, double amount, int quantity) nails = ("nails", 2.49, 2);
            // (string product, double amount, int quantity) paint = ("paint", 49.98, 1);
            // (string product, double amount, int quantity) ceilingFan = ("ceiling fan", 198.97, 1);
            // (string product, double amount, int quantity) wallSconce = ("wall sconce", 67.89, 4);

            // transactions.Add(hammer);
            // transactions.Add(nails);
            // transactions.Add(paint);
            // transactions.Add(ceilingFan);
            // transactions.Add(wallSconce);

            int TotalProductsSold = 0;
            double TotalRevenue = 0;

            foreach ((string product, double amount, int quantity) t in transactions)
            {
                TotalProductsSold += t.quantity;
                TotalRevenue += t.quantity * t.amount;
            }

            Console.WriteLine($"We sold {TotalProductsSold} items today, for a total revenue of {TotalRevenue}.");
        }
    }
}
