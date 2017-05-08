using System;
using Autofac;
using CardOrganizer.Interfaces;

//Shiftwise Code Challenge
//Author: Aaron Koller
//Date:   May 8th, 2017

namespace CardOrganizer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Instantiates AutoFac
            var builder = new ContainerBuilder();

            //searching for all the implemented interfaces
            builder.RegisterAssemblyTypes(typeof(Program).Assembly).AsImplementedInterfaces().InstancePerDependency();

            //Inversion of Control Container
            var container = builder.Build();

            try
            {
                //Gives us the object with all of its depenances resolved
                var game = container.Resolve<IGame>();

                //With Inversion of Control
                game.Start();

                //Without Inversion of Control
                //new Game(new Deck(new CardClassic())).Start();
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