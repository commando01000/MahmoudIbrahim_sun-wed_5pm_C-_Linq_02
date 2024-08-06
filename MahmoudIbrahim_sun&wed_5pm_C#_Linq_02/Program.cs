﻿using System.Security.Cryptography;
using System.Threading;
using System.IO;
using static MahmoudIbrahim_sun_wed_5pm_C__Linq_02.ListGenerator;
namespace MahmoudIbrahim_sun_wed_5pm_C__Linq_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LinQ - Element Operators

            // Linq - Element Operator

            // 1. var productsList = ProductList.FirstOrDefault(product => product.UnitsInStock == 0);  // Fluent Syntax

            // 2.
            //var product = ProductList.FirstOrDefault(product => product.UnitPrice > 1000);  // Fluent Syntax

            //if (product != null)
            //{
            //    Console.WriteLine($"Product found: {product.ProductName}, Price: {product.UnitPrice}");
            //}
            //else
            //{
            //    Console.WriteLine("No product found with Price > 1000");
            //}

            // 3.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var secondNumber = Arr.Where(x => x > 5).ElementAtOrDefault(1);  // Fluent Syntax
            #endregion

            #region LinQ - Aggregate Operators
            // 1.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var getOdd = Arr.Where(x => x % 2 != 0).Count();  // Fluent Syntax
            //Console.WriteLine(getOdd);

            // 2.
            //var getCustomers = CustomerList.Select(customer => new { CustomerName = customer.CustomerName, CountOrders = customer.Orders.Count() }).GroupBy(customer => customer.CustomerName).ToList();  // Fluent Syntax

            //foreach (var group in getCustomers)
            //{
            //    foreach (var customer in group)
            //    {
            //        Console.WriteLine($"Customer: {customer.CustomerName}, Number of Orders: {customer.CountOrders}");
            //    }
            //}

            // 3.
            //var getCategories = ProductList.GroupBy(product => product.Category).Select(group => new { CategoryName = group.Key, CountProducts = group.Count() }).ToList();
            //foreach (var category in getCategories)
            //{
            //    Console.WriteLine($"Category: {category.CategoryName}, Number of Products: {category.CountProducts}");
            //}
            // 4.
            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Total = arr.Sum();  // Fluent Syntax
            //Console.WriteLine($"The total sum of the array is: {Total}");
            // 5.
            // Read all lines from the file into an array of strings
            string[] words = File.ReadAllLines("dictionary_english.txt");

            // Calculate the total number of characters
            int totalCharacters = words.Sum(word => word.Length);

            // Print the total number of characters
            Console.WriteLine($"The total number of characters in all words is: {totalCharacters}");

            // 6.
            string filePath = "dictionary_english.txt";

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Process the line (for now, just print it)
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
            #endregion
        }
    }
}