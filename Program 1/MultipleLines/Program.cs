class Program
{
    static void Main()
    {
        string filePath = "output.txt";

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                Console.WriteLine("Enter text (type 'STOP' to finish):");
                string input;
                while (true)
                {
                    input = Console.ReadLine();
                    if (input.Trim().ToUpper() == "STOP")
                        break;
                    writer.WriteLine(input);
                }
            }

            Console.WriteLine("\nContents of 'output.txt':");
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (IOException ioEx)
        {
            Console.WriteLine("An I/O error occurred:");
            Console.WriteLine(ioEx.Message);
        }
        catch (UnauthorizedAccessException uaEx)
        {
            Console.WriteLine("Access to the file is denied:");
            Console.WriteLine(uaEx.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred:");
            Console.WriteLine(ex.Message);
        }
    }
}
