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
            //loops through story List<string> for Noir and manipulates output from list using i based on user input
            for (int i = 0; i < noir.Story.Count; i++)
            {
                Console.Clear(); //clears console before each iteration
                Console.WriteLine(noir.Story[i]); //displays each element of the story List<string>
                
                if (i==5) //decide what action to take upon waking up
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 5 && input > 0) //takes user input an validates that it is within appropriate range
                    { 
                        switch (input)
                        {
                            case 1: //ask ship security system who was onboard
                                continue;
                            case 2: //follow footprints leading outside ship
                                i = 9;
                                continue;
                            case 3: //grab astrocola and watch toons
                                i = 12;
                                continue;
                            case 4: //set security to BAMBAM
                                i = 15;
                                continue;
                        }
                    }
                    else //handles incorrect user input
                    {
                        Console.WriteLine("\n\nYou may input only the number of one of the selections offered.");
                        Console.WriteLine("\n\n\n\nPress any key to continue...");
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i == 9) //decide which item to grab as you leave the ship
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 4 && input > 0)
                    {
                        switch (input)
                        {
                            case 1:  //blitz blade
                                pc.Inventory.Add(noir.StoreInventory[1]);
                                pc.EquipItem(noir.StoreInventory[1]);
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                break;
                            case 2: //shield o' saturn
                                pc.Inventory.Add(noir.StoreInventory[2]);
                                pc.EquipItem(noir.StoreInventory[2]);
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                break;
                            case 3: //plasma rifle
                                pc.Inventory.Add(noir.StoreInventory[3]);
                                pc.EquipItem(noir.StoreInventory[3]);
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    }
                    else //handles incorrect user input
                    {
                        Console.WriteLine("\n\nYou may input only the number of one of the selections offered.");
                        Console.WriteLine("\n\n\n\nPress any key to continue...");
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i==12) //oxygen sucked out of you death
                {
                    Console.WriteLine("GAME OVER");
                    return;
                }
                if (i==14) //add DAVE after watching toons/drinking cola
                {
                    pc.Inventory.Add(noir.StoreInventory[0]);
                    pc.EquipItem(noir.StoreInventory[0]);
                    Console.WriteLine("\n\n\n\nPress any key to continue...");
                    Console.ReadKey();
                    i = 5;
                    continue;
                }
                if (i == 16) //sabotaged weapon system death
                {
                    Console.WriteLine("GAME OVER");
                    return;
                }
                Console.WriteLine("\n\n\n\nPress any key to continue...");
                Console.ReadKey();
            }

            //Planet 2 - Aventus
            Planet aventus = new Planet(Enumerations.PlanetTypes.Aventus, pc);
            //Loops through story List<string> for Aventus and manipulates output from list using i based on user input
            for (int i = 0; i < aventus.Story.Count; i++)
            {
                Console.Clear(); //clears console before every iteration
                Console.WriteLine(aventus.Story[i]); //outputs the string at position i from the Aventus story list

                if (i == 4) //choose the action for your conversation with Carlsin
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 6 && input > 0)
                    {
                        switch (input)
                        {
                            case 1: //answer his question
                                continue;
                            case 2: //shove by him
                                i = 7;
                                continue;
                            case 3: //ask if he is an ostrich
                                i = 8;
                                continue;
                            case 4: //see inventory/equip new item
                                Console.Clear();
                                int j;
                                for (j = 0; j < pc.Inventory.Count; j++)
                                {              
                                    Console.WriteLine($"{j+1}) {pc.Inventory[j].Name}");                                                     
                                }

                                Console.WriteLine("\n\nIf you would like to equip an item, input it's number.\nTo keep your equipped item the same, hit another key.\n");
                                if (int.TryParse(Console.ReadLine(), out input) && input < j + 1 && input > 0)
                                {
                                    pc.EquipItem(pc.Inventory[input - 1]);
                                    Console.WriteLine($"\nYou have equipped {pc.EquippedItem.Name}.");
                                }
                                
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i--;
                                continue;
                            case 5: //see stats
                                Console.Clear();
                                Console.WriteLine($"\n{pc.Name}\nHP: {pc.Hp}\nEquipped Item: {pc.EquippedItem.Name}\nCurrency: {pc.Currency} mells\n\nStatus:\n");
                                foreach  (string status in pc.PlayerStatus)
                                {
                                    Console.WriteLine($"{status}\n");
                                }
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i--;
                                continue;
                        }
                    }
                    else //handle incorrect user inputs
                    {
                        Console.WriteLine("\n\nYou may input only the number of one of the selections offered.");
                        Console.WriteLine("\n\n\n\nPress any key to continue...");
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i == 8) //shove carlsin and continue on your way (option 2)
                {
                    i = 10;
                    Console.WriteLine("\n\n\n\nPress any key to continue...");
                    Console.ReadKey();
                    continue;
                }
                if (i == 10) //Carlsin bites your head off after option 3
                {
                    Console.WriteLine("GAME OVER");
                    return;
                }

                if (i == 12) //Decision at crossroads
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 5 && input > 0)
                    {
                        switch (input)
                        {
                            case 1: //go to marketplace
                                continue;
                            case 2: //go to jungle
                                i = 18;
                                continue;
                            case 3: //attempt to ride schlemal
                                i = 16;
                                continue;
                            case 4: //see inventory/equip item
                                //clear console and display inventory
                                Console.Clear();
                                int j;
                                for (j = 0; j < pc.Inventory.Count; j++)
                                {
                                    Console.WriteLine($"{j + 1}) {pc.Inventory[j].Name}");
                                }
                                //provide option to switch equipped item
                                Console.WriteLine("\n\nIf you would like to equip an item, input it's number.\nTo keep your equipped item the same, hit another key.\n");
                                if (int.TryParse(Console.ReadLine(), out input) && input < j + 1 && input > 0)
                                {
                                    pc.EquipItem(pc.Inventory[input - 1]);
                                    Console.WriteLine($"\nYou have equipped {pc.EquippedItem.Name}.");
                                }                                
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                //decrement i to bring loop back to decision statement
                                i--;
                                continue;
                        }
                    }
                    else //handle incorrect user input
                    {
                        Console.WriteLine("\n\nYou may input only the number of one of the selections offered.");
                        Console.WriteLine("\n\n\n\nPress any key to continue...");
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i == 14) //User input at marketplace to buy items, sell items, see inventory/equip item, or leave
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 6 && input > 0)
                    {
                        switch (input)
                        {
                            case 1: //buy items
                                continue;
                            case 2: //sell items
                                i = 15;
                                continue;
                            case 3: //view inventory/equip item
                                //clear console and display inventory
                                Console.Clear();
                                int j;
                                for (j = 0; j < pc.Inventory.Count; j++)
                                {
                                    Console.WriteLine($"{j + 1}) {pc.Inventory[j].Name}");
                                }
                                //provide option to switch equipped item
                                Console.WriteLine("\n\nIf you would like to equip an item, input it's number.\nTo keep your equipped item the same, hit another key.\n");
                                if (int.TryParse(Console.ReadLine(), out input) && input < j + 1 && input > 0)
                                {
                                    pc.EquipItem(pc.Inventory[input - 1]);
                                    Console.WriteLine($"\nYou have equipped {pc.EquippedItem.Name}.");
                                }
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                //decrement i to bring loop back to decision statement
                                i--;
                                continue;
                            case 4: //see stats
                                Console.Clear();
                                Console.WriteLine($"\n{pc.Name}\nHP: {pc.Hp}\nEquipped Item: {pc.EquippedItem.Name}\nCurrency: {pc.Currency} mells\n\nStatus:\n");
                                foreach (string status in pc.PlayerStatus)
                                {
                                    Console.WriteLine($"{status}\n");
                                }
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i--;
                                continue;
                            case 5: //leave
                                i = 18;
                                continue;
                        }
                    }
                    else //handle incorrect user input
                    {
                        Console.WriteLine("\n\nYou may input only the number of one of the selections offered.");
                        Console.WriteLine("\n\n\n\nPress any key to continue...");
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i == 15) //buy menu
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 6 && input > 0)
                    {
                        switch (input)
                        {
                            case 1: //buy Auto Chopper
                                if(aventus.Buy(pc, aventus.StoreInventory, "Auto Chopper"))
                                {
                                    Console.WriteLine("\nYou have purchased an Auto Chopper.\n");
                                }
                                else
                                {
                                    Console.WriteLine("Either you have insufficient funds to purchase this item or it is out of stock.");
                                }
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i = 13;
                                continue;
                            case 2: //buy Jungle Starter Kit
                                if (aventus.Buy(pc, aventus.StoreInventory, "Jungle Starter Kit"))
                                {
                                    Console.WriteLine("\nYou have purchased a Jungle Starter Kit.\n");
                                }
                                else
                                {
                                    Console.WriteLine("Either you have insufficient funds to purchase this item or it is out of stock.");
                                }
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i = 13;
                                continue;
                            case 3: //buy Schlemal Doll
                                if (aventus.Buy(pc, aventus.StoreInventory, "Schlemal Doll"))
                                {
                                    Console.WriteLine("\nYou have purchased a Schlemal Doll.\n");
                                }
                                else
                                {
                                    Console.WriteLine("Either you have insufficient funds to purchase this item or it is out of stock.");
                                }
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i = 13;
                                continue;
                            case 4: //buy Green Remote
                                if (aventus.Buy(pc, aventus.StoreInventory, "Green Remote"))
                                {
                                    Console.WriteLine("\nYou have purchased a Green Remote.\n");
                                }
                                else
                                {
                                    Console.WriteLine("Either you have insufficient funds to purchase this item or it is out of stock.");
                                }
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i = 13;
                                continue;
                            case 5: //leave
                                Console.WriteLine("\nYou decide not to buy for now.");
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i = 13;
                                continue;
                        }
                    }
                    else //handle incorrect user input
                    {
                        Console.WriteLine("\n\nYou may input only the number of one of the selections offered.");
                        Console.WriteLine("\n\n\n\nPress any key to continue...");
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i==16) //sell menu
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 3 && input > 0)
                    {
                        switch (input)
                        {
                            case 1: //show player inventory with item values and option to sell
                                Console.Clear();
                                //presents player inventory with values of each inventory item
                                int j;
                                for (j = 0; j < pc.Inventory.Count; j++)
                                {
                                    Console.WriteLine($"{j + 1}) {pc.Inventory[j].Name}: {pc.Inventory[j].Value} mells");
                                }
                                //based on user selection, sell item from inventory or move on
                                Console.WriteLine("\n\nIf you would like to sell an item, input it's number.\nIf you choose not to sell, press any other key.\n");
                                if (int.TryParse(Console.ReadLine(), out input) && input < j + 1 && input > 0)
                                {
                                    string itemSoldName = pc.Inventory[input - 1].Name;
                                    short itemSoldValue = pc.Inventory[input - 1].Value;
                                    if (aventus.Sell(pc, itemSoldName))
                                    {
                                        Console.WriteLine($"You have sold {itemSoldName} for {itemSoldValue} mells.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You may not sell this item.");
                                    }
                                    Console.WriteLine("\n\n\n\nPress any key to continue...");
                                    Console.ReadKey();
                                    i = 13;
                                    continue;
                                }

                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i--;
                                continue;
                                
                            case 2: //leave
                                Console.WriteLine("\nYou decide not to sell for now.");
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i = 13;
                                continue;
                        }
                    }
                    else //handle incorrect user input
                    {
                        Console.WriteLine("\n\nYou may input only the number of one of the selections offered.");
                        Console.WriteLine("\n\n\n\nPress any key to continue...");
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }

                if (i == 18) //attempt to ride schlemal death
                {
                    Console.WriteLine("GAME OVER");
                    return;
                }

                if (i == 20) //jungle path option
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 5 && input > 0)
                    {
                        switch (input)
                        {
                            case 1: //take right path
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                continue;

                            case 2: //take left path
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i = 22;
                                continue;
                            case 3: //check inventory
                                Console.Clear();
                                int j;
                                for (j = 0; j < pc.Inventory.Count; j++)
                                {
                                    Console.WriteLine($"{j + 1}) {pc.Inventory[j].Name}");
                                }

                                Console.WriteLine("\n\nIf you would like to equip an item, input it's number.\nTo keep your equipped item the same, hit another key.\n");
                                if (int.TryParse(Console.ReadLine(), out input) && input < j + 1 && input > 0)
                                {
                                    pc.EquipItem(pc.Inventory[input - 1]);
                                    Console.WriteLine($"\nYou have equipped {pc.EquippedItem.Name}.");
                                }

                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i--;
                                continue;
                            case 4: //check stats
                                Console.Clear();
                                Console.WriteLine($"\n{pc.Name}\nHP: {pc.Hp}\nEquipped Item: {pc.EquippedItem.Name}\nCurrency: {pc.Currency} mells\n\nStatus:\n");
                                foreach (string status in pc.PlayerStatus)
                                {
                                    Console.WriteLine($"{status}\n");
                                }
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i--;
                                continue;
                        }
                    }
                    else //handle incorrect user input
                    {
                        Console.WriteLine("\n\nYou may input only the number of one of the selections offered.");
                        Console.WriteLine("\n\n\n\nPress any key to continue...");
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }

                if (i == 22) //jungle flower death
                {
                    Console.WriteLine("GAME OVER");
                    return;
                }

                if (i == 25) //manticore decision
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 4 && input > 0)
                    {
                        switch (input)
                        {
                            case 1: //feed manticore
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i = 28;
                                continue;
                            case 2: //kick manticore
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                continue;
                            case 3: //run to ship
                                Console.WriteLine("\n\n\n\nPress any key to continue...");
                                Console.ReadKey();
                                i = 30;
                                continue;
                        }
                    }
                }

                if (i == 28)
                {
                    Console.WriteLine("GAME OVER");
                    return;
                }

                if (i == 30)
                {
                    pc.PlayerStatus.Add("Missing a hand");
                    pc.PlayerStatus.Add("Has manticore cub pet");
                    Console.WriteLine($"\n{pc.Name}\nHP: {pc.Hp}\nEquipped Item: {pc.EquippedItem.Name}\nCurrency: {pc.Currency} mells\n\nStatus:\n");
                    foreach (string status in pc.PlayerStatus)
                    {
                        Console.WriteLine($"{status}");
                    }
                }

                Console.WriteLine("\n\n\n\nPress any key to continue...");
                Console.ReadKey();
            }

        }
    }
}
