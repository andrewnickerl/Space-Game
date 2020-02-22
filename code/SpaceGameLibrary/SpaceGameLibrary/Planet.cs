using System;
using System.Collections.Generic;
using System.Text;
using static SpaceGameLibrary.Enumerations;

namespace SpaceGameLibrary
{
    public class Planet
    {
        public Planet(PlanetTypes planet, Player pc)
        {
            this.Name = planet;
            this.StoreInventory = AssignWeapons();
            this.Story = AssignStory(pc);
        }

        public PlanetTypes Name { get; set; }
        public string Objective { get; set; }
        public List<Item> StoreInventory { get; set; }
        public List<string> Story { get; set; }

        public bool Buy(Player pc, List<Item> storeInventory, string selection)
        {
            switch (selection)
            {
                case "Auto Chopper":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        if (pc.Currency >= storeInventory.Find(item => item.Name == selection).Value)
                        {
                            pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                            pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        }
                        else return false;

                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;
                case "Jungle starter kit":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        if (pc.Currency >= storeInventory.Find(item => item.Name == selection).Value)
                        {
                            pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                            pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        }
                        else return false;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;
                case "Schlemal doll":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        if (pc.Currency >= storeInventory.Find(item => item.Name == selection).Value)
                        {
                            pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                            pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        }
                        else return false;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;

                case "Green remote":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        if (pc.Currency >= storeInventory.Find(item => item.Name == selection).Value)
                        {
                            pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                            pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        }
                        else return false;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;

                case "20 lbs dumbbells":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        if (pc.Currency >= storeInventory.Find(item => item.Name == selection).Value)
                        {
                            pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                            pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        }
                        else return false;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;

                case "45 lbs plate":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        if (pc.Currency >= storeInventory.Find(item => item.Name == selection).Value)
                        {
                            pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                            pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        }
                        else return false;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;

                case "OFF protein":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        if (pc.Currency >= storeInventory.Find(item => item.Name == selection).Value)
                        {
                            pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                            pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        }
                        else return false;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;

                case "Animal energy powder":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        if (pc.Currency >= storeInventory.Find(item => item.Name == selection).Value)
                        {
                            pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                            pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        }
                        else return false;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;

                case "The claw":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        if (pc.Currency >= storeInventory.Find(item => item.Name == selection).Value)
                        {
                            pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                            pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        }
                        else return false;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;

                case "Purple remote":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        if (pc.Currency >= storeInventory.Find(item => item.Name == selection).Value)
                        {
                            pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                            pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        }
                        else return false;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;

                case "Awesome cyborg doll":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        if (pc.Currency >= storeInventory.Find(item => item.Name == selection).Value)
                        {
                            pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                            pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        }
                        else return false;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;

                case "Laser sword":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        if (pc.Currency >= storeInventory.Find(item => item.Name == selection).Value)
                        {
                            pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                            pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        }
                        else return false;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;

                case "Red crystal":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        if (pc.Currency >= storeInventory.Find(item => item.Name == selection).Value)
                        {
                            pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                            pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        }
                        else return false;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;

                case "Blue Crsytal":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        if (pc.Currency >= storeInventory.Find(item => item.Name == selection).Value)
                        {
                            pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                            pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        }
                        else return false;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;

                case "Green crystal":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        if (pc.Currency >= storeInventory.Find(item => item.Name == selection).Value)
                        {
                            pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                            pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        }
                        else return false;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;

                default:
                    return false;
            }
        }

        public bool Sell(Player pc, List<Item> storeInventory, string selection)
        {
            switch (selection)
            {
                case "Auto Chopper":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Jungle starter kit":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Schlemal doll":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Green remote":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "20 lbs dumbbells":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "45 lbs plate":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "OFF protein":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Animal energy powder":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "The claw":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Purple remote":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Awesome cyborg doll":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Laser sword":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Red crystal":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Blue crystal":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Green crystal":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                default:
                    return false;
            }
        }

        public bool Combat(Player pc, BattleEntity enemy, BattleEntity ally)
        {
            throw new System.NotImplementedException();
        }

        public bool Combat(Player pc, BattleEntity enemy)
        {
            do
            {
                enemy.Hp -= pc.EquippedItem.Damage;
                if(enemy.Hp > 0)
                {
                    pc.Hp -= enemy.Damage;
                }
                if(enemy.Hp <= 0)
                {
                    break;
                }
            } while (pc.Hp > 0);
            if(pc.Hp <= 0)
            {
                return false;
            }
            return true;
        }

        public List<Item> AssignWeapons()
        {
            List<Item> inventory = new List<Item>();

            switch (this.Name)
            {
                case PlanetTypes.Aventus:
                    Item item1 = new Item();
                    item1.Name = "Auto Chopper";
                    item1.Quantity = 1;
                    item1.Value = 150;
                    inventory.Add(item1);
                    Item item2 = new Item();
                    item2.Name = "Jungle starter kit";
                    item2.Quantity = 1;
                    item2.Value = 300;
                    inventory.Add(item2);
                    Item item3 = new Item();
                    item3.Name = "Schlemal doll";
                    item3.Quantity = 1;
                    item3.Value = 50;
                    inventory.Add(item3);
                    Item item4 = new Item();
                    item4.Name = "Green remote";
                    item4.Quantity = 1;
                    item4.Value = 200;
                    inventory.Add(item4);
                    return inventory;
                case PlanetTypes.SpotMee:
                    Item item6 = new Item();
                    item6.Name = "20 lbs Dumbbells";
                    item6.Quantity = 1;
                    item6.Value = 250;
                    inventory.Add(item6);
                    Item item7 = new Item();
                    item7.Name = "45 lbs plate";
                    item7.Quantity = 1;
                    item7.Value = 50;
                    inventory.Add(item7);
                    Item item8 = new Item();
                    item8.Name = "OFF protein";
                    item8.Quantity = 1;
                    item8.Value = 400;
                    inventory.Add(item8);
                    Item item9 = new Item();
                    item9.Name = "Animal energy powder";
                    item9.Quantity = 1;
                    item9.Value = 150;
                    inventory.Add(item9);
                    return inventory;
                case PlanetTypes.Wombodum:
                    Item item10 = new Item();
                    item10.Name = "The Claw";
                    item10.Quantity = 1;
                    item10.Value = 600;
                    inventory.Add(item10);
                    Item item11 = new Item();
                    item11.Name = "Purple remote";
                    item11.Quantity = 1;
                    item11.Value = 200;
                    inventory.Add(item11);
                    Item item13 = new Item();
                    item13.Name = "Awesome cyborg doll";
                    item13.Quantity = 1;
                    item13.Value = 350;
                    inventory.Add(item13);
                    Item item14 = new Item();
                    item14.Name = "laser sword";
                    item14.Quantity = 1;
                    item14.Value = 400;
                    inventory.Add(item14);
                    return inventory;
                case PlanetTypes.Krytunga:
                    Item item15 = new Item();
                    item15.Name = "Red crystal";
                    item15.Quantity = 1;
                    item15.Value = 200;
                    inventory.Add(item15);
                    Item item16 = new Item();
                    item16.Name = "Blue crystal";
                    item16.Quantity = 1;
                    item16.Value = 200;
                    inventory.Add(item16);
                    Item item17 = new Item();
                    item17.Name = "Green crystal";
                    item17.Quantity = 1;
                    item17.Value = 200;
                    inventory.Add(item17);
                    return inventory;
                default:
                    return inventory;
            }
        }
        public List<string> AssignStory(Player pc)
        {
            List<string> story = new List<string>();
            switch (this.Name)
            {
                case PlanetTypes.Noir:

                        /*1*/story.Add("(Narrator)\nOn a Cold desolate night on Planet Noir,our hero comes to, unaware of the adventure that awaits....");
                        /*2*/story.Add($"(Narrator)\nSlowly your eyes open,the emergency beacon on your ship is beaming, how you didn't hear it sooner is a mystery but your ship's security system is blaring a name... {pc.Name.ToUpper()}!!!!");
                        /*3*/story.Add($"(Ship Security system)\nGreetings {pc.Name}..... unknown perpetrator onboard during personnel stasis. current lifeforms present...one...");
                        /*4*/story.Add($"({pc.Name} inner dialogue)\n one??? Could there be someone on here that is missing, you stand up to look around for clues");
                        /*5*/story.Add("Perplexed by mystery, you're faced with a dilemma."); // start of Scenario switch statement for Planet Noir choices
                        /*6*/ story.Add("1) Ask security protocols who was on the ship\n\n2) follow footprints leading outside the ship\n\n3) Grab an Astrocola and watch cartoons\n\n4) Tell the ship security protocols to initiate defense level BAMBAM\n\n What do you do?");
                        /*7*/story.Add($"(Ship security protocol)\nKnown fugitive known as THE MAN entered and left with {pc.PetName}"); // Scenario 1
                        /*8*/story.Add($"You remember now, your dog {pc.PetName} is gone!!!THE MAN must pay!!!!");
                        /*9*/story.Add("You grab the nearest item to you and man your ship speeding off towards the next planet to find him"); // item if statement start
                        /*10*/story.Add("A) The Blitz Blade\nB) The Shield O Saturn\nC) The Plutonian Plasma Rifle\n Which item will you grab?"); // Add the blitz blade item // Add the shield o saturn item// Add the plasma rifle item
                        /*11*/story.Add("Angry and disoriented, you run to the ship door slamming on the hatch button, suddenly your sucked out into orbit");  // Scenario 2
                        /*12*/story.Add("Due to you being on another planet without an atmosphere, the oxygen is sucked out of you like Douglas Quaid in that movie TOTAL RECALL.");
                        /*13*/story.Add("Nice job there guy!");
                        /*14*/story.Add("Leisurely you motion towards the fridge to grab a ice cold Astrocola and notice the key behind it."); // Scenario 3 ADD the DAVE
                       /*15*/story.Add("What a dumb place to hide my Deatomizing Assault Vulcan Emitter cannon aka The D.A.V.E,after collecting your weapon you remember your objective and set off to find THE MAN on the next planet");
                       /*16*/story.Add("Paranoid that THE MAN is still onboard your ship you scream to the ship security system to go level BAMBAM!!");  // Scenario 4
                        /*17*/story.Add("In an instant you proceed to get turned into swiss cheese by the turrets on the ship. THE MAN tricked you and sabotaged the weapon system. Nice job there guy!");

                    // End of Noir
                    return story;

                case PlanetTypes.Aventus:
                    /*1*/story.Add($"{pc.Name} lands on Aventus after the ship scanners showed THE MAN’s ship landing here. Uncertain what he landed here but we shall find out.");
                    /*1*/story.Add("Last known location shows him disappearing just past the only spaceport on the planet, Artelius. After dodging the freight ships, you land on platform 934 after getting clearance from the port officials. ");
                    /*1*/story.Add("You see what looks like an ostrich in a tuxedo walking towards you. In a shrill voice the call out to you.");
                    /*1*/story.Add("(Carlsin):\nGreetings traveler, I am Carlsin, a dock supervisor here at Aventus. who are you and what is your reason for being here?"); // start options switch statement
                    /*1*/story.Add("1.)Give what Carlsen asked.\n\n2.) Refuse to answer and shove past.\n\n3.) Ask if he is an ostrich.\n\n4.) See inventory\n\n5.) See Stats\n\n What will you do?");
                    /*1*/story.Add($"You say that you’re {pc.Name} and are looking for a human called THE MAN."); // Scenario 1
                    /*1*/story.Add("(Carlsin)\n “I don’t know who this man is but we did have a ship illegally land at lumber yard 67. I wouldn’t suggest going there since going there by yourself though.");
                    /*1*/story.Add("The site was recently taken over by a young manticore. I’d stop by Frig&Horges in the marketplace if you plan to still go there. They have all the gear you might need to brave the jungle.");
                    /*1*/story.Add("You shove Carlsin causing him to fall off the landing platform. He becomes a new hood ornament for a freight ship leaving planet. You wander into town looking for information."); // Scenario 2
                    /*1*/story.Add("You ask him and immediately see him start to tremble. He screeches as he charges towards you. Before you can react, his beak opens wider than you think possible and bites your head off."); // Scenario 3
                    /*1*/story.Add("Game Over!");
                    /*1*/story.Add("You come to a crossroad with a sign pointing to several different places."); // Crossroads switch statement
                    /*1*/story.Add("1.) Go to marketplace\n\n2.) Go to jungle\n\n3.) Attempt to ride one of the local Schlemals(Carlsin’s race)\n\n4.) See inventory.");
                    /*1*/story.Add("You go to the marketplace and see a store called Frig&Horge.You enter and ask the clerk if you can sell things here. They say yes.");
                    /*1*/story.Add("1.)	Buy items\n\n2.) Sell items\n\n3.) Leave\n\nWhat would you like to do?"); // Market options
                    /*1*/story.Add("1.)	Auto Chopper____Price 150 Mells\n\n2.)	Jungle Starter Kit_____Price 300 Mells\n\n3.)	Schlemal Doll______Price 50 Mells\n\n4.)	Green Remote_____Price 200 Mells\n\n5.)	Leave\n\nWhat will you do."); // Sub-options 2
                    /*1*/story.Add("1.)	Show PC inventory with prices\n\n2. Leave\n\nWhat will you do."); // Sub-Option 3
                    /*1*/story.Add("You sneak up on a Schlemal and right as it notices you, you leap onto its back. It leaps into the air and dunks the both of you into a tree compressor. You become an ambassador’s new table.");
                    /*1*/story.Add("Nice job there Guy!");
                    /*1*/story.Add("You head into the jungle in hopes of finding THE MAN or pet. After trudging through the jungle, the path splits into 2.");
                    /*1*/story.Add("1.)	Take the right path\n\n2.)	Take the left path\n\n3.)	Check inventory\n\n4.)	Check stats.\n\nWhat will you do?");
                    /*1*/story.Add("As you continue down the right path, you smell something sweet from a large flower. As you stop to smell the flower, it lunges out and eats the top half of you."); // Option 1
                    /*1*/story.Add("Game Over.nice job there guy!");
                    /*1*/story.Add("You come upon lumber yard 67. As you arrive, you see a ship that you don’t recognize fly away. It is much sleeker then the local freight ships.THE MAN has got away!!"); // Option 2
                    /*1*/story.Add("You then hear a mewl from the yard. A kitten with red fur, a small horn, and bat wings trots over to you carrying a star-map data stick.");
                    /*1*/story.Add("1.) feed the manticore\n\n2.) kick the cat thing.\n\n3.) Run back to ship.\n\nWhat will you do?");
                    /*1*/story.Add("You kick the cat with wings causing it to drop the star-map data stick. As you bend over to pick it up you hear another mewl."); //  Option 2
                    /*1*/story.Add("Right as your hand touches the data stick, you get engulfed in flames. All that is left is ashes.");
                    /*1*/story.Add("Game Over. Nice job there guy!");
                    /*1*/story.Add("You give the manticore cub some of your food. It greedily devours the food and your hand. It starts to purr and won’t leave you alone."); // Option 1
                    /*1*/story.Add("You lost a hand but gained a manticore companion.With the data chip and your new companion, you rush back to your ship and chase after THE MAN.");
                    /*1*/story.Add("You rush back through the jungle in hope that you can get to the ship in time. As you arrive, you power it on and check to see if there are any traces of the ship that just left.");
                    /*1*/story.Add("You’re in luck! You take off from the landing pad, sending several Schlemals to their death and chase after THE MAN.");
                    // End of Aventus
                    return story;

                case PlanetTypes.SpotMee:
                    /*1*/story.Add("You are at planet SpotMee and land in the capital city, Brotopia. THE MAN is definitely here, but the city is large and filled with gladiator rings.");
                    /*1*/story.Add("As you start to walk towards the city, an AD bot starts screaming its ad in your face.");
                    /*1*/story.Add("(ad bot)\n Come on down!come on down! Come one, come all to the Guilds Gym Arena! Legendary boss, THE MAN!, challenges all to come fight to take his fortune! Can any claim his Mells?!?!?!” ");
                    /*1*/story.Add("1.) Go to the Marketplace.\n\n2.) Go to Guilds Gym Arena.\n\n3.)	Check inventory.\n\n4.)	Check stats.\n\nWhat do you do?");
                    /*1*/story.Add("As you wander down the marketplace, you see a store called, DO YOU EVEN LIFT. You decide to shop there."); // Option 1
                    /*1*/story.Add("1.) Buy.\n\n2.) Sell.\n\n3.)	Leave.\n\nWhat will you do?");
                    /*1*/story.Add("1.) 20lbs Dumbbell/ qty: 20 price: 250 mells\n\n2.) 45lbs Plate/ qty: 3 price: 50 mells3.) OFFs Protein/ price: 400 mells\n\n4.)	Animal Energy Powder/ price: 150 mells\n\n5.) Leave.\n\nWhat will you do?"); //"Shop Items to buy
                    /*1*/story.Add("You run off towards Guilds Gym Arena, the AD bot blaring the same ad the whole way. When you arrive to the arena you see a line with various aliens hoping to win THE MAN’s fortune."); // Option 2
                    /*1*/story.Add("When you finally get to the front you recognize an Orgus by its big green pig head with tusk shooting out. He has a name tag that reads Daisy.");
                    /*1*/story.Add("(Daisy)\nin a deep gruff voice he asks,“Arena name and race?”");
                    /*1*/story.Add("1.) Give new name for arena fights.\n\n2.) Give your name for arena fights.\n\n3.) Ask Daisy about name.\n\n4.) Mock Daisy for name.\n\nWhat will you do?"); // Options
                    /*1*/story.Add("You laugh at Daisy for being named after a weak Earth flower. Daisy roars over being mocked, “Daisy is greatest warrior name from Orgus home world!!! Puny human shall die!”"); // Option 4
                    /*1*/story.Add("He slams his hand down on a button on his desk causing the floor below you to disappear. You fall into a pit of boiling oil becoming Daisy’s snack for the arena matches later.");
                    /*1*/story.Add("Game Over.Nice job there guy!");
                    /*1*/story.Add("You give Daisy your name and he explains that you must win the 3 rounds in order to win THE MAN’s tournament. As you enter the arena for the first round a voice over the louder speakers come on."); // Option 2
                    /*1*/story.Add($"“Cooooontestants!!! There has been a change for the first round! Instead of the traditional Brotopia dumbbell fight, whoever kills {pc.Name},the only human here, will win the tournament!!!” ");
                    /*1*/story.Add("All the contestants turn toward you and before anyone else can jump you, an Orgus jumps from the stands and turns you into a pancake.");
                    /*1*/story.Add("Game Over.Nice job there guy!");
                    /*1*/story.Add("Daisy tells you he was named after the greatest warrior in Orgus history. You marvel in wonder at the name. Daisy says he likes you and says if you enter the red door over there, you can skip to the final round."); // Option 3
                    /*1*/story.Add("Welcome contestants!! The first round shall be the traditional Dumbbell fight! Ready, Go!");
                    /*1*/story.Add("You look around and see everyone pulling out dumbbells and throwing them like snowballs.");
                    /*1*/story.Add("1.) Access Inventory.\n\n2.)	Dodge and hope to pick up stray dumbbells.\n\n3.) Cower in a corner.\n\n4.)	Run around the arena screaming.\n\nWhat will you do?"); // Options //[Everything but dumbbells fails and sends back to original options]
                    /*1*/story.Add("“You survived the round and moved on.”"); // If dumbbells used.
                    /*1*/story.Add("You attempt to dodge the incoming dumbbells but get hit in the head crushing it.");
                    /*1*/story.Add("Game Over.Nice job there guy!");
                    /*1*/story.Add("You run to the corner of the circular arena and cower in the fetal position. After 10 mins of fight, you hear victory! You’re on of the 5 finalists. Move on to round 2"); // Option 3
                    /*1*/story.Add("You start screaming as you run around. You forget to breath properly and pass out after 10 mins. You awake with round 2 under way but a giant horned lizard having eaten your legs."); // Option 4
                    /*1*/story.Add("Game over.A little low on that food chain now my guy!");
                    /*1*/story.Add("(Announcer)\n “Champions moving on to round 2! You shall face one of our beasts we have in our arena. When called, come face your beast!”"); // Round 2
                    /*1*/story.Add("The first 2 contestants both quickly get eaten, making you nervous.");
                    /*1*/story.Add("(Announcer) \n THE MAN shall greet the champion!"); // Fight {random Enemy} Win move on , lose Game Over // Round 3:
                    /*1*/story.Add("THE MAN walks out to greet you but freezes when he sees you. He screams for them to release another beast as he runs away.");
                    /*1*/story.Add("You chase after THE MAN barely making it to your ship before you see his ship leave atmosphere. You follow after him in the ship."); // Fight [Random Enemy] [Win move on, lose Game over]
                    // End of SpotMee
                    return story;

                case PlanetTypes.Wombodum:
                    /*1*/story.Add("You chase THE MAN to Wumbodom. The whole planet is one giant city and THE MAN went straight to land in the slums of the planet");
                    /*1*/story.Add("With your larger ship, you can’t fit in where he landed, so you land on the roof of one of the outlying towers. As you climb down the building, you see a store called Wumbohex. ");
                    /*1*/story.Add("1.) Shop\n\n2.) Leave the tower.\n\n3.) Check Inventory.\n\n4.) Check Stats\n\nWhat will you do?"); // Options
                    /*1*/story.Add("1.) The Claw/ price: 600 mells.\n\n2.) Purple Remote/ price: 200 mells.\n\n3.) Awesome Cyborg Doll/ price: 350 mells.\n\n4.)	Laser Sword/ price: 400 mells.\n\n5.) Leave.\n\nWhat will you do?"); // Shop buy options
                    /*1*/story.Add("You race down the rest of the tower and as you exit you bump into a cyborg Ephantus, an Elephant man race. He turns and stares at you with his red robotic eye.");
                    /*1*/story.Add("1.) Apologize and run away.\n\n2.) Attempt to fight.\n\n3.) Ask if they wanna go.\n\nWhat do you do?"); // Options
                    /*1*/story.Add("You ask the Ephantus and found it he is a she. She says she is Klarice and was surprise her hired date was a human."); // Option 3:
                    /*1*/story.Add("She takes you to the closest mall and dragging you from one store to the next all day long. You awake the next morning tired and sore but 2000 mells richer. "); // . [Go to option 1]
                    /*1*/story.Add("As you reach for a weapon his mechanical nose shoots into your chest and rips your heart out. He screams “KALIMA!” as you die."); // Option 2:
                    /*1*/story.Add("Game Over.Nice job there guy!");
                    /*1*/story.Add("You run away from the Cyborg Ephantus in terror, hoping to never see them again. You rush into the slums knowing your so close to pet"); // Option 1
                    /*1*/story.Add("As you head towards where THE MAN lands you see the busy main street full of beggars or a back alley that appears to bypass all of it.");
                    /*1*/story.Add("1.) Take the main street.\n\n2.) Take the alley.\n\nWhat do you Do?");
                    /*1*/story.Add("You attempt to trudge past all the beggars without responding to them. A small female blue skinned humanoid with 2 small horns on her forehead and black bat wings on her back in a long brown shirt climbs onto your shoulder. "); // Option 1
                    /*1*/story.Add("You recognize she is of the Lashtist race. She says mister “Where are you going? If I guide you there will you give me some food?” ");
                    /*1*/story.Add("1.)	Say yes.\n\n2.)	Tell her to scram.\n\nWhat will you do?");
                    /*1*/story.Add("She guides you to THE MAN’s ship, but you forgot Lashtist feed off the blood of other. She starts drinking your blood as you see THE MAN fly away."); // Option 1
                    /*1*/story.Add("Game Over.Nice job there Guy!");
                    /*1*/story.Add("She flutters away sobbing about being hungry. Then you notice her start drinking the blood of another beggar in an alley. He becomes a mummy is 30 seconds. You just dodged a bullet."); // Continue where option 2 joins back in]
                    /*1*/story.Add("As you begin walking through the alley, a small green humanoid with large pointy ears clutching what appears to be a butter knife runs into you. You recognize him as a Gobleen. "); // // Option 2
                    /*1*/story.Add("He is short of breath as if he was running from something. He realizes you’re not a wall but a person and freaks out. He screams, “You will not take my precious!!” as he strokes his butter knife. "); // Fight
                    /*1*/story.Add("As you leave beggar central you see THE MAN’s ship, but there is a massive gang war on the path to the ship"); // [Win, gain Holy Butter Knife and join back with option 1] ,[Lose, Game over.]
                    /*1*/story.Add("1.) Fight your way through.\n\n2.) Attempt to sneak around.\n\n3.) Yell dumbbell fight!\n\nWhat do you Do?"); // Options:
                    /*1*/story.Add("You yell out and both gangs turn to you. You hear someone says, “wrong planet!” as a pizza flies toward you.  Its aroma attracts the local Flesh fleas. You are eaten alive by the fleas. "); // Option 3:
                    /*1*/story.Add("Game Over.Nice job there guy!");
                    /*1*/story.Add("As you attempt to sneak past the war grounds, a humanoid cyborg with no details to see his original race but a large ‘A’ on his chest confronts you. "); // Option 2:
                    /*1*/story.Add("(Cyborg) \n “To whose allegiance do you claim?! Awesome or Metal?!” ");
                    /*1*/story.Add("1.) Give item from inventory.\n\n2.)	Answer with “Metal?”\n\n3.)	Answer with Awesome?\n\n4.)	[Fight]\n\nWhat do you Do?");  // Option 4: Go to option 1, fight through.
                    /*1*/story.Add("(Cyborg) \n “You dare say Metal Man is better?!?! To me, an Awesome Cyborg fan?!?!?! Be converted!!” "); //Option 2:
                    /*1*/story.Add("He throws a helmet on you which forces you to watch ‘The Adventures of Awesome Cyborg’ on repeat for 3 weeks straight.");
                    /*1*/story.Add("Awesome Cyborg is love; Awesome Cyborg is life. You join the gang with no self-will attempting to convert others to your cause.");
                    /*1*/story.Add("Game Over.Way to follow the sheep there guy!");
                    /*1*/story.Add("(Cyborg) \n“I see through you lies Metal Man spy!! There is no saving your kind!”"); // Option 3:
                    /*1*/story.Add("He pulls out an anti-battleship cannon and vaporizes you.You are wiped from existence.");
                    /*1*/story.Add("Game Over.Battleship's not your game there guy!");
                    /*1*/story.Add("(Cyborg) \n “You would give me this rare figurine of Awesome Cyborg?! There are only 10 in existence! I will cherish what you have given me! May you bring justice to the blind comrade!”"); //Option 1: // [If you give Awesome Cyborg Doll]
                    /*1*/story.Add(""); // [Continue on to THE MAN’s ship]
                    /*1*/story.Add("[Fight Random Enemy]"); // Option 1:
                    /*1*/story.Add(""); // Win: [Fight Random Enemy]
                    /*1*/story.Add(""); // Lose: Game Over.
                    /*1*/story.Add(""); // Win Both: Continue on to THE MANS ship
                    /*1*/story.Add("After scrapping through the warzone, you finally make it to THE MAN’s ship. Sadly, right as you approach the ship, the entry ramp raises up and the ship begins to leave. Over a speaker from the ship you hear THE MAN call out. ");
                    /*1*/story.Add($"(THE MAN)\n “Muahahahaha!{pc.Name} you’re too slow. I’ve got everything I need to feats with {pc.PetName}. If you want to join us on Krytunga then be my guest!” He then speeds of into space");
                    /*1*/story.Add("You know where this ends. Time to get pet back. You head back to your ship, setting coordinates for the planet of Krytunga, the crystal world.");
                    // End of Wombodum
                    return story;

                case PlanetTypes.Krytunga:
                     /*1*/story.Add("Krytunga, the crystal planet");
                     /*1*/story.Add("Finally, you land on the remote planet of Krytunga. This planet is said to be uninhabitable due only the planet’s unique crystals that grow here. ");
                     /*1*/story.Add("As you circle the planet you notice what appears to be a fortress made from crystal. You notice that THE MAN’s ship is landed in the courtyard.");
                     /*1*/story.Add($"({pc.Name}) \n “Found you, you ugly bastard!” you growl to yourself. ");
                     /*1*/story.Add("You land just outside the fortress and get ready to face the music, you mean THE MAN. As you leave your ship, a crystal alien you’ve never heard or seen of before approaches you");
                     /*1*/story.Add("He looks like a 3-foot humanoid with crystal skin. As he draws near, he begins to speak.");
                     /*1*/story.Add("(Crystal Alien) \n “Yo homedog! Care to swap some sparkle spazzles?”");
                     /*1*/story.Add("1.) Say I guess?\n\n2.) Say “Some what?!?\n\n 3.) Punt the crystal dwarf thing.\n\n4.) Ignore and rush into the fortress.\n\n What do you do?"); // Options
                     /*1*/story.Add("(Crystal Alien) \n “Cool! Here’s what I got flesh man!”"); // Option 1:
                     /*1*/story.Add("1.) Red Crystal/ price: 200 mells.\n\n2.) Blue Crystal/ price: 200 mells.\n\n3.)	Green Crystal/ price: 200 mells\n\n4.) Leave.\n\nWhat will you do?"); // Items Sold:[Go into Buy/Sell mode]
                     /*1*/story.Add("The crystal alien launches into the history of the planet and the local lingo. You attempt to leave several times, but he cuts you off every time."); // Option 2:
                     /*1*/story.Add("He leaves no room to interrupt during his entire 8-year long lecture. Given no room to ever leave, you die from starvation 1 month into the lecture.");
                     /*1*/story.Add("Game Over.Should've brought a snack pak there guy!");
                     /*1*/story.Add("As your leg makes contact with the alien, it starts to move through him like swimming through honey. Before you can realize it, the alien has become your leg from the knee down"); // Option 3:
                     /*1*/story.Add("His face disappears but now hear his voice in your head. Your otherwise fine and charge into the fortress mildly off balance."); // [Pick up with option 4]
                     /*1*/story.Add("You charge into the fortress expecting to face THE MAN’s henchmen but find it empty. You rush through the halls until you come to a grand staircase going up to one massive door and another going down to an identical looking door."); // Option 4:
                     /*1*/story.Add("1.) Go up the stairs.\n\n2.)	Go down the stairs.\n\nWhat do you Do?");
                     /*1*/story.Add("As you climb down the stairs you take a deep breath before you fling the doors open. Astonished, you find not a throne room but what appears to be some sort of factory"); // Option 2:
                     /*1*/story.Add("You wander to the edge of the observation platform to get a better look.");
                     /*1*/story.Add("As you stare out across the factory, it quickly becomes clear that this is where THE MAN creates the crystal aliens like the one that greeted you when you landed. As this dawns on you, you feel someone kick you from behind.");
                     /*1*/story.Add("You fall over the railing into a vat of molten crystal in front of you. You’re able to turn your head before you fall in and see THE MAN cackling as he watches you die in the molten crystal.");
                     /*1*/story.Add("Game Over.nice job there guy!");
                     /*1*/story.Add("As you climb up the stairs you take a deep breath before you fling the doors open. You see THE MAN on a throne of crystal smiling down at you. "); // Option 1:
                     /*1*/story.Add($"(THE MAN)\n “Welcome {pc.Name}! I’ve been waiting for you. Can’t hold the grand party without you. Give me 5 more minutes and it will all be ready.”");
                     /*1*/story.Add("1.) Don’t wait and attack.\n\n2.) Demand he give {pc.PetName} back.\n\n3.) Wait the 5 minutes.\n\nWhat do you do?"); // Options
                     /*1*/story.Add("You decide to wait to see what happens. More crystal aliens, similar to the one the greeted you start to bring in what appear to be party decorations"); // Option 3
                     /*1*/story.Add("A table and chair are brought out for you to sit with a massive 7-layer cake is placed in front of you");
                     /*1*/story.Add("The aliens start sing happy birthday to you, and THE MAN tells you to blow out the candles. You indulge them and blow out the candles");
                     /*1*/story.Add("BOOOOOOOMMMM!!!!");
                     /*1*/story.Add("The cake explodes the second you blow the candles out. You should have never trusted THE MAN, even if it was your birthday.");
                     /*1*/story.Add("Game Over.How'd that wish turn out there guy?!");
                     /*1*/story.Add($"THE MAN stares a you confused. He goes on to tell you he never took {pc.PetName}; he just hid him in your ship’s exterior storage compartment."); // Option 2:
                     /*1*/story.Add("He goes on to say your birthday party will soon be ready and should stick around for it.");
                     /*1*/story.Add($"Bewildered, you race out to your ship and check the exterior storage.Sure enough, the second you open it,{pc.PetName}leaps onto you and starts licking your face.");
                     /*1*/story.Add("Overjoyed, the 2 of you go back onto your ship to float through the galaxy watching cartoons together. You don’t trust THE MAN with throwing any parties and just leave the planet.");
                     /*1*/story.Add("As you start to leave atmosphere, you see THE MAN’s fortress explode. Glad to have trusted your gut, you and pet fly off on new adventures.");
                     /*1*/story.Add($"Victory,{pc.Name} has got {pc.PetName} back!");
                     /*1*/story.Add("!!!Thanks for playing!!!"); // Game Done
                     /*1*/story.Add("Shocked by your sudden attack, THE MAN throws out a yellow crystal that turns into 2-foot yellow crystal mouse."); // Option 1:
                     /*1*/story.Add(""); // [Fight Mouse]
                     /*1*/story.Add(""); // Win:
                     /*1*/story.Add("(THE MAN) \n “Cursed knock-offs! I’ll just deal with you myself!”");
                     /*1*/story.Add(""); // [Fight THE MAN]
                     /*1*/story.Add(""); // Win:
                     /*1*/story.Add($"After obliterating THE MAN, you run past the throne into what you assume was THE MAN’s room. There in a cage is {pc.PetName}.");
                     /*1*/story.Add($"You quickly bust the lock and {pc.PetName} flies into your arms, licking your face. Finally, you and {pc.PetName} can get back to your primary mission, watching all the galaxy’s cartoons ever created!");
                     /*1*/story.Add($"Victory,{pc.Name} has got {pc.PetName} back!");
                     /*1*/story.Add("Thanks for playing!"); // Game Done
                    //End of Krytunga
                    return story;

                default:
                    return Story;
            }
        }
    }
}