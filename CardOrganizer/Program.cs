using System;
using CardOrganizer.Models;

namespace CardOrganizer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                new Game(new CardClassic()).Start();
            }
            catch (Exception ex)
            {
                if (args.Length == 0)
                {
                    Console.WriteLine("This program is buggy.  Get you money back and contact the developer.");
                }
                else if (args[0] == "dev")
                    Console.WriteLine("ERROR MESSAGE: " + ex.Message + Environment.NewLine +
                                      "STACK TRACE " + ex.StackTrace);
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}