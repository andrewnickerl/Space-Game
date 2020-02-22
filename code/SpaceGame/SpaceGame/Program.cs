using System;
using SpaceGameLibrary;
using System.Collections.Generic;
using System.Threading;

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

            //foreach (var output in noir.Story)
            //{
            //    Console.Clear();
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Thread.Sleep(50);
               
            //    Console.WriteLine(output);
               
            //    Console.ReadKey();
            //}
            //foreach (var output in aventus.Story)
            //{
            //    Console.Clear();
            //    Console.WriteLine(output);
            //    Console.ReadKey();
            //}
            //foreach (var output in spotMee.Story)
            //{
            //    Console.Clear();
            //    Console.WriteLine(output);
            //    Console.ReadKey();
            //}
            //foreach (var output in wombodum.Story)
            //{
            //    Console.Clear();
            //    Console.WriteLine(output);
            //    Console.ReadKey();
            //}
            //foreach (var output in krytunga.Story)
            //{
            //    Console.Clear();
            //    Console.WriteLine(output);
            //    Console.ReadKey();
            //}
            run();
            Console.ReadKey();
        }
        static void run()
        {
            Player pc = new Player();
            pc.Name = "Andrew";
            pc.PetName = "Fluffy";

            int input; //used for input validation

            //Console.Write("What is your name?: ");
            //pc.Name = Console.ReadLine();
            //Console.Write("What is the name of your beloved fur baby? ");
            //pc.PetName = Console.ReadLine();

            Planet noir = new Planet(Enumerations.PlanetTypes.Noir, pc);

            for(int i = 0; i < noir.Story.Count; i++)
            {
                Console.Clear();
                Console.WriteLine(noir.Story[i]);
                
                if (i==5)
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 5 && input > 0)
                    {
                        switch (input)
                        {
                            case 1:
                                i = 6;
                                continue;
                            case 2:
                                i = 10;
                                continue;
                            case 3:
                                i = 13;
                                continue;
                            case 4:
                                i = 15;
                                continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\nYou may input only the number of one of the selections offered.");
                        Console.WriteLine("\n\n\n\nPress any key to continue...");
                        Console.ReadKey();
                        i = 4;
                        continue;
                    }
                }
                if (i == 9)
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 4 && input > 0)
                    {
                        switch (input)
                        {
                            case 1:
                                pc.Inventory.Add(noir.StoreInventory[1]);
                                break;
                            case 2:
                                pc.Inventory.Add(noir.StoreInventory[2]);
                                break;
                            case 3:
                                pc.Inventory.Add(noir.StoreInventory[3]);
                                break;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n\nYou may input only the number of one of the selections offered.");
                        Console.WriteLine("\n\n\n\nPress any key to continue...");
                        Console.ReadKey();
                        i = 8;
                        continue;
                    }
                }
                if (i==12)
                {
                    Console.WriteLine("GAME OVER");
                    return;
                }
                if (i==14)
                {
                    pc.Inventory.Add(noir.StoreInventory[0]);
                    break;
                }
                if (i == 16)
                {
                    Console.WriteLine("GAME OVER");
                    return;
                }
                Console.WriteLine("\n\n\n\nPress any key to continue...");
                Console.ReadKey();
            }

            //Planet aventus = new Planet(Enumerations.PlanetTypes.Aventus, pc);

            //foreach (var item in aventus.Story)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in aventus.StoreInventory)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Planet spotMee = new Planet(Enumerations.PlanetTypes.SpotMee, pc);

            //foreach (var item in spotMee.Story)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in spotMee.StoreInventory)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Planet wombodum = new Planet(Enumerations.PlanetTypes.Wombodum, pc);

            //foreach (var item in wombodum.Story)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in wombodum.StoreInventory)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Planet krytunga = new Planet(Enumerations.PlanetTypes.Krytunga, pc);

            //foreach (var item in krytunga.Story)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in krytunga.StoreInventory)
            //{
            //    Console.WriteLine(item.Name);
            //}
        }
    }
}
