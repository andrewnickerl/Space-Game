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
            pc.Name = "PlayerName";
            pc.PetName = "PetName";
            Planet noir = new Planet(Enumerations.PlanetTypes.Noir, pc);
            Planet aventus = new Planet(Enumerations.PlanetTypes.Aventus, pc);
            Planet spotMee = new Planet(Enumerations.PlanetTypes.SpotMee, pc);
            Planet wombodum = new Planet(Enumerations.PlanetTypes.Wombodum, pc);
            Planet krytunga = new Planet(Enumerations.PlanetTypes.Krytunga, pc);

            foreach (var output in noir.Story)
            {
                Console.WriteLine(output);
                Console.Clear();
            }

            Console.ReadKey();
        }
        static void run()
        {
            Player pc = new Player();
            //pc.Name = "Andrew";
            //pc.PetName = "Jackson";

            Console.Write("What is your name?: ");
            pc.Name = Console.ReadLine();
            Console.Write("What is the name of your beloved fur baby? ");
            pc.PetName = Console.ReadLine();

            Planet noir = new Planet(Enumerations.PlanetTypes.Noir, pc);

            foreach (var item in noir.Story)
            {
                Console.WriteLine(item);
                Console.Clear();
            }

            Planet aventus = new Planet(Enumerations.PlanetTypes.Aventus, pc);

            foreach (var item in aventus.Story)
            {
                Console.WriteLine(item);
            }
            foreach (var item in aventus.StoreInventory)
            {
                Console.WriteLine(item.Name);
            }

            Planet spotMee = new Planet(Enumerations.PlanetTypes.SpotMee, pc);

            foreach (var item in spotMee.Story)
            {
                Console.WriteLine(item);
            }
            foreach (var item in spotMee.StoreInventory)
            {
                Console.WriteLine(item.Name);
            }

            Planet wombodum = new Planet(Enumerations.PlanetTypes.Wombodum, pc);

            foreach (var item in wombodum.Story)
            {
                Console.WriteLine(item);
            }
            foreach (var item in wombodum.StoreInventory)
            {
                Console.WriteLine(item.Name);
            }

            Planet krytunga = new Planet(Enumerations.PlanetTypes.Krytunga, pc);

            foreach (var item in krytunga.Story)
            {
                Console.WriteLine(item);
            }
            foreach (var item in krytunga.StoreInventory)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
