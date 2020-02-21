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
                        pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                        pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;
                case "Schlemal doll":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                        pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;
                case "Green remote":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                        pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;
                case "20 lbs dumbbells":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                        pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;
                case "45 lbs plate":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                        pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;
                case "OFF protein":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                        pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;
                case "Animal energy powder":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                        pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;
                case "The claw":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                        pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;
                case "Purple remote":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                        pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;
                case "Awesome cyborg doll":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                        pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;
                case "Laser sword":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                        pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;
                case "Red crystal":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                        pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;
                case "Blue Crsytal":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                        pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
                        storeInventory.Find(item => item.Name == selection).Quantity--;
                        storeInventory.RemoveAll(item => item.Quantity <= 0);
                        return true;
                    }
                    else return false;
                case "Green crystal":
                    if (storeInventory.Exists(item => item.Name == selection))
                    {
                        pc.Inventory.Add(storeInventory.Find(item => item.Name == selection));
                        pc.Currency -= storeInventory.Find(item => item.Name == selection).Value;
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
            throw new System.NotImplementedException();
        }
    }
}