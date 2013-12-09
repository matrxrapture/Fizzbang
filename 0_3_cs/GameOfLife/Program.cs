using System;
using System.Collections.Generic;
using GameOfLife.Printers;
using GameOfLife.Rules;
using GameOfLife.Worlds;
using GameOfLife.Worlds.Loaders;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new WorldBuilder(new RandomConfigurationLoader());

            var world = builder.Build();
            var outputGenerators = new List<IOutputWorldState>()
                {
                    new ConsoleOutput()
                };

            Console.WriteLine("The world has been built and ready to start");
            Console.WriteLine("Press any key to run the next iteration in the simulation");
            Console.WriteLine("Press q to stop the simulation");
            world.Print(outputGenerators);

            var action = Console.ReadLine();

            while (!"q".Equals(action))
            {              
                world.Run(new List<IGameOfLifeRule>()
                {
                    new UnderPopulationRule(),
                    new OverPopulationRule()
                });

                world.Print(outputGenerators);

                action = Console.ReadLine();
            }


        }
    }
}
