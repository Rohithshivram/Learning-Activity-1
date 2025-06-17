using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;

class Program
{
    const int NumberOfFiles = 100;
    const int FileSizeInBytes = 10 * 1024 * 1024;
    const int BlockSize = 50 * 1024;
    const int Blockperfile = (FileSizeInBytes / BlockSize);
    static byte[] buffer = new byte[Blockperfile];

    static async Task Main()
    {
        Console.WriteLine("Starting Single-threaded Execution...\n");
        Stopwatch sw1 = Stopwatch.StartNew();
        await RunSingleThreaded();
        sw1.Stop();
        Console.WriteLine($"\nSingle-threaded Total Time: {sw1.Elapsed.TotalSeconds:F2} seconds\n");

        Console.WriteLine("\nStarting Multi-threaded Async Execution...\n");
        Stopwatch sw2 = Stopwatch.StartNew();
        await RunMultiThreaded();
        sw2.Stop();
        Console.WriteLine($"\nMulti-threaded Total Time: {sw2.Elapsed.TotalSeconds:F2} seconds");

        static async Task RunSingleThreaded()
        {
            for (int i = 1; i <= NumberOfFiles; i++)
            {
                string filename = $"File_{i}.bin";
                await WriteFileAsync(filename);
                Console.WriteLine($"{filename} Writing Completed");
            }
        }
        static async Task RunMultiThreaded()
        {
            List<Task> tasks = new List<Task>();
            for (int i = 1; i <= NumberOfFiles; i++) 
            {
                string filename = $"File_MT_{i}.bin";
                tasks.Add(Task.Run(async () =>
                {
                    await WriteFileAsync(filename);
                    Console.WriteLine($"{filename} Writing Completed");
                }));
            }
            await Task.WhenAll(tasks);
        }
        static async Task WriteFileAsync(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
            {
                for (int j = 0; j < Blockperfile; j++)
                {
                    await fs.WriteAsync(buffer, 0, buffer.Length);
                }
            }
        }
    }
}
