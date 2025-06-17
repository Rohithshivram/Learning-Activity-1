using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a list of integers separated by commas:");
        string input = Console.ReadLine();

        try
        {
         
            List<int> numbers = input.Split(',')
                                     .Select(p => int.Parse(p.Trim()))
                                     .ToList();

         
            var greaterThan50 = numbers.Where(n => n > 50);
            Console.WriteLine("\nNumbers greater than 50:");
            Console.WriteLine(string.Join(", ", greaterThan50));

            
            var sortedNumbers = numbers.OrderBy(n => n);
            Console.WriteLine("\nSorted numbers (ascending):");
            Console.WriteLine(string.Join(", ", sortedNumbers));

            var squares = numbers.Select(n => n * n);
            Console.WriteLine("\nSquare of each number:");
            Console.WriteLine(string.Join(", ", squares));
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter only valid integers separated by commas.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred:");
            Console.WriteLine(ex.Message);
        }
    }
}
