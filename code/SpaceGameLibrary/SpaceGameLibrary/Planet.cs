using System;
using System.Collections.Generic;
using System.Text;
using static SpaceGameLibrary.Enumerations;

namespace SpaceGameLibrary
{
    public class Planet
    {
        public Planet(PlanetTypes planet)
        {
            this.Name = planet;
            this.StoreInventory = new List<Item>();
            AssignWeapons();
        }

        public PlanetTypes Name { get; set; }
        public string Objective { get; set; }
        public List<Item> StoreInventory { get; set; }
        public list <string>[] Story { get; set; }

        public bool Buy(Player pc, List<Item> storeInventory, string selection)
        {
            switch(selection)
            {
                case "Auto Chopper":
                    if(storeInventory.Exists(item => item.Name == selection))
                    {
                        if (pc.Currency >= storeInventory.Find(item => item.Name == selection).Value)
                        {
                            pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                            pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        } else return false;

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
                        } else return false;
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
            throw new System.NotImplementedException();
        }

        private bool AssignWeapons()
        {
            switch (this.Name)
            {
                case PlanetTypes.Aventus:
                    Item item1 = new Item();
                    item1.Name = "Auto Chopper";
                    item1.Quantity = 1;
                    item1.Value = 150;
                    this.StoreInventory.Add(item1);
                    Item item2 = new Item();
                    item2.Name = "Jungle starter kit";
                    item2.Quantity = 1;
                    item2.Value = 300;
                    this.StoreInventory.Add(item2);
                    Item item3 = new Item();
                    item3.Name = "Schlemal doll";
                    item3.Quantity = 1;
                    item3.Value = 50;
                    this.StoreInventory.Add(item3);
                    Item item4 = new Item();
                    item4.Name = "Green remote";
                    item4.Quantity = 1;
                    item4.Value = 200;
                    this.StoreInventory.Add(item4);
                    return true;
                case PlanetTypes.SpotMee:
                    Item item6 = new Item();
                    item6.Name = "20 lbs Dumbbells";
                    item6.Quantity = 1;
                    item6.Value = 250;
                    this.StoreInventory.Add(item6);
                    Item item7 = new Item();
                    item7.Name = "45 lbs plate";
                    item7.Quantity = 1;
                    item7.Value = 50;
                    this.StoreInventory.Add(item7);
                    Item item8 = new Item();
                    item8.Name = "OFF protein";
                    item8.Quantity = 1;
                    item8.Value = 400;
                    this.StoreInventory.Add(item8);
                    Item item9 = new Item();
                    item9.Name = "Animal energy powder";
                    item9.Quantity = 1;
                    item9.Value = 150;
                    this.StoreInventory.Add(item9);
                    return true;
                case PlanetTypes.Wombodum:
                    Item item10 = new Item();
                    item10.Name = "Thew Claw";
                    item10.Quantity = 1;
                    item10.Value = 600;
                    this.StoreInventory.Add(item10);
                    Item item11 = new Item();
                    item11.Name = "Purple remote";
                    item11.Quantity = 1;
                    item11.Value = 200;
                    this.StoreInventory.Add(item11);
                    Item item13 = new Item();
                    item13.Name = "Awesome cyborg doll";
                    item13.Quantity = 1;
                    item13.Value = 350;
                    this.StoreInventory.Add(item13);
                    Item item14 = new Item();
                    item14.Name = "laser sword";
                    item14.Quantity = 1;
                    item14.Value = 400;
                    this.StoreInventory.Add(item14);
                    return true;
                case PlanetTypes.Krytunga:
                    Item item15 = new Item();
                    item15.Name = "Red crystal";
                    item15.Quantity = 1;
                    item15.Value = 200;
                    this.StoreInventory.Add(item15);
                    Item item16 = new Item();
                    item16.Name = "Blue crystal";
                    item16.Quantity = 1;
                    item16.Value = 200;
                    this.StoreInventory.Add(item16);
                    Item item17 = new Item();
                    item17.Name = "Green crystal";
                    item17.Quantity = 1;
                    item17.Value = 200;
                    this.StoreInventory.Add(item17);
                    return true;
                default:  //used for testing to let us know if method didn't work as intended
                    return false;
            }
        }
        private bool AssignStory(Player pc, Player dog)
        {
            switch (this.Name)
            {
                case PlanetTypes.Noir:
                    this.Story.Add("(Narrator) \n On a Cold desolate night on Planet Noir our hero comes to, unaware of the adventure that awaits");
                    this.Story.Add($"(SNarrator) \n slowly your eyes open, the emergency beacon on your ship is beaming, how you didn't hear it sooner is a mystery but your ship's security system is blaring a name... {pc.Name}");
                    this.Story.Add($"(Ship Security system) \n Greetings {pc.Name}, \n unknown perpetrator onboard during personnel stasis. current lifeforms present one...");
                    this.Story.Add($"({pc.Name} inner dialogue) \n one? could there be someone on here that is missing, you stand up to look around for clues");
                    this.Story.Add(" Perplexed by mystery, you're faced with a dilemma.What do you do?"); // start of Scenario switch statement for Planet Noir choices
                    this.Story.Add("A) ask security protocols who was on the ship"); 
                    this.Story.Add("B) follow footprints leading outside the ship");
                    this.Story.Add("C) grab an Astrocola and watch cartoons");
                    this.Story.Add("D) tell the ship security protocols to initiate defense level BAMBAM");
                    this.Story.Add($"(Ship security protocol)\n  known fugitive known as THE MAN entered and left with {pc.dog}"); // Scenario 1
                    this.Story.Add($" you remember now, your dog {pc.dog} is gone!!!THE MAN must pay!");
                    this.Story.Add("you grab the nearest item to you and man your ship speeding off towards the next planet to find him"); // item if statement start
                    this.Story.Add("A) you grab the blitz blade"); // add the blitz blade item
                    this.Story.Add("B) you grab the Shield O Saturn"); // add the shield o saturn item
                    this.Story.Add("C) the Plutonian Plasma Rifle"); // add the plasma rifle item
                    this.Story.Add("Angry and disoriented you run to the ship door slamming on the hatch button, suddenly your sucked out into orbit");  // Scenario 2
                    this.Story.Add("due to you being on another planet without an atmosphere, the oxygen is sucked out of you like Douglas Quaid in that movie TOTAL RECALL. nice job there guy");
                    this.Story.Add("leisurely you motion towards the fridge to grab a ice cold Astrocola and notice the key behind it."); // Scenario 3 ADD the DAVE
                    this.Story.Add("what a dumb place to hide my Deatomizing Assault Vulcan Emitter cannon aka The D.A.V.E, after collecting your weapon you remember your objective and set off to find THE MAN on the next planet");
                    this.Story.Add("Paranoid that THE MAN is still onboard your ship you scream to the ship security system to go level BAMBAM");  // Scenario 4
                    this.Story.Add("and proceed to get turned into swiss cheese by the turrets on the ship. THE MAN tricked you and sabotaged the weapon system. nice job there guy");


                    this.story.add("");


                    return true;
                    break;

                case PlanetTypes.Aventus:
                    this.Story.Add($"{pc.Name} lands on Aventus after the ship scanners showed THE MAN’s ship landing here. Uncertain what he landed here but we shall find out.");
                    this.Story.Add("Last known location shows him disappearing just past the only spaceport on the planet, Artelius. After dodging the freight ships, you land on platform 934 after getting clearance from the port officials. ");
                    this.Story.Add("You see what looks like an ostrich in a tuxedo walking towards you. In a shrill voice the call out to you.");

                    this.Story.Add("(Carlsin):\n Greetings traveler, I am Carlsin a dock supervisor, what is your name and reason for being here?"); // start options switch statement
                    this.story.add("1.)	Give what they asked.");
                    this.story.add("2.)	Refuse to answer and shove past.");
                    this.story.add("3.)	Ask if he is an ostrich.");
                    this.story.add("4.)	See inventory"); // display inventory
                    this.story.add("5.)	See Stats"); // display stats
                    this.story.add("You say that you’re PC and are looking for a human called THE MAN. "); // Scenario 1
                    this.story.add("(Carlsin)\n “I don’t know who this man is but we did have a ship illegally land at lumber yard 67. I wouldn’t suggest going there since going there by yourself though. ");
                    this.story.add("The site was recently taken over by a young manticore. I’d stop by Frig&Horges in the marketplace if you plan to still go there. They have all the gear you might need to brave the jungle.");
                    this.story.add("You shove Carlsin causing him to fall off the landing platform. He becomes a new hood ornament for a freight ship leaving planet. You wander into town looking for information."); // Scenario 2
                    this.story.add("You ask him and immediately see him start to tremble. He screeches as he charges towards you. Before you can react, his beak opens wider than you think possible and bites your head off."); // Scenario 3
                    this.story.add("GAME OVER!");

                    this.story.add("You come to a crossroad with a sign pointing to several different places."); // Crossroads switch statement
                    this.story.add("1.)	Go to marketplace");
                    this.story.add("2.)	Go to jungle");
                    this.story.add("3.)	Attempt to ride one of the local Schlemals (Carlsin’s race).");
                    this.story.add("4.)	See inventory"); // display inventory

                    this.story.add("You go to the marketplace and see a store called Frig&Horge. You enter and ask the clerk if you can sell things here. They say yes.");
                    this.story.add("What would you like to do?"); // Market options
                    this.story.add("1.)	Buy items");
                    this.story.add("2.)	Sell items");
                    this.story.add("3.)	Leave");

                    this.story.add("1.)	Auto Chopper____Price 150 Mells"); // Sub-options 2
                    this.story.add("2.)	Jungle Starter Kit_____Price 300 Mells");
                    this.story.add("3.)	Schlemal Doll______Price 50 Mells");
                    this.story.add("4.)	Green Remote_____Price 200 Mells");
                    this.story.add("5.)	Leave");

                    this.story.add("1.)	Show PC inventory with prices"); // Sub-Option 3
                    this.story.add("2. Leave");

                    // go to Carlsins race, Crossroads option 3
                    this.story.add("You sneak up on a Schlemal and right as it notices you, you leap onto its back. It leaps into the air and dunks the both of you into a tree compressor. You become an ambassador’s new table.");
                    this.story.add("Game Over.");
                    // go to Jungle, crossroads option 2
                    this.story.add("You head into the jungle in hopes of finding THE MAN or pet. After trudging through the jungle, the path splits into 2.");
                    this.story.add("1.)	Take the right path");
                    this.story.add("2.)	Take the left path");
                    this.story.add("3.)	Check inventory"); // check inventory
                    this.story.add("4.)	Check stats."); // check stats

                    this.story.add("As you continue down the right path, you smell something sweet from a large flower. As you stop to smell the flower, it lunges out and eats the top half of you."); // Option 1
                    this.story.add("Game Over.");

                    this.story.add("You come upon lumber yard 67. As you arrive, you see a ship that you don’t recognize fly away. It is much sleeker then the local freight ships. THE MAN has got away. "); // Option 2
                    this.story.add("You then hear a mewl from the yard. A kitten with red fur, a small horn, and bat wings trots over to you carrying a star-map data stick. ");
                    this.story.add("you choose to");
                    this.story.add("1.)	feed the manticore");
                    this.story.add("2.)	kick the cat thing.");
                    this.story.add("3.)	Run back to ship.");
                    this.story.add("You kick the cat with wings causing it to drop the star-map data stick. As you bend over to pick it up you hear another mewl. "); //  Option 2
                    this.story.add("Right as your hand touches the data stick, you get engulfed in flames. All that is left is ashes.");
                    this.story.add("Game Over.");
                    this.story.add("You give the manticore cub some of your food. It greedily devours the food and your hand. It starts to purr and won’t leave you alone. "); // Option 1
                    this.story.add("You lost a hand but gained a manticore companion. With the data chip and your new companion, you rush back to your ship and chase after THE MAN.");
                    this.story.add("You rush back through the jungle in hope that you can get to the ship in time. As you arrive, you power it on and check to see if there are any traces of the ship that just left.");
                    this.story.add("You’re in luck! You take off from the landing pad, sending several Schlemals to their death and chase after THE MAN.");
                    // End of Aventus








                    return true;
                    break;
                case PlanetTypes.SpotMee:
                    this.Story.Add()
                        return true;
                    break;
                case PlanetTypes.Wombodum:
                    this.Story.Add()
                        return true;
                    break;
                case PlanetTypes.Krytunga:
                    this.Story.Add()
                        return true;
                    break;

            }
        }
       

        public string[] Story()
        {
            string[] planet1Story1 =
            {
                "Narrator: \n“On a Cold desolate night on Planet Noir our hero comes to, unaware of the adventure that awaits”",
                "Slowly your eyes open, the emergency beacon on your ship is beaming, how you didn't hear it sooner is a mystery but your ship's security system is blaring a name... \n",
                "(HERONAME).",
                "(HERONAME).",
                "(HERONAME).\n",
                "((ship security system))“greetings HERONAME, unknown perpetrator onboard during personnel stasis.”",
                "current lifeforms present one.",
                "One?! Could there be someone on here that is missing, you stand up to look around for clues."
            };
            string[] planet1Story2 =
            {
                "You?\n",
                "1) ask security protocols who was on the ship",
                "2) follow footprints leading outside the ship",
                "3) grab an Astrocola and watch cartoons",
                "4) tell the ship security protocols to initiate defense level “BamBam”"
            };
            string[] planet1Story3 = //Option 2
            {
                "Angry and disoriented you run to the ship door slamming on the hatch button. ",
                "Suddenly your sucked out into orbit due to you being on another planet without an atmosphere. ",
                "The oxygen is sucked  out of you like Douglas Quaid in that movie TOTAL RECALL. \n \n",
                "Nice job there guy!",
                "\n \nGAME OVER!"
            };
            string[] planet1Story4 = //option 3
            {
                "Leisurely you motion towards the fridge to grab a ice cold Astrocola and notice the key behind it, ",
                "what a dumb place to hide my Deatomizing Assault Vulcan Emitter cannon aka The D.A.V.E. ",
                "After collecting your weapon you remember your objective and set off to find THE MAN on the next planet"
            };
            string[] planet1Story5 = //option 4
            {
                "Paranoid that THE MAN is still onboard your ship you scream to the ship security system to go level BAMBAM!",
                "You proceed to get turned into swiss cheese by the turrets on the ship.",
                "THE MAN tricked you and sabotaged the weapon system! \n \n",
                "Nice job there guy! \n \n",
                "GAME OVER!"
            };
            string[] planet1Story6 = //option 1
            {
                "You ask the security monitor who was on the ship ",
                "((Computer)) “Known fugitive and nemesis THE MAN entered and left with (DOGNAME)”",
                "You remember now, your dog (DOGNAME) is gone!!! THE MAN must pay!",
                "You grab the nearest item to you and man your ship speeding off towards the next planet to find him"
            };
            string[] planet1Story7 = //option 1 weapon choices
            {
                "You grab?",
                "1) you grab the blitz blade",
                "2) you grab the Shield O Saturn",
                "3) you grab the Plutonian Plasma Rifle"
            };

            string[] planet2Story1 =
            {
                "Aventus, the jungle planet. \n",
                "PC lands on Aventus after the ship scanners showed THE MAN’s ship landing here. ",
                "Uncertain where exactly he landed but we shall find out! ",
                "Last known location shows him disappearing just past the only spaceport on the planet, Artelius.",
                "After dodging the freight ships, you land on platform 934 after getting clearance from the port officials.",
                "You see what looks like an ostrich in a tuxedo walking towards you. In a shrill voice they call out to you.",
                "((Carlsin)) “Greetings traveler, I am Carlsin a dock supervisor here, what is your name and reason for being here?”"
            };
            string[] planet2Story2 =
            {
                "You? \n",
                "1.)  Give what they asked.",
                "2.)  Refuse to answer and shove past.",
                "3.)  Ask if he is an ostrich.",
                "4.)  See inventory",
                "5.)  See Stats"
            };
            string[] planet2Story3 = //option 1
            {
                "You say that you’re PC and are looking for a human called THE MAN.",
                "((Carlsin)) “I don’t know who this man is but we did have a ship illegally land at lumber yard 67. ",
                "I wouldn’t suggest going there since going there by yourself though.",
                "The site was recently taken over by a young manticore! ",
                "I’d stop by Frig&Horges in the marketplace if you plan to still go there.",
                "They have all the gear you might need to brave the jungle.”"
            };
            string[] planet2Story4 = //option 2
            {
                "You shove Carlsin causing him to fall off the landing platform. ",
                "He becomes a new hood ornament for a freight ship leaving planet. ",
                "You wander into town looking for information before anyone else can show up."
            };
            string[] planet2Story5 = //option 3
            {
                "You ask him and immediately see him start to tremble. He screeches as he charges towards you. ",
                "Before you can react, his beak opens wider than you think possible and bites your head off. \n \n",
                "Nice try there guy! \n \n ",
                "GAME OVER!"
            };
            string[] planet2Story6 = //continue for options 1 and 2
            {
                "You come to a crossroad with a sign pointing to several different places.",
                "You? \n",
                "1.)  Go to marketplace",
                "2.)  Go to jungle",
                "3.)  Attempt to ride one of the local Schlemals (Carlsin’s race).",
                "4.)  See inventory",
                "5.)  See Stats"
            };
            string[] planet2Story7 = //option 1
            {
                "You go to the marketplace and see a store called Frig&Horge. ",
                "You enter and ask the clerk if you can sell things here. They say yes."
            };
            string[] planet2Story8 = //option 3
            {
                "You sneak up on a Schlemal and right as it notices you, you leap onto its back. ",
                "It leaps into the air and dunks the both of you into a tree compressor. ",
                "You become an ambassador’s new table. \n \n",
                "Nice try there guy! \n \n",
                "GAME OVER!"
            };
            string[] planet2Story9 = //option 2/continue from leaving option 1
            {
                "You head into the jungle in hopes of finding THE MAN or {pet}. ",
                "After trudging through the jungle, the path splits into 2.",
                "You? \n",
                "1.)  Take the right path",
                "2.)  Take the left path",
                "3.)  Check inventory",
                "4.)  Check stats."
            };
            string[] planet2Story10 = //option 1
            {
                "As you continue down the right path, you smell something sweet from a large flower. ",
                "As you stop to smell the flower, it lunges out and eats the top half of you. \n \n",
                "Nice try there guy! \n \n",
                "GAME OVER!"
            };
            string[] planet2Story11 = //option 2
            {
                "You come upon lumber yard 67. As you arrive, you see a ship that you don’t recognize fly away. ",
                "It is much sleeker then any of the local freight ships. THE MAN has got away. ",
                "You then hear a mewl from the yard. ",
                "A kitten with red fur, a small horn, and bat wings trots over to you carrying a star-map data stick."
            };
            string[] planet2Story12 =
            {
                "You? \n",
                "1.)  Feed the young manticore",
                "2.)  Kick the cat thing.",
                "3.)  Run back to ship."
            };
            string[] planet2Story13 = //option 2
            {
                "You kick the cat with wings causing it to drop the star-map data stick. ",
                "As you bend over to pick it up... ",
                "you hear another mewl. ",
                "Right as your hand touches the data stick, you get engulfed in flames. ",
                "All that is left is ashes. \n \n",
                "Nice try there guy! \n \n",
                "GAME OVER!"
            };
            string[] planet2Story14 = //option 1
            {
                "You give the manticore cub some of your food. It greedily devours the food and your hand. ",
                "It starts to purr and won’t leave you alone. ",
                "You lost a hand but gained a manticore companion. ",
                "With the data chip and your new companion, you rush back to your ship and chase after THE MAN."
            };
            string[] planet2Story15 = //option 3
            {
                "You rush back through the jungle in hope that you can get to the ship in time. ",
                "As you arrive, you power it on and check to see if there are any traces of the ship that just left. \n",
                "You’re in luck! \n",
                "You take off from the landing pad, sending several Schlemals to their death and chase after THE MAN."
            };

            string[] planet3Story1 =
            {
                "SpotMee the muscle planet \n",
                "You are at planet SpotMee and land in the capital city, Brotopia. ",
                "THE MAN is definitely here, but the city is large and filled with gladiator rings. ",
                "As you start to walk towards the city, an AD bot starts screaming its ad in your face.",
                "((Ad bot)) “Come on down!”",
                "“Come on down!”",
                "“Come one, come all to the Guilds Gym Arena! ",
                "Legendary boss, THE MAN, challenges all to come fight to take his fortune." +
                "Can any claim his Mells?!?!?!”"
            };
            string[] planet3Story2 =
            {
                "You?",
                "1.)  Go to the Marketplace.",
                "2.)  Go to Guilds Gym Arena.",
                "3.)  Check inventory.",
                "4.)  Check stats."
            };
            string[] planet3Story3 = //option 1
            {
                "As you wander down the marketplace, you see a store called, Do You Even Lift. You decide to shop there."
            };
            string[] planet3Story4 = //option 2
            {
                "You run off towards Guilds Gym Arena, the AD bot blaring the same ad the whole way. ",
                "When you arrive to the arena you see a line with various aliens hoping to win THE MAN’s fortune. ",
                "When you finally get to the front you recognize an Orgus by its big green pig head with tusk shooting out. ",
                "He has a name tag that reads Daisy.",
                "((Daisy)) in a deep gruff voice he asks, “Arena name and race?”"
            };
            string[] planet3Story5 =
            {
                "You?",
                "1.)  Give new name for arena fights.",
                "2.)  Give your name for arena fights.",
                "3.)  Ask Daisy about name.",
                "4.)  Mock Daisy for name."
            };
            string[] planet3Story6 =  //option 4
            {
                "You laugh at Daisy for being named after a weak Earth flower. Daisy roars over being mocked, ",
                "“Daisy is greatest warrior name from Orgus home world!!! Puny human shall die!”",
                "He slams his hand down on a button on his desk causing the floor below you to disappear. ",
                "You fall into a pit of boiling oil becoming Daisy’s snack for the arena matches later. \n \n",
                "Nice try there guy! \n \n",
                "GAME OVER!"
            };
            string[] planet3Story7 = //option 2
            {
                "You give Daisy your name and he explains that you must win the 3 rounds in order to win THE MAN’s tournament. ",
                "As you enter the arena for the first round a voice over the louder speakers come on. ",
                "“Cooooontestants!!! ",
                "There has been a change for the first round! ",
                "Instead of the traditional Brotopia dumbbell fight, whoever kills {PC}, the only human here, will win the tournament!!!” ",
                "All the contestants turn toward you and before anyone else can jump you, ",
                "an Orgus jumps from the stands and turns you into a pancake. \n \n",
                "Nice try there guy!",
                "GAME OVER!"
            };
            string[] planet3Story8 = //option 3
            {
                "Daisy tells you he was named after the greatest warrior in Orgus history. ",
                "You marvel in wonder at the name. ",
                "Daisy says he likes you and says if you enter the red door over there, you can skip to the final round."
            };
            string[] planet3Story9 = //option 1
            {
                // player character gives new name
                "“Welcome contestants!! ",
                "The first round shall be the traditional Dumbbell fight! Ready, Go!”" +
                "You look around and see everyone pulling out dumbbells and throwing them like snowballs."
            };
            string[] planet3Story10 =
            {
                "You?",
                "1.)  Access Inventory",
                "2.)  Dodge and hope to pick up stray dumbbells.",
                "3.)  Cower in a corner.",
                "4.)  Run around the arena screaming."
            };
            string[] planet3Story11 = //option 1
            {
                // [Everything but dumbbells fails and sends back to original options]
                //[If dumbbells used:]
                "You start pegging contestant after contestant, while dogging incoming dumbbells.",
                "You survived the round and moved on"
            };
            string[] planet3Story12 =//option 2
            {
                "You attempt to dodge the incoming dumbbells but get hit in the head crushing it. \n \n",
                "Nice try there guy! \n \n",
                "GAME OVER!"
            };
            string[] planet3Story13 = //option 3
            {
                "You run to the corner of the circular arena and cower in the fetal position. ",
                "After 10 mins of fight, you hear victory! You’re on of the 5 finalists."
            };
            string[] planet3Story14 = //option 4
            {
                "You start screaming as you run around. ",
                "You forget to breath properly and pass out after 10 mins. ",
                "You awake with round 2 under way but a giant horned lizard having eaten your legs. \n \n",
                "Nice try there guy! \n \n",
                "GAME OVER!"
            };
            string[] planet3Story15 = //Round 2
            {
                "((Announcer)) “Champions moving on to round 2! You shall face one of our beasts we have in our arena. ",
                "When called, come face your beast!”",
                "The first 2 contestants both quickly get eaten, making you nervous."
                //Fight
            };
            string[] planet3Story16 = //Round 3
            {
                "((Announcer))“THE MAN shall greet the champion.”",
                "THE MAN walks out to greet you but freezes when he sees you. ",
                "He screams for them to release another beast as he runs away."
                //Fight
            };
            string[] planet3Story17 =
            {
                "You chase after THE MAN barely making it to your ship before you see his ship leave atmosphere. " +
                "You follow after him in the ship."
            };

            string[] planet4Story1 =
            {
                "Wumbodom the cyborg planet. \n",
                "You chase THE MAN to Wumbodom. ",
                "The whole planet is one giant city and THE MAN went straight to land in the slums of the planet. ",
                "With your larger ship, you can’t fit in where he landed, so you land on the roof of one of the outlying towers. " +
                "As you climb down the building, you see a store called Wumbohex."
            };
            string[] planet4Story2 =
            {
                "You? \n",
                "1.)	Shop" ,
                "2.)	Leave the tower" ,
                "3.)	Check Inventory" ,
                "4.)	Check Stats"
            };
            string[] planet4Story3 = //option2
            {
                "You race down the rest of the tower and as you exit you bump into a cyborg Ephantus, an Elephant man race. ",
                "He turns and stares at you with his red robotic eye."
            };
            string[] planet4Story4 =
            {
                "You? \n",
                "1.)	Apologize and run away.",
                "2.)	Attempt to fight.",
                "3.)	Ask if they wanna go.",
                "3.)	Check Inventory" ,
                "4.)	Check Stats"
            };
            string[] planet4Story5 = //option 3
            {
                "You ask the Ephantus and found it he is a she... ",
                "She says she is Klarice and was surprise her hired date was a human.  ",
                "She takes you to the closest mall and dragging you from one store to the next all day long. ",
                "You awake the next morning tired and sore but 2000 mells richer."
                //Go to option 1
            };
            string[] planet4Story6 = //option 2
            {
                "As you reach for a weapon his mechanical nose shoots into your chest and rips your heart out. ",
                "He screams “KALIMA!” as you die. \n \n",
                "Nice try there guy! \n \n",
                "GAME OVER!"
            };
            string[] planet4Story7 = //option 1
            {
                "You run away from the Cyborg Ephantus in terror, hoping to never see them again! " ,
                "You rush into the slums knowing your so close to pet. " ,
                "As you head towards where THE MAN lands you see the busy main street full of beggars" +
                "You also see a back alley that appears to bypass all of it."
            };
            string[] planet4Story8 =
            {
                "You?",
                "1.)  Take the main street.",
                "2.)  Take the alley.",
                "3.)  Check Inventory" ,
                "4.)  Check Stats"
            };
            string[] planet4Story9 = //option 2
            {
                "You begin walking through the alley. " +
                "Suddenly, a small green humanoid with large pointy ears clutching what appears to be a butter knife runs into you. " +
                "You recognize him as a Gobleen. He is short of breath as if he was running from something. " +
                "He realizes you’re not a wall but a person and freaks out. " +
                "He screams, “You will not take my precious!!” as he strokes his butter knife."
                //Fight Gobleen
            };
            string[] planet4Story10 = //option 2 fight win
            {
                "You have optained item [THE HOLY BUTTER KNIFE]"
            };
            string[] planet4Story11 = //option 1
            {
                "You attempt to trudge past all the beggars without responding to them. ",
                "A small female blue skinned humanoid with 2 small horns on her forehead and black bat wings on her back in a long brown shirt climbs onto your shoulder. ",
                "You recognize she is of the Lashtist race. ",
                "She says mister “Where are you going? If I guide you there will you give me some food?”"
            };
            string[] planet4Story12 =
            {
                "You?",
                "1.)  Say yes.",
                "2.)  Tell her to scram.",
                "3.)  Check Inventory",
                "4.)  Check Stats"
            };
            string[] planet4Story13 = //option 1
            {
                "She guides you to THE MAN’s ship, but you forgot Lashtist feed off the blood of other." +
                "She starts drinking your blood as you see THE MAN fly away.",
                "Nice try there guy! \n \n",
                "GAME OVER!"
            };
            string[] planet4Story14 = //option 2
            {
                "She flutters away sobbing about being hungry. ",
                "Then you notice her start drinking the blood of another beggar in an alley. He becomes a mummy is 30 seconds. ",
                "You just dodged a bullet."
            };
            string[] planet4Story15 =
            {
                "As you leave beggar central you see THE MAN’s ship..." +
                "But! there is a massive gang war on the path to the ship.",
                "You?",
                "1.)  Fight your way through.",
                "2.)  Attempt to sneak around.",
                "3.)  Yell dumbbell fight!"
            };
            string[] planet4Story16 = //option 3
            {
                "You yell out and both gangs turn to you. " +
                "You hear someone says, “wrong planet!” as a pizza flies toward you.",
                "Its aroma attracts the local Flesh fleas. You are eaten alive by the fleas. \n \n",
                "Nice try there guy! \n \n",
                "GAME OVER!"
            };
            string[] planet4Story17 = //option 2
            {
                "As you attempt to sneak past the war grounds... " +
                "A humanoid cyborg with no details to see his original race but a large ‘A’ on his chest confronts you. " +
                "((Cyborg)) “To whose allegiance do you claim?!Awesome or Metal?!”"
            };
            string[] planet4Story18 =
            {
                "You?",
                "1.)	Give item from inventory." +
                "2.)	Answer with “Metal ?”" +
                "3.)	Answer with “Awesome ?”" +
                "4.)	[Fight]" //goes to option 1 of planet4Story15
            };
            string[] planet4Story19 = //option 2
            {
                "((Cyborg)) “You dare say Metal Man is better?!?! To me, an Awesome Cyborg fan?!?!?! Be converted!!”",
                "He throws a helmet on you which forces you to watch ‘The Adventures of Awesome Cyborg’ on repeat for 3 weeks straight." ,
                "Awesome Cyborg is love; Awesome Cyborg is life." ,
                "You join the gang with no self - will attempting to convert others to your cause. \n \n",
                "Nice try there guy! \n \n",
                "GAME OVER!"
            };
            string[] planet4Story20 = //option 3
            {
                "((Cyborg)) “I see through you lies Metal Man spy!! There is no saving your kind!”",
                "He pulls out an anti-battleship cannon and vaporizes you. You are wiped from existence. \n \n",
                "Nice try there guy! \n \n",
                "GAME OVER!"
            };
            string[] planet4Story21 = //option 2
            {
                //If you give Awesome Cyborg Doll
                "((Cyborg)) “You would give me this rare figurine of Awesome Cyborg?! ",
                "There are only 10 in existence! I will cherish what you have given me! ",
                "May you bring justice to the blind comrade!”"
                //Goes to option 4 if any other item
            };
            string[] planet4Story22 =
            {
                "After scrapping through the warzone, you finally make it to THE MAN’s ship. " ,
                "Sadly, right as you approach the ship, the entry ramp raises up and the ship begins to leave. " ,
                "Over a speaker from the ship you hear THE MAN call out. " ,
                "“Muahahahaha! PC you’re too slow. I’ve got everything I need to feats with pet. " ,
                "If you want to join us on Krytunga then be my guest!” " ,
                "He then speeds of into space. \n",
                "You know where this ends. Time to get {pet} back. " +
                "You head back to your ship, setting coordinates for the planet of Krytunga, the crystal world."
            };

            string[] planet5Story1 =
            {
                "Krytunga, the crystal planet \n",
                "Finally, you land on the remote planet of Krytunga. This planet is said to be uninhabitable due only the planet’s unique crystals that grow here. \n " +
                "As you circle the planet you notice what appears to be a fortress made from crystal.\n",
                "You notice that THE MAN’s ship is landed in the courtyard. \n",
                "((PC)) “Found you, you ugly bastard!” you growl to yourself. \n",
                "You land just outside the fortress and get ready to face the music, you mean THE MAN. As you leave your ship, a crystal alien you’ve never heard or seen of before approaches you. \n",
                "He looks like a 3-foot humanoid with crystal skin. As he draws near, he begins to speak. \n",
                "((Crystal Alien)) “Yo homedog! Care to swap some sparkle spazzles?” \n",
                "You? \n",
                "1.) Say “I guess?” \n2.) Say “Some what?!?” \n3.) Punt the crystal dwarf thing \n4.) Ignore it and rush into the fortress."
            };
            string[] planet5Story2 =
            {
                "\n \n((Crystal Alien)) “Cool! Here’s what I got flesh man!”"
            };
            string[] planet5Story3 =
            {
                "The crystal alien launches into the history of the planet and the local lingo. \n",
                "You attempt to leave several times, but he cuts you off every time. \n",
                "He leaves no room to interrupt during his entire 8-year long lecture. \n",
                "Given no room to ever leave, you die from starvation 1 month into the lecture. \n",
                "Nice try there bud!"
            };
            string[] planet5Story4 =
            {
                "As your leg makes contact with the alien, it starts to move through him like swimming through honey. \n",
                "Before you can realize it, the alien has become your leg from the knee down. \n",
                "His face disappears but now hear his voice in your head. \n",
                "Your otherwise fine and charge into the fortress mildly off balance. \n",
                "\n ((crystal alien)) “So no trading sparkle spazles?” "
            };
            string[] planet5Story5 =
            {
                "You charge into the fortress expecting to face THE MAN’s henchmen but find it empty. ",
                "You rush through the halls until you come to a grand staircase going up to one massive door",
                " and another going down to an identical looking door.",
                "You? \n",
                "Options: \n",
                "1.) Go up the stairs ",
                "2.) Go down the stairs"
            };
            string[] planet5Story6 =
            {
                "As you climb down the stairs you take a deep breath before you fling the doors open. ",
                "Astonished, you find not a throne room but what appears to be some sort of factory. ",
                "You wander to the edge of the observation platform to get a better look. \n",
                "As you stare out across the factory, it quickly becomes clear that this is where THE MAN creates the crystal aliens",
                " like the one that greeted you when you landed. " +
                "As this dons on you, you feel someone kick you from behind.",
                "You fall over the railing into a vat of molten crystal in front of you. ",
                "You’re able to turn your head before you fall in and see THE MAN cackling as he watches you die in the molten crystal.\n",
                "“MUahahahahaha!!!” \n \n",
                "Nice try there my guy!"
            };
            string[] planet5Story7 =
            {
                "As you climb up the stairs you take a deep breath before you fling the doors open. ",
                "You see THE MAN on a throne of crystal smiling down at you. \n",
                "((THE MAN)) “Welcome PC!I’ve been waiting for you!”",
                "“Can’t hold the grand party without you. Give me 5 more minutes and it will all be ready.” \n",
                "You?\n",
                "Options:\n",
                "1.) Don’t wait and attack. ",
                "2.) Demand he give pet back. ",
                "3.) Wait the 5 minutes."
            };
            string[] planet5Story8 =
            {
                "You decide to wait to see what happens. ",
                "More crystal aliens, similar to the one the greeted you start to bring in what appear to be party decorations. ",
                "A table and chair are brought out for you along with a massive 7 - layer cake that is placed in front of you.",
                "The aliens start sing happy birthday to you, and THE MAN tells you to blow out the candles.",
                "You indulge them and blow out the candles.",
                ".",
                ".",
                ".",
                "BOOOOOOOMMMM!!!!",
                "The cake exploded the second you blew the candles out.",
                "You should have never trusted THE MAN, even if it was your birthday.\n",
                "Nice try there guy!"
            };
            string[] planet5Story9 =
            {
                "THE MAN stares a you confused.",
                "He goes on to tell you he never took pet; he just hid him in your ship’s exterior storage compartment.",
                "He goes on to say your birthday party will soon be ready and should stick around for it. \n",
                "Bewildered, you race out to your ship and check the exterior storage.",
                "Sure enough, the second you open it, pet leaps onto you and starts licking your face.",
                "Overjoyed, the 2 of you go back onto your ship to float through the galaxy watching cartoons together.",
                "You don’t trust THE MAN with throwing any parties and just leave the planet. \n",
                "As you start to leave atmosphere, you see THE MAN’s fortress explode.",
                "Glad to have trusted your gut, you and pet fly off on new adventures. \n \n",
                "Victory, PC has got pet back!",
                "Thanks for playing!"
            };
            string[] planet5Story10 =
            {
                "Shocked by your sudden attack, THE MAN throws out a yellow crystal that turns into 2-foot yellow crystal mouse."
            };
            string[] planet5Story11 =
            {
                "((THE MAN)) “Cursed knock-offs! I’ll just deal with you myself!”"
            };
            string[] planet5Story12 =
            {
                "After obliterating THE MAN, you run past the throne into what you assume was THE MAN’s room. ",
                "There in a cage is pet. You quickly bust the lock and pet flies into your arms, licking your face.",
                "Finally, you and pet can get back to your primary mission, watching all the galaxy’s cartoons ever created! \n \n",
                "Victory, {PC} has got {pet} back! \n \n",
                "Thanks for playing!"
            };
            throw new System.NotImplementedException();
        }
    }
}