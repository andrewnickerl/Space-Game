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
        }
        static void run()
        {
            Player pc = new Player();
            //pc.Name = "Andrew";
            //pc.PetName = "Fluffy";

            int input; //used for input validation

            Console.Write("What is your name?: ");
            pc.Name = Console.ReadLine();
            Console.Write("What is the name of your beloved fur baby? ");
            pc.PetName = Console.ReadLine();


            //Planet 1 - Noir - Intro
            Planet noir = new Planet(Enumerations.PlanetTypes.Noir, pc);

            for (int i = 0; i < noir.Story.Count; i++)
            {
                Console.Clear();
                Console.WriteLine(noir.Story[i]);

                if (i == 5)
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 5 && input > 0)
                    {
                        switch (input)
                        {
                            case 1:
                                continue;
                            case 2:
                                i = 9;
                                continue;
                            case 3:
                                i = 12;
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
                        i--;
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
                                pc.EquipItem(noir.StoreInventory[1]);
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                break;
                            case 2:
                                pc.Inventory.Add(noir.StoreInventory[2]);
                                pc.EquipItem(noir.StoreInventory[2]);
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                break;
                            case 3:
                                pc.Inventory.Add(noir.StoreInventory[3]);
                                pc.EquipItem(noir.StoreInventory[3]);
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n\nYou may input only the number of one of the selections offered.");
                        Console.WriteLine("\n\n\n\nPress any key to continue...");
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i == 12)
                {
                    Console.WriteLine("GAME OVER");
                    return;
                }
                if (i == 14)
                {
                    pc.Inventory.Add(noir.StoreInventory[0]);
                    pc.EquipItem(noir.StoreInventory[0]);
                    Console.WriteLine("\n\n\n\nPress any key to continue...");
                    Console.ReadKey();
                    i = 5;
                    continue;
                }
                if (i == 16)
                {
                    Console.WriteLine("GAME OVER");
                    return;
                }
                Console.WriteLine("\n\n\n\nPress any key to continue...");
                Console.ReadKey();
            }

            //Planet 2 - Aventus
            Planet aventus = new Planet(Enumerations.PlanetTypes.Aventus, pc);

            for (int i = 0; i < aventus.Story.Count; i++)
            {
                Console.Clear();
                Console.WriteLine(aventus.Story[i]);

                if (i == 4)
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 6 && input > 0)
                    {
                        switch (input)
                        {
                            case 1:
                                continue;
                            case 2:
                                i = 7;
                                continue;
                            case 3:
                                i = 8;
                                continue;
                            case 4:
                                Console.Clear();
                                for (int j = 0; j < pc.Inventory.Count; j++)
                                {
                                    Console.Write(pc.Inventory[j].Name);
                                    if (j != pc.Inventory.Count - 1)
                                    {
                                        Console.Write(", ");
                                    }
                                }
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i--;
                                continue;
                            case 5:
                                Console.Clear();
                                Console.WriteLine($"\n{pc.Name}\nHP: {pc.Hp}\nEquipped Item: {pc.EquippedItem.Name}\nCurrency: {pc.Currency} mells\n");
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i--;
                                continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\nYou may input only the number of one of the selections offered.");
                        Console.WriteLine("\n\n\n\nPress any key to continue...");
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i == 8)
                {
                    i = 10;
                    continue;
                }
                if (i == 10)
                {
                    Console.WriteLine("GAME OVER");
                    return;
                }

                if (i == 12)
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 4 && input > 0)
                    {
                        switch (input)
                        {
                            case 1:
                                i = 13;
                                continue;
                            case 2:
                                i = 19;
                                continue;
                            case 3:
                                i = 17;
                                continue;
                            case 4:
                                Console.Clear();
                                for (int j = 0; j < pc.Inventory.Count; j++)
                                {
                                    Console.Write(pc.Inventory[j].Name);
                                    if (j != pc.Inventory.Count - 1)
                                    {
                                        Console.Write(", ");
                                    }
                                }
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i--;
                                continue;
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

                if (i == 14)
                {
                    pc.Inventory.Add(noir.StoreInventory[0]);
                    Console.WriteLine("\n\n\n\nPress any key to continue...");
                    Console.ReadKey();
                    i = 5;
                    continue;
                }
                if (i == 16)
                {
                    Console.WriteLine("GAME OVER");
                    return;
                }

                Console.WriteLine("\n\n\n\nPress any key to continue...");
                Console.ReadKey();
            }
            foreach (var item in aventus.Story)
            {
                Console.WriteLine(item);
            }
            foreach (var item in aventus.StoreInventory)
            {
                Console.WriteLine(item.Name);
            }

            Planet spotMee = new Planet(Enumerations.PlanetTypes.SpotMee, pc);

            for (int i = 0; i < spotMee.Story.Count; i++)
            {
                Console.Clear();
                Console.WriteLine(spotMee.Story[i]);

                if (i == 3)
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 5 && input > 0)
                    {
                        switch (input)
                        {
                            case 1:
                                continue;
                            case 2:
                                i = 6;
                                continue;
                            case 3:
                                Console.Clear();
                                for (int j = 0; j < pc.Inventory.Count; j++)
                                {
                                    Console.Write(pc.Inventory[j].Name);
                                    if (j != pc.Inventory.Count - 1)
                                    {
                                        Console.Write(", ");
                                    }
                                }
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i--;
                                continue;
                            case 4:
                                Console.Clear();
                                Console.WriteLine($"\n{pc.Name}\nHP: {pc.Hp}\nEquipped Item: {pc.EquippedItem.Name}\nCurrency: {pc.Currency} mells\n");
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i--;
                                continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\nYou may input only the number of one of the selections offered.");
                        Console.WriteLine("\n\n\n\nPress any key to continue...");
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i == 10)
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 7 && input > 0)
                    {
                        switch (input)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("\n \n Please enter your Arena Name:");
                                Console.ReadLine();
                                i = 18;
                                continue;
                            case 2:
                                i = 13;
                                continue;
                            case 3:
                                Console.Clear();
                                Console.WriteLine(spotMee.Story[18]);
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i = 17;
                                continue;
                            case 4:
                                continue;
                            case 5:
                                Console.Clear();
                                for (int j = 0; j < pc.Inventory.Count; j++)
                                {
                                    Console.Write(pc.Inventory[j].Name);
                                    if (j != pc.Inventory.Count - 1)
                                    {
                                        Console.Write(", ");
                                    }
                                }
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i--;
                                continue;
                            case 6:
                                Console.Clear();
                                Console.WriteLine($"\n{pc.Name}\nHP: {pc.Hp}\nEquipped Item: {pc.EquippedItem.Name}\nCurrency: {pc.Currency} mells\n");
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i--;
                                continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\nYou may input only the number of one of the selections offered.");
                        Console.WriteLine("\n\n\n\nPress any key to continue...");
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i == 13)
                {
                    Console.WriteLine("GAME OVER");
                    return;
                }
                if (i == 17)
                {
                    Console.WriteLine("GAME OVER");
                    return;
                }
                if (i == 18)
                {
                    i = 29;
                    continue;
                }
                if (i == 21)
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 5 && input > 0)
                    {
                        switch (input)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine(spotMee.Story[22]);
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                continue;
                            case 2:
                                i = 22;
                                continue;
                            case 3:
                                Console.Clear();
                                Console.WriteLine(spotMee.Story[25]);
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i = 24;
                                continue;
                            case 4:
                                i = 25;
                                continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\nYou may input only the number of one of the selections offered.");
                        Console.WriteLine("\n\n\n\nPress any key to continue...");
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i == 24)
                {
                    Console.WriteLine("GAME OVER");
                    return;
                }
                if (i == 27)
                {
                    Console.WriteLine("GAME OVER");
                    return;
                }
                if (i == 22)
                {
                    i = 27;
                    continue;
                }
                if (i == 25)
                {
                    i = 27;
                    continue;
                }


                Console.WriteLine("\n\n\n\nPress any key to continue...");
                Console.ReadKey();
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
}
