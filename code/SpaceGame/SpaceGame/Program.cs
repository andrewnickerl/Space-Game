using System;
using SpaceGameLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace SpaceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new[]
{


                      @"   ***** *    **   ***                                     *                            * ***",
                    @"  ******  *  *****    ***                                  **                           *  ****                                           *",
                   @"  **   *  *     *****   ***                                 **                          *  *  ***                                         **",
                 @"   *    *  **     * **      **                                **                         *  **   ***                                        **",
                 @"       *  ***     *         ** **   ****                      **            ****        *  ***    *** **   ****                  ****     ********",
                 @"      **   **     *         **  **    ***  * *** **** ****    ** ****      * ***  *    **   **     **  **    ***  *    ***      * **** * ********",
                 @"      **   **     *         **  **     ****   *** **** ***  * *** ***  *  *   ****     **   **     **  **     ****    * ***    **  ****     **",
                   @"    **   **     *         **  **      **     **  **** ****  **   ****  **    **      **   **     **  **      **    *   ***  ****          **",
                   @"    **   **     *         **  **      **     **   **   **   **    **   **    **      **   **     **  **      **   **    ***   ***         **     ",
                    @"   **   **     *         **  **      **     **   **   **   **    **   **    **      **   **     **  **      **   ********      ***       **     ",
                     @"   **  **     *         **  **      **     **   **   **   **    **   **    **       **  ** *** **  **      **   *******         ***     **     ",
                      @"   ** *      *         *   **      **     **   **   **   **    **   **    **        ** *   ****   **      **   **         ****  **     **     ",
                      @"    ***      ***      *     ******* **    **   **   **   **    **    ******          ***     ***   ******* **  ****    * * **** *      **     ",
                      @"     ******** ********       *****   **   ***  ***  ***   *****       ****            ******* **    *****   **  *******     ****        **    ",
                       @"      ****     ****                       ***  ***  ***   ***                          ***   **                 *****                        ",
                          @"                                                                                         **                                              ",
                             @"                                                                                       *                                               ",
                                @"                                                                                   *                                                ",
                                   @"                                                                               *                                                 ",


            };
            Console.WindowWidth = 170;
            Console.WriteLine("\n\n");
            var maxLength = arr.Aggregate(0, (max, line) => Math.Max(max, line.Length));
            var x = Console.BufferWidth / 2 - maxLength / 2;
            for (int y = -arr.Length; y < Console.WindowHeight + arr.Length; y++)
            {
                ConsoleDraw(arr, x, y);
                Thread.Sleep(100);
            }
            foreach (char letter in "Press any key to begin the game...")
            {
                Console.Write(letter);
                Thread.Sleep(10);
            }
            Console.ReadKey();
            Console.Clear();
            run();
        }

        static void ConsoleDraw(IEnumerable<string> lines, int x, int y)
        {
            if (x > Console.WindowWidth) return;
            if (y > Console.WindowHeight) return;

            var trimLeft = x < 0 ? -x : 0;
            int index = y;

            x = x < 0 ? 0 : x;
            y = y < 0 ? 0 : y;

            var linesToPrint =
                from line in lines
                let currentIndex = index++
                where currentIndex > 0 && currentIndex < Console.WindowHeight
                select new
                {
                    Text = new String(line.Skip(trimLeft).Take(Math.Min(Console.WindowWidth - x, line.Length - trimLeft)).ToArray()),
                    X = x,
                    Y = y++
                };

            Console.Clear();
            foreach (var line in linesToPrint)
            {
                Console.SetCursorPosition(line.X, line.Y);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(line.Text);
            }
        }
        static void run()
        {
            Player pc = new Player();
            BattleEntity battleEntity = new BattleEntity();

            int input; //used for input validation

            foreach (char letter in "What is your name?: ")
            {
                Console.Write(letter);
                Thread.Sleep(10);
            }
            pc.Name = Console.ReadLine();
            foreach (char letter in "What is the name of your beloved fur baby? ")
            {
                Console.Write(letter);
                Thread.Sleep(10);
            }
            pc.PetName = Console.ReadLine();


            //Planet 1 - Noir - Intro
            Planet noir = new Planet(Enumerations.PlanetTypes.Noir, pc, battleEntity);
            //loops through story List<string> for Noir and manipulates output from list using i based on user input
            for (int i = 0; i < noir.Story.Count; i++)
            {
                Console.Clear(); //clears console before each iteration
                foreach (char letter in noir.Story[i])  //displays each element of the story List<string>
                {
                    Console.Write(letter);
                    Thread.Sleep(10);
                }

                if (i == 5) //decide what action to take upon waking up
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
                        foreach (char letter in "\n\nYou may input only the number of one of the selections offered.")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        foreach (char letter in "\n\n\n\nPress any key to continue...")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
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
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                break;
                            case 2: //shield o' saturn
                                pc.Inventory.Add(noir.StoreInventory[2]);
                                pc.EquipItem(noir.StoreInventory[2]);
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                break;
                            case 3: //plasma rifle
                                pc.Inventory.Add(noir.StoreInventory[3]);
                                pc.EquipItem(noir.StoreInventory[3]);
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                break;
                        }
                        break;
                    }
                    else //handles incorrect user input
                    {
                        foreach (char letter in "\n\nYou may input only the number of one of the selections offered.")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        foreach (char letter in "\n\n\n\nPress any key to continue...")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i == 12) //oxygen sucked out of you death
                {
                    foreach (char letter in "GAME OVER")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
                    return;
                }
                if (i == 14) //add DAVE after watching toons/drinking cola
                {
                    pc.Inventory.Add(noir.StoreInventory[0]);
                    pc.EquipItem(noir.StoreInventory[0]);
                    foreach (char letter in "\n\n\n\nPress any key to continue...")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
                    Console.ReadKey();
                    i = 5;
                    continue;
                }
                if (i == 12)
                {
                    foreach (char letter in "GAME OVER")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
                }                
                foreach (char letter in "\n\n\n\nPress any key to continue...")
                {
                    Console.Write(letter);
                    Thread.Sleep(10);
                }
                Console.ReadKey();
            }


            //Planet 2 - Aventus
            Planet aventus = new Planet(Enumerations.PlanetTypes.Aventus, pc, battleEntity);
            //Loops through story List<string> for Aventus and manipulates output from list using i based on user input
            for (int i = 0; i < aventus.Story.Count; i++)
            {
                Console.Clear();  //outputs the string at position i from the Aventus story list
                foreach (char letter in aventus.Story[i])
                {
                    Console.Write(letter);
                    Thread.Sleep(10);
                }


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
                                    foreach (char letter in $"{j + 1}) {pc.Inventory[j].Name}")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                    Console.Write("\n");
                                }
                                foreach (char letter in "\n\nIf you would like to equip an item, input it's number.\nTo keep your equipped item the same, hit another key.\n")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                if (int.TryParse(Console.ReadLine(), out input) && input < j + 1 && input > 0)
                                {
                                    pc.EquipItem(pc.Inventory[input - 1]);
                                    foreach (char letter in $"\nYou have equipped {pc.EquippedItem.Name}.")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }

                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                            case 5: //see stats
                                Console.Clear();
                                foreach (char letter in $"\n{pc.Name}\nHP: {pc.Hp}\nEquipped Item: {pc.EquippedItem.Name}\nCurrency: {pc.Currency} mells\n\nStatus:\n")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                foreach (string status in pc.PlayerStatus)
                                {
                                    foreach (char letter in pc.PlayerStatus[i])
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                        }
                    }
                    else //handles incorrect user input
                    {
                        foreach (char letter in "\n\nYou may input only the number of one of the selections offered.")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        foreach (char letter in "\n\n\n\nPress any key to continue...")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i == 8) //shove carlsin and continue on your way (option 2)
                {
                    i = 10;
                    foreach (char letter in "\n\n\n\nPress any key to continue...")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
                    Console.ReadKey();
                    continue;
                }
                if (i == 10) //Carlsin bites your head off after option 3
                {
                    foreach (char letter in "GAME OVER")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
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
                                    foreach (char letter in $"{j + 1}) {pc.Inventory[j].Name}")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                    Console.Write("\n");
                                }
                                foreach (char letter in "\n\nIf you would like to equip an item, input it's number.\nTo keep your equipped item the same, hit another key.\n")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                if (int.TryParse(Console.ReadLine(), out input) && input < j + 1 && input > 0)
                                {
                                    pc.EquipItem(pc.Inventory[input - 1]);
                                    foreach (char letter in $"\nYou have equipped {pc.EquippedItem.Name}.")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                //decrement i to bring loop back to decision statement
                                i--;
                                continue;
                        }
                    }
                    else //handles incorrect user input
                    {
                        foreach (char letter in "\n\nYou may input only the number of one of the selections offered.")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        foreach (char letter in "\n\n\n\nPress any key to continue...")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
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
                                    foreach (char letter in $"{j + 1}) {pc.Inventory[j].Name}")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                    Console.Write("\n");
                                }
                                foreach (char letter in "\n\nIf you would like to equip an item, input it's number.\nTo keep your equipped item the same, hit another key.\n")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                if (int.TryParse(Console.ReadLine(), out input) && input < j + 1 && input > 0)
                                {
                                    pc.EquipItem(pc.Inventory[input - 1]);
                                    foreach (char letter in $"\nYou have equipped {pc.EquippedItem.Name}.")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                //decrement i to bring loop back to decision statement
                                i--;
                                continue;
                            case 4: //see stats
                                Console.Clear();
                                foreach (char letter in $"\n{pc.Name}\nHP: {pc.Hp}\nEquipped Item: {pc.EquippedItem.Name}\nCurrency: {pc.Currency} mells\n\nStatus:\n")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                foreach (string status in pc.PlayerStatus)
                                {
                                    foreach (char letter in pc.PlayerStatus[i])
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                            case 5: //leave
                                i = 18;
                                continue;
                        }
                    }
                    else //handles incorrect user input
                    {
                        foreach (char letter in "\n\nYou may input only the number of one of the selections offered.")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        foreach (char letter in "\n\n\n\nPress any key to continue...")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
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
                                if (aventus.Buy(pc, aventus.StoreInventory, "Auto Chopper"))
                                {
                                    foreach (char letter in "\nYou have purchased an Auto Chopper.\n")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                else
                                {
                                    foreach (char letter in "Either you have insufficient funds to purchase this item or it is out of stock.")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i = 13;
                                continue;
                            case 2: //buy Jungle Starter Kit
                                if (aventus.Buy(pc, aventus.StoreInventory, "Jungle Starter Kit"))
                                {
                                    foreach (char letter in "\nYou have purchased a Jungle Starter Kit.\n")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                else
                                {
                                    foreach (char letter in "Either you have insufficient funds to purchase this item or it is out of stock.")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i = 13;
                                continue;
                            case 3: //buy Schlemal Doll
                                if (aventus.Buy(pc, aventus.StoreInventory, "Schlemal Doll"))
                                {
                                    foreach (char letter in "\nYou have purchased a Schlemal Doll.\n")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                else
                                {
                                    foreach (char letter in "Either you have insufficient funds to purchase this item or it is out of stock.")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i = 13;
                                continue;
                            case 4: //buy Green Remote
                                if (aventus.Buy(pc, aventus.StoreInventory, "Green Remote"))
                                {
                                    foreach (char letter in "\nYou have purchased a Green Remote.\n")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                else
                                {
                                    foreach (char letter in "Either you have insufficient funds to purchase this item or it is out of stock.")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i = 13;
                                continue;
                            case 5: //leave
                                foreach (char letter in "\nYou decide not to buy for now.")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i = 13;
                                continue;
                        }
                    }
                    else //handles incorrect user input
                    {
                        foreach (char letter in "\n\nYou may input only the number of one of the selections offered.")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        foreach (char letter in "\n\n\n\nPress any key to continue...")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i == 16) //sell menu
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
                                    foreach (char letter in $"{j + 1}) {pc.Inventory[j].Name}: {pc.Inventory[j].Value} mells")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                //based on user selection, sell item from inventory or move on
                                foreach (char letter in "\n\nIf you would like to sell an item, input it's number.\nIf you choose not to sell, press any other key.\n")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                if (int.TryParse(Console.ReadLine(), out input) && input < j + 1 && input > 0)
                                {
                                    string itemSoldName = pc.Inventory[input - 1].Name;
                                    short itemSoldValue = pc.Inventory[input - 1].Value;
                                    if (aventus.Sell(pc, itemSoldName))
                                    {
                                        foreach (char letter in $"You have sold {itemSoldName} for {itemSoldValue} mells.")
                                        {
                                            Console.Write(letter);
                                            Thread.Sleep(10);
                                        }
                                    }
                                    else
                                    {
                                        foreach (char letter in "You may not sell this item.")
                                        {
                                            Console.Write(letter);
                                            Thread.Sleep(10);
                                        }
                                    }
                                    foreach (char letter in "\n\n\n\nPress any key to continue...")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                    Console.ReadKey();
                                    i = 13;
                                    continue;
                                }

                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                            case 2: //leave
                                foreach (char letter in "\nYou decide not to sell for now.")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i = 13;
                                continue;
                        }
                    }
                    else //handles incorrect user input
                    {
                        foreach (char letter in "\n\nYou may input only the number of one of the selections offered.")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        foreach (char letter in "\n\n\n\nPress any key to continue...")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }

                if (i == 18) //attempt to ride schlemal death
                {
                    foreach (char letter in "GAME OVER")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
                    return;
                }

                if (i == 20) //jungle path option
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 5 && input > 0)
                    {
                        switch (input)
                        {
                            case 1: //take right path
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                continue;

                            case 2: //take left path
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i = 22;
                                continue;
                            case 3: //check inventory
                                Console.Clear();
                                int j;
                                for (j = 0; j < pc.Inventory.Count; j++)
                                {
                                    foreach (char letter in $"{j + 1}) {pc.Inventory[j].Name}")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                    Console.Write("\n");
                                }
                                foreach (char letter in "\n\nIf you would like to equip an item, input it's number.\nTo keep your equipped item the same, hit another key.\n")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                if (int.TryParse(Console.ReadLine(), out input) && input < j + 1 && input > 0)
                                {
                                    pc.EquipItem(pc.Inventory[input - 1]);
                                    foreach (char letter in $"\nYou have equipped {pc.EquippedItem.Name}.")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }

                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                            case 4: //check stats
                                Console.Clear();
                                foreach (char letter in $"\n{pc.Name}\nHP: {pc.Hp}\nEquipped Item: {pc.EquippedItem.Name}\nCurrency: {pc.Currency} mells\n\nStatus:\n")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                foreach (string status in pc.PlayerStatus)
                                {
                                    foreach (char letter in pc.PlayerStatus[i])
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                        }
                    }
                    else //handles incorrect user input
                    {
                        foreach (char letter in "\n\nYou may input only the number of one of the selections offered.")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        foreach (char letter in "\n\n\n\nPress any key to continue...")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }

                if (i == 22) //jungle flower death
                {
                    foreach (char letter in "GAME OVER")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
                    return;
                }

                if (i == 25) //manticore decision
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 4 && input > 0)
                    {
                        switch (input)
                        {
                            case 1: //feed manticore
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i = 28;
                                continue;
                            case 2: //kick manticore
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                continue;
                            case 3: //run to ship
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i = 30;
                                continue;
                        }
                    }
                    else //handles incorrect user input
                    {
                        foreach (char letter in "\n\nYou may input only the number of one of the selections offered.")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        foreach (char letter in "\n\n\n\nPress any key to continue...")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }


                if (i == 28)
                {
                    foreach (char letter in "GAME OVER")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
                    return;
                }

                if (i == 30)
                {
                    pc.PlayerStatus.Add("Missing a hand");
                    pc.PlayerStatus.Add("Has manticore cub pet");
                }

                foreach (char letter in "\n\n\n\nPress any key to continue...")
                {
                    Console.Write(letter);
                    Thread.Sleep(10);
                }
                Console.ReadKey();
            }

            //Planet 3 SpotMee
            Planet spotMee = new Planet(Enumerations.PlanetTypes.SpotMee, pc, battleEntity);

            for (int i = 0; i < spotMee.Story.Count; i++)
            {
                Console.Clear();
                foreach (char letter in spotMee.Story[i])
                {
                    Console.Write(letter);
                    Thread.Sleep(10);
                }

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
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                            case 4:
                                Console.Clear();
                                foreach (char letter in $"\n{pc.Name}\nHP: {pc.Hp}\nEquipped Item: {pc.EquippedItem.Name}\nCurrency: {pc.Currency} mells\n\nStatus:\n")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                foreach (string status in pc.PlayerStatus)
                                {
                                    foreach (char letter in pc.PlayerStatus[i])
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                        }
                    }
                    else //handles incorrect user input
                    {
                        foreach (char letter in "\n\nYou may input only the number of one of the selections offered.")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        foreach (char letter in "\n\n\n\nPress any key to continue...")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
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
                                foreach (char letter in "\n\nPlease enter your Arena Name:")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadLine();
                                i = 18;
                                continue;
                            case 2:
                                i = 13;
                                continue;
                            case 3:
                                Console.Clear();
                                foreach (char letter in spotMee.Story[18])
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
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
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                            case 6:
                                Console.Clear();
                                foreach (char letter in $"\n{pc.Name}\nHP: {pc.Hp}\nEquipped Item: {pc.EquippedItem.Name}\nCurrency: {pc.Currency} mells\n\nStatus:\n")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                foreach (string status in pc.PlayerStatus)
                                {
                                    foreach (char letter in pc.PlayerStatus[i])
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                        }
                    }
                    else //handles incorrect user input
                    {
                        foreach (char letter in "\n\nYou may input only the number of one of the selections offered.")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        foreach (char letter in "\n\n\n\nPress any key to continue...")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i == 13)
                {
                    foreach (char letter in "GAME OVER")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
                    return;
                }
                if (i == 17)
                {
                    foreach (char letter in "GAME OVER")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
                    return;
                }
                if (i == 18)
                {
                    i = 33;
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
                                foreach (char letter in spotMee.Story[22])
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                continue;
                            case 2:
                                i = 22;
                                continue;
                            case 3:
                                Console.Clear();
                                foreach (char letter in spotMee.Story[25])
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i = 24;
                                continue;
                            case 4:
                                i = 25;
                                continue;
                        }
                    }
                    else //handles incorrect user input
                    {
                        foreach (char letter in "\n\nYou may input only the number of one of the selections offered.")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        foreach (char letter in "\n\n\n\nPress any key to continue...")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i == 24)
                {
                    foreach (char letter in "GAME OVER")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
                    return;
                }
                if (i == 27)
                {
                    foreach (char letter in "GAME OVER")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
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
                if (i == 30)
                {
                    BattleEntity greatHornedLizard = new BattleEntity();
                    greatHornedLizard = spotMee.BattleEntities.Find(enemy => enemy.Name == "Great Horned Lizard");

                    Console.Clear();
                    foreach (char letter in greatHornedLizard.Intro)
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
                    foreach (char letter in "\n\n\n\nPress any key to continue...")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
                    Console.ReadKey();
                    
                    while (battleEntity.Hp > 0)
                    {

                        Console.Clear();
                        foreach (char letter in $"The {battleEntity.Name} has {battleEntity.Hp}HP left.")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        foreach (char letter in "\n\nWhat do you do? \n\n1.)  Attack with equipped weapon.\n\n2.)  Dodge\n\n3.)  Change weapons \n")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        if (int.TryParse(Console.ReadLine(), out input) && input < 4 && input > 0)
                        {
                            switch (input)
                            {
                                case 1: //Deal damage
                                    battleEntity.Hp -= pc.EquippedItem.Damage;
                                    foreach (char letter in $"You dealt {pc.EquippedItem.Damage} to the {battleEntity.Name}")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                    if(battleEntity.Hp > 0)
                                    {
                                        pc.Hp -= battleEntity.Damage;
                                        foreach (char letter in $"The {battleEntity.Damage} dealt {battleEntity.Damage} to {pc.Name} ")
                                        {
                                            Console.Write(letter);
                                            Thread.Sleep(10);
                                        }
                                    }
                                    foreach (char letter in "\n\n\n\nPress any key to continue...")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                    Console.ReadKey();
                                    if (pc.Hp <= 0)
                                    {
                                        foreach (char letter in "Nice try there guy! \n\nGAME OVER")
                                        {
                                            Console.Write(letter);
                                            Thread.Sleep(10);
                                        }
                                        return;
                                    }
                                    continue;
                                case 2: //Dodge
                                    foreach (char letter in "You dodged the lizard's attack")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                    continue;
                                case 3: //check inventory
                                    Console.Clear();
                                    int j;
                                    for (j = 0; j < pc.Inventory.Count; j++)
                                    {
                                        foreach (char letter in $"{j + 1}) {pc.Inventory[j].Name}")
                                        {
                                            Console.Write(letter);
                                            Thread.Sleep(10);
                                        }
                                        Console.Write("\n");
                                    }
                                    foreach (char letter in "\n\nIf you would like to equip an item, input it's number.\nTo keep your equipped item the same, hit another key.\n")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                    if (int.TryParse(Console.ReadLine(), out input) && input < j + 1 && input > 0)
                                    {
                                        pc.EquipItem(pc.Inventory[input - 1]);
                                        foreach (char letter in $"\nYou have equipped {pc.EquippedItem.Name}.")
                                        {
                                            Console.Write(letter);
                                            Thread.Sleep(10);
                                        }
                                    }

                                    foreach (char letter in "\n\n\n\nPress any key to continue...")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                    Console.ReadKey();
                                    i--;
                                    continue;
                            }
                        }
                    }
                    continue;
                }


                foreach (char letter in "\n\n\n\nPress any key to continue...")
                {
                    Console.Write(letter);
                    Thread.Sleep(10);
                }
                Console.ReadKey();
            }

            //Planet 4 Wombodum
            Planet wombodum = new Planet(Enumerations.PlanetTypes.Wombodum, pc, battleEntity);
            for (int i = 0; i < wombodum.Story.Count; i++)
            {
                Console.Clear();
                foreach (char letter in wombodum.Story[i])
                {
                    Console.Write(letter);
                    Thread.Sleep(10);
                }

                if (i == 2)
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 5 && input > 0)
                    {
                        switch (input)
                        {
                            case 1: //implement shop
                                continue;
                            case 2: //leave tower
                                i = 3;
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
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                            case 4:
                                Console.Clear();
                                foreach (char letter in $"\n{pc.Name}\nHP: {pc.Hp}\nEquipped Item: {pc.EquippedItem.Name}\nCurrency: {pc.Currency} mells\n\nStatus:\n")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                foreach (string status in pc.PlayerStatus)
                                {
                                    foreach (char letter in pc.PlayerStatus[i])
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                        }
                    }
                    else //handles incorrect user input
                    {
                        foreach (char letter in "\n\nYou may input only the number of one of the selections offered.")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        foreach (char letter in "\n\n\n\nPress any key to continue...")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i == 5)
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 6 && input > 0)
                    {
                        switch (input)
                        {
                            case 1: //Run away
                                i = 9;
                                continue;
                            case 2: //Attempt to fight (death)
                                i = 7;
                                continue;
                            case 3: //go on date, earn 2000 mells
                                pc.Currency += 2000;
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
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                            case 5:
                                Console.Clear();
                                foreach (char letter in $"\n{pc.Name}\nHP: {pc.Hp}\nEquipped Item: {pc.EquippedItem.Name}\nCurrency: {pc.Currency} mells\n\nStatus:\n")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                foreach (string status in pc.PlayerStatus)
                                {
                                    foreach (char letter in pc.PlayerStatus[i])
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                        }
                    }
                    else //handles incorrect user input
                    {
                        foreach (char letter in "\n\nYou may input only the number of one of the selections offered.")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        foreach (char letter in "\n\n\n\nPress any key to continue...")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i == 9)
                {
                    foreach (char letter in "GAME OVER")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
                    return;
                }
                if (i == 8)
                {
                    i = 9;
                    continue;
                }
                if (i == 12)
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 5 && input > 0)
                    {
                        switch (input)
                        {
                            case 1: //Main street
                                continue;
                            case 2: //Back Alley(battle)
                                i = 19;
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
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                            case 4:
                                Console.Clear();
                                foreach (char letter in $"\n{pc.Name}\nHP: {pc.Hp}\nEquipped Item: {pc.EquippedItem.Name}\nCurrency: {pc.Currency} mells\n\nStatus:\n")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                foreach (string status in pc.PlayerStatus)
                                {
                                    foreach (char letter in pc.PlayerStatus[i])
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                        }
                    }
                    else //handles incorrect user input
                    {
                        foreach (char letter in "\n\nYou may input only the number of one of the selections offered.")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        foreach (char letter in "\n\n\n\nPress any key to continue...")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i == 15)
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 5 && input > 0)
                    {
                        switch (input)
                        {
                            case 1: //Go with vampire
                                continue;
                            case 2: //Go by yourself
                                Console.Clear();
                                foreach (char letter in wombodum.Story[18])
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i = 20;
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
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                            case 4:
                                Console.Clear();
                                foreach (char letter in $"\n{pc.Name}\nHP: {pc.Hp}\nEquipped Item: {pc.EquippedItem.Name}\nCurrency: {pc.Currency} mells\n\nStatus:\n")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                foreach (string status in pc.PlayerStatus)
                                {
                                    foreach (char letter in pc.PlayerStatus[i])
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                        }
                    }
                    else //handles incorrect user input
                    {
                        foreach (char letter in "\n\nYou may input only the number of one of the selections offered.")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        foreach (char letter in "\n\n\n\nPress any key to continue...")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i == 17)
                {
                    foreach (char letter in "GAME OVER")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
                    return;
                }
                if (i == 22)
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 6 && input > 0)
                    {
                        switch (input)
                        {
                            case 1: //Fight through
                                i = 35;
                                continue;
                            case 2: //Attempt to sneak
                                i = 24;
                                continue;
                            case 3: //Yell (death)
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
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                            case 5:
                                Console.Clear();
                                foreach (char letter in $"\n{pc.Name}\nHP: {pc.Hp}\nEquipped Item: {pc.EquippedItem.Name}\nCurrency: {pc.Currency} mells\n\nStatus:\n")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                foreach (string status in pc.PlayerStatus)
                                {
                                    foreach (char letter in pc.PlayerStatus[i])
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                        }
                    }
                    else //handles incorrect user input
                    {
                        foreach (char letter in "\n\nYou may input only the number of one of the selections offered.")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        foreach (char letter in "\n\n\n\nPress any key to continue...")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i == 24)
                {
                    foreach (char letter in "GAME OVER")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
                    return;
                }
                if (i == 27)
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 7 && input > 0)
                    {
                        switch (input)
                        {
                            case 1: //Give Awesome Cyborg Doll
                                i = 34;
                                continue;
                            case 2: //Metal? (death)
                                continue;
                            case 3: //Awesome? (death)
                                i = 31;
                                continue;
                            case 4: //Fight
                                i = 35;
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
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                            case 6:
                                Console.Clear();
                                foreach (char letter in $"\n{pc.Name}\nHP: {pc.Hp}\nEquipped Item: {pc.EquippedItem.Name}\nCurrency: {pc.Currency} mells\n\nStatus:\n")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                foreach (string status in pc.PlayerStatus)
                                {
                                    foreach (char letter in pc.PlayerStatus[i])
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                        }
                    }
                    else //handles incorrect user input
                    {
                        foreach (char letter in "\n\nYou may input only the number of one of the selections offered.")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        foreach (char letter in "\n\n\n\nPress any key to continue...")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i == 31)
                {
                    foreach (char letter in "GAME OVER")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
                    return;
                }
                if (i == 34)
                {
                    foreach (char letter in "GAME OVER")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
                    return;
                }
                if (i == 35)
                {
                    i = 40;
                    continue;
                }

                foreach (char letter in "\n\n\n\nPress any key to continue...")
                {
                    Console.Write(letter);
                    Thread.Sleep(10);
                }
                Console.ReadKey();
            }

            //Start Planet 5
            Planet krytunga = new Planet(Enumerations.PlanetTypes.Krytunga, pc, battleEntity);

            for (int i = 0; i < krytunga.Story.Count; i++)
            {
                Console.Clear(); //clears console before every iteration
                foreach (char letter in krytunga.Story[i])
                {
                    Console.Write(letter);
                    Thread.Sleep(10);
                }

                if (i == 7) //choose the action for your conversation crystal alien
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 7 && input > 0)
                    {
                        switch (input)
                        {
                            case 1: //shop
                                continue;
                            case 2: //ask what? (death)
                                i = 9;
                                continue;
                            case 3: //punt
                                i = 12;
                                continue;
                            case 4: // Run past
                                i = 14;
                                continue;
                            case 5: //see inventory/equip new item
                                Console.Clear();
                                int j;
                                for (j = 0; j < pc.Inventory.Count; j++)
                                {
                                    foreach (char letter in $"{j + 1}) {pc.Inventory[j].Name}")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                    Console.Write("\n");
                                }
                                foreach (char letter in "\n\nIf you would like to equip an item, input it's number.\nTo keep your equipped item the same, hit another key.\n")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                if (int.TryParse(Console.ReadLine(), out input) && input < j + 1 && input > 0)
                                {
                                    pc.EquipItem(pc.Inventory[input - 1]);
                                    foreach (char letter in $"\nYou have equipped {pc.EquippedItem.Name}.")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }

                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                            case 6: //see stats
                                Console.Clear();
                                foreach (char letter in $"\n{pc.Name}\nHP: {pc.Hp}\nEquipped Item: {pc.EquippedItem.Name}\nCurrency: {pc.Currency} mells\n\nStatus:\n")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                foreach (string status in pc.PlayerStatus)
                                {
                                    foreach (char letter in pc.PlayerStatus[i])
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                        }
                    }
                    else //handles incorrect user input
                    {
                        foreach (char letter in "\n\nYou may input only the number of one of the selections offered.")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        foreach (char letter in "\n\n\n\nPress any key to continue...")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i == 12)
                {
                    foreach (char letter in "GAME OVER")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
                    return;
                }
                if (i == 16) //choose the action for the stairs
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 5 && input > 0)
                    {
                        switch (input)
                        {
                            case 1: //Go up
                                i = 21;
                                continue;
                            case 2: //Go down (death)
                                continue;
                            case 3: //see inventory/equip new item
                                Console.Clear();
                                int j;
                                for (j = 0; j < pc.Inventory.Count; j++)
                                {
                                    foreach (char letter in $"{j + 1}) {pc.Inventory[j].Name}")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                    Console.Write("\n");
                                }
                                foreach (char letter in "\n\nIf you would like to equip an item, input it's number.\nTo keep your equipped item the same, hit another key.\n")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                if (int.TryParse(Console.ReadLine(), out input) && input < j + 1 && input > 0)
                                {
                                    pc.EquipItem(pc.Inventory[input - 1]);
                                    foreach (char letter in $"\nYou have equipped {pc.EquippedItem.Name}.")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }

                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                            case 4: //see stats
                                Console.Clear();
                                foreach (char letter in $"\n{pc.Name}\nHP: {pc.Hp}\nEquipped Item: {pc.EquippedItem.Name}\nCurrency: {pc.Currency} mells\n\nStatus:\n")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                foreach (string status in pc.PlayerStatus)
                                {
                                    foreach (char letter in pc.PlayerStatus[i])
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                        }
                    }
                    else //handles incorrect user input
                    {
                        foreach (char letter in "\n\nYou may input only the number of one of the selections offered.")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        foreach (char letter in "\n\n\n\nPress any key to continue...")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if(i == 21)
                {
                    foreach (char letter in "GAME OVER")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
                    return;
                }
                if (i == 24) //choose the action for your conversation with THE MAN
                {
                    if (int.TryParse(Console.ReadLine(), out input) && input < 6 && input > 0)
                    {
                        switch (input)
                        {
                            case 1: //Fight
                                i = 37;
                                continue;
                            case 2: //Ask about pet
                                i = 30;
                                continue;
                            case 3: //Wait 5 mins
                                continue;
                            case 4: //see inventory/equip new item
                                Console.Clear();
                                int j;
                                for (j = 0; j < pc.Inventory.Count; j++)
                                {
                                    foreach (char letter in $"{j + 1}) {pc.Inventory[j].Name}")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                    Console.Write("\n");
                                }
                                foreach (char letter in "\n\nIf you would like to equip an item, input it's number.\nTo keep your equipped item the same, hit another key.\n")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                if (int.TryParse(Console.ReadLine(), out input) && input < j + 1 && input > 0)
                                {
                                    pc.EquipItem(pc.Inventory[input - 1]);
                                    foreach (char letter in $"\nYou have equipped {pc.EquippedItem.Name}.")
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }

                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                            case 5: //see stats
                                Console.Clear();
                                foreach (char letter in $"\n{pc.Name}\nHP: {pc.Hp}\nEquipped Item: {pc.EquippedItem.Name}\nCurrency: {pc.Currency} mells\n\nStatus:\n")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                foreach (string status in pc.PlayerStatus)
                                {
                                    foreach (char letter in pc.PlayerStatus[i])
                                    {
                                        Console.Write(letter);
                                        Thread.Sleep(10);
                                    }
                                }
                                foreach (char letter in "\n\n\n\nPress any key to continue...")
                                {
                                    Console.Write(letter);
                                    Thread.Sleep(10);
                                }
                                Console.ReadKey();
                                i--;
                                continue;
                        }
                    }
                    else //handles incorrect user input
                    {
                        foreach (char letter in "\n\nYou may input only the number of one of the selections offered.")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        foreach (char letter in "\n\n\n\nPress any key to continue...")
                        {
                            Console.Write(letter);
                            Thread.Sleep(10);
                        }
                        Console.ReadKey();
                        i--;
                        continue;
                    }
                }
                if (i == 30)
                {
                    foreach (char letter in "GAME OVER")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
                    return;
                }
                if (i == 37)
                {
                    foreach (char letter in "Play again?")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
                }
                if (i == 47)
                {
                    foreach (char letter in "Play again?")
                    {
                        Console.Write(letter);
                        Thread.Sleep(10);
                    }
                }

                foreach (char letter in "\n\n\n\nPress any key to continue...")
                {
                    Console.Write(letter);
                    Thread.Sleep(10);
                }
                Console.ReadKey();
            }
        }
    }
}



