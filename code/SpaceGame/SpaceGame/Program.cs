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
            Planet noir = new Planet(Enumerations.PlanetTypes.Noir);
            foreach (var item in noir.Story)
            {
                Console.WriteLine(item);
            }
        }
    }
}
