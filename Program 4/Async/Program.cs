using System;
using System.Threading.Tasks;

class Program
{

    static async Task ProcessOrderAsync(string item)
    {
        Console.WriteLine("You can continue using the app while the order is being processed.");
        await Task.Delay(5000); 
        Console.WriteLine($"Order for {item} is ready!");
    }

static async Task Main(string[] args)
    {
        Console.Write("Enter the item you want to order: ");
        string item = Console.ReadLine();

        Console.WriteLine("Processing order...");

        await ProcessOrderAsync(item);
    }

  
}
