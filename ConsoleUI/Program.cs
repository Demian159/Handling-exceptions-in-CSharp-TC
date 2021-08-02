using ExceptionsLibrary;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoCode demo = new DemoCode();
            try
            {
                int result = demo.GrandParentMethod(4);
                Console.WriteLine($"The value at the given position is { result }");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ypu give us bad information. Bad user!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                var inner = ex.InnerException;
                while (inner != null)
                {
                    Console.WriteLine(inner.StackTrace);
                    inner = inner.InnerException;
                }
            }
            
            Console.ReadLine();
        }
    }
}
