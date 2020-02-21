using System;
using SpaceGameLibrary;
using System.Collections.Generic;

namespace SpaceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player pc = new Player();

            Console.Write("What is your name?: ");
            pc.Name = Console.ReadLine();
            Console.Write("What is the name of your beloved fur baby? ");
            pc.PetName = Console.ReadLine();

            Planet noir = new Planet(Enumerations.PlanetTypes.Noir, pc);

            foreach (var item in noir.Story)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
