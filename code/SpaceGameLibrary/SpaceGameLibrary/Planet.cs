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

                    story.Add("(Narrator) \n On a Cold desolate night on Planet Noir our hero comes to, unaware of the adventure that awaits");
                    story.Add($"(SNarrator) \n slowly your eyes open, the emergency beacon on your ship is beaming, how you didn't hear it sooner is a mystery but your ship's security system is blaring a name... {pc.Name.ToUpper()}!!!!");
                    story.Add($"(Ship Security system) \n Greetings {pc.Name}, \n unknown perpetrator onboard during personnel stasis. current lifeforms present one...");
                    story.Add($"({pc.Name} inner dialogue) \n one? could there be someone on here that is missing, you stand up to look around for clues");
                    story.Add("Perplexed by mystery, you're faced with a dilemma.What do you do?"); // start of Scenario switch statement for Planet Noir choices
                    story.Add("A) ask security protocols who was on the ship");
                    story.Add("B) follow footprints leading outside the ship");
                    story.Add("C) grab an Astrocola and watch cartoons");
                    story.Add("D) tell the ship security protocols to initiate defense level BAMBAM");
                    story.Add($"(Ship security protocol)\n  known fugitive known as THE MAN entered and left with {pc.PetName}"); // Scenario 1
                    story.Add($" you remember now, your dog {pc.PetName} is gone!!!THE MAN must pay!");
                    story.Add("you grab the nearest item to you and man your ship speeding off towards the next planet to find him"); // item if statement start
                    story.Add("A) you grab the blitz blade"); // Add the blitz blade item
                    story.Add("B) you grab the Shield O Saturn"); // Add the shield o saturn item
                    story.Add("C) the Plutonian Plasma Rifle"); // Add the plasma rifle item
                    story.Add("Angry and disoriented you run to the ship door slamming on the hatch button, suddenly your sucked out into orbit");  // Scenario 2
                    story.Add("due to you being on another planet without an atmosphere, the oxygen is sucked out of you like Douglas Quaid in that movie TOTAL RECALL. nice job there guy");
                    story.Add("leisurely you motion towards the fridge to grab a ice cold Astrocola and notice the key behind it."); // Scenario 3 ADD the DAVE
                    story.Add("what a dumb place to hide my Deatomizing Assault Vulcan Emitter cannon aka The D.A.V.E, after collecting your weapon you remember your objective and set off to find THE MAN on the next planet");
                    story.Add("Paranoid that THE MAN is still onboard your ship you scream to the ship security system to go level BAMBAM");  // Scenario 4
                    story.Add("and proceed to get turned into swiss cheese by the turrets on the ship. THE MAN tricked you and sabotaged the weapon system. nice job there guy");
                    // End of Noir
                    return story;

                case PlanetTypes.Aventus:
                    story.Add($"{pc.Name} lands on Aventus after the ship scanners showed THE MAN’s ship landing here. Uncertain what he landed here but we shall find out.");
                    story.Add("Last known location shows him disappearing just past the only spaceport on the planet, Artelius. After dodging the freight ships, you land on platform 934 after getting clearance from the port officials. ");
                    story.Add("You see what looks like an ostrich in a tuxedo walking towards you. In a shrill voice the call out to you.");
                    story.Add("(Carlsin):\n Greetings traveler, I am Carlsin a dock supervisor, what is your name and reason for being here?"); // start options switch statement
                    story.Add("1.)	Give what they asked.");
                    story.Add("2.)	Refuse to answer and shove past.");
                    story.Add("3.)	Ask if he is an ostrich.");
                    story.Add("4.)	See inventory"); // display inventory
                    story.Add("5.)	See Stats"); // display stats
                    story.Add($"You say that you’re {pc.Name} and are looking for a human called THE MAN. "); // Scenario 1
                    story.Add("(Carlsin)\n “I don’t know who this man is but we did have a ship illegally land at lumber yard 67. I wouldn’t suggest going there since going there by yourself though. ");
                    story.Add("The site was recently taken over by a young manticore. I’d stop by Frig&Horges in the marketplace if you plan to still go there. They have all the gear you might need to brave the jungle.");
                    story.Add("You shove Carlsin causing him to fall off the landing platform. He becomes a new hood ornament for a freight ship leaving planet. You wander into town looking for information."); // Scenario 2
                    story.Add("You ask him and immediately see him start to tremble. He screeches as he charges towards you. Before you can react, his beak opens wider than you think possible and bites your head off."); // Scenario 3
                    story.Add("GAME OVER!");
                    story.Add("You come to a crossroad with a sign pointing to several different places."); // Crossroads switch statement
                    story.Add("1.)	Go to marketplace");
                    story.Add("2.)	Go to jungle");
                    story.Add("3.)	Attempt to ride one of the local Schlemals (Carlsin’s race).");
                    story.Add("4.)	See inventory"); // display inventory
                    story.Add("You go to the marketplace and see a store called Frig&Horge. You enter and ask the clerk if you can sell things here. They say yes.");
                    story.Add("What would you like to do?"); // Market options
                    story.Add("1.)	Buy items");
                    story.Add("2.)	Sell items");
                    story.Add("3.)	Leave");
                    story.Add("1.)	Auto Chopper____Price 150 Mells"); // Sub-options 2
                    story.Add("2.)	Jungle Starter Kit_____Price 300 Mells");
                    story.Add("3.)	Schlemal Doll______Price 50 Mells");
                    story.Add("4.)	Green Remote_____Price 200 Mells");
                    story.Add("5.)	Leave");
                    story.Add("1.)	Show PC inventory with prices"); // Sub-Option 3
                    story.Add("2. Leave");
                    // go to Carlsins race, Crossroads option 3
                    story.Add("You sneak up on a Schlemal and right as it notices you, you leap onto its back. It leaps into the air and dunks the both of you into a tree compressor. You become an ambassador’s new table.");
                    story.Add("Game Over.");
                    // go to Jungle, crossroads option 2
                    story.Add("You head into the jungle in hopes of finding THE MAN or pet. After trudging through the jungle, the path splits into 2.");
                    story.Add("1.)	Take the right path");
                    story.Add("2.)	Take the left path");
                    story.Add("3.)	Check inventory"); // check inventory
                    story.Add("4.)	Check stats."); // check stats
                    story.Add("As you continue down the right path, you smell something sweet from a large flower. As you stop to smell the flower, it lunges out and eats the top half of you."); // Option 1
                    story.Add("Game Over.");
                    story.Add("You come upon lumber yard 67. As you arrive, you see a ship that you don’t recognize fly away. It is much sleeker then the local freight ships. THE MAN has got away. "); // Option 2
                    story.Add("You then hear a mewl from the yard. A kitten with red fur, a small horn, and bat wings trots over to you carrying a star-map data stick. ");
                    story.Add("you choose to");
                    story.Add("1.)	feed the manticore");
                    story.Add("2.)	kick the cat thing.");
                    story.Add("3.)	Run back to ship.");
                    story.Add("You kick the cat with wings causing it to drop the star-map data stick. As you bend over to pick it up you hear another mewl. "); //  Option 2
                    story.Add("Right as your hand touches the data stick, you get engulfed in flames. All that is left is ashes.");
                    story.Add("Game Over.");
                    story.Add("You give the manticore cub some of your food. It greedily devours the food and your hand. It starts to purr and won’t leave you alone. "); // Option 1
                    story.Add("You lost a hand but gained a manticore companion. With the data chip and your new companion, you rush back to your ship and chase after THE MAN.");
                    story.Add("You rush back through the jungle in hope that you can get to the ship in time. As you arrive, you power it on and check to see if there are any traces of the ship that just left.");
                    story.Add("You’re in luck! You take off from the landing pad, sending several Schlemals to their death and chase after THE MAN.");
                    // End of Aventus
                    return story;

                case PlanetTypes.SpotMee:
                    story.Add("You are at planet SpotMee and land in the capital city, Brotopia. THE MAN is definitely here, but the city is large and filled with gladiator rings.");
                    story.Add(". As you start to walk towards the city, an AD bot starts screaming its ad in your face.");
                    story.Add("(ad bot) \n Come on down, come on down. Come one, come all to the Guilds Gym Arena. Legendary boss, THE MAN, challenges all to come fight to take his fortune. Can any claim his Mells?!?!?!” ");
                    story.Add("What do you do?"); // Options start
                    story.Add("1.)	Go to the Marketplace.");
                    story.Add("2.)	Go to Guilds Gym Arena.");
                    story.Add("3.)	Check inventory.");
                    story.Add("4.)	Check stats.");
                    story.Add("As you wander down the marketplace, you see a store called, Do You Even Lift. You decide to shop there."); // Option 1
                    story.Add("1.)	Buy");
                    story.Add("2.)	Sell");
                    story.Add("3.)	Leave");
                    story.Add("Shop Items to buy:");
                    story.Add("1.)	20lbs Dumbbell/ qty: 20 price: 250 mells");
                    story.Add("2.)	45lbs Plate/ qty: 3 price: 50 mells");
                    story.Add("3.)	OFFs Protein/ price: 400 mells");
                    story.Add("4.)	Animal Energy Powder/ price: 150 mells");
                    story.Add("5.)	Leave");
                    story.Add(""); // When leaving shop, go to option 2
                    story.Add("You run off towards Guilds Gym Arena, the AD bot blaring the same ad the whole way. When you arrive to the arena you see a line with various aliens hoping to win THE MAN’s fortune. "); // Option 2
                    story.Add("When you finally get to the front you recognize an Orgus by its big green pig head with tusk shooting out. He has a name tag that reads Daisy.");
                    story.Add("(Daisy) \n in a deep gruff voice he asks, “Arena name and race?”");
                    story.Add("1.)	Give new name for arena fights."); // Options
                    story.Add("2.)	Give your name for arena fights.");
                    story.Add("3.)	Ask Daisy about name.");
                    story.Add("4.)	Mock Daisy for name.");
                    story.Add("You laugh at Daisy for being named after a weak Earth flower. Daisy roars over being mocked, “Daisy is greatest warrior name from Orgus home world!!! Puny human shall die!”"); // Option 4
                    story.Add("He slams his hand down on a button on his desk causing the floor below you to disappear. You fall into a pit of boiling oil becoming Daisy’s snack for the arena matches later.");
                    story.Add("Game Over.");
                    story.Add("You give Daisy your name and he explains that you must win the 3 rounds in order to win THE MAN’s tournament. As you enter the arena for the first round a voice over the louder speakers come on. "); // Option 2
                    story.Add("“Cooooontestants!!! There has been a change for the first round! Instead of the traditional Brotopia dumbbell fight, whoever kills PC, the only human here, will win the tournament!!!” ");
                    story.Add("All the contestants turn toward you and before anyone else can jump you, an Orgus jumps from the stands and turns you into a pancake.");
                    story.Add("Game Over");
                    story.Add("Daisy tells you he was named after the greatest warrior in Orgus history. You marvel in wonder at the name. Daisy says he likes you and says if you enter the red door over there, you can skip to the final round."); // Option 3
                    story.Add("PC gives new name."); // Go to round 3 of option 1 // Option 1
                    story.Add("Welcome contestants!! The first round shall be the traditional Dumbbell fight! Ready, Go!");
                    story.Add("You look around and see everyone pulling out dumbbells and throwing them like snowballs.");
                    story.Add("1.)	Access Inventory"); // Options //[Everything but dumbbells fails and sends back to original options]
                    story.Add("2.)	Dodge and hope to pick up stray dumbbells");
                    story.Add("3.)	Cower in a corner.");
                    story.Add("4.)	Run around the arena screaming.");
                    story.Add("“You survived the round and moved on.”"); // If dumbbells used.
                    story.Add("You attempt to dodge the incoming dumbbells but get hit in the head crushing it.");
                    story.Add("Game Over.");
                    story.Add("You run to the corner of the circular arena and cower in the fetal position. After 10 mins of fight, you hear victory! You’re on of the 5 finalists. Move on to round 2"); // Option 3
                    story.Add("You start screaming as you run around. You forget to breath properly and pass out after 10 mins. You awake with round 2 under way but a giant horned lizard having eaten your legs. "); // Option 4
                    story.Add("Game over.");
                    story.Add("(Announcer) \n “Champions moving on to round 2! You shall face one of our beasts we have in our arena. When called, come face your beast!”"); // Round 2
                    story.Add("The first 2 contestants both quickly get eaten, making you nervous.");
                    story.Add("(Announcer) \n "); // Fight {random Enemy} Win move on , lose Game Over // Round 3:
                    story.Add("“THE MAN shall greet the champion.”");
                    story.Add("THE MAN walks out to greet you but freezes when he sees you. He screams for them to release another beast as he runs away.");
                    story.Add("You chase after THE MAN barely making it to your ship before you see his ship leave atmosphere. You follow after him in the ship."); // Fight [Random Enemy] [Win move on, lose Game over]
                    // End of SpotMee
                    return story;

                case PlanetTypes.Wombodum:
                    story.Add("You chase THE MAN to Wumbodom. The whole planet is one giant city and THE MAN went straight to land in the slums of the planet");
                    story.Add("With your larger ship, you can’t fit in where he landed, so you land on the roof of one of the outlying towers. As you climb down the building, you see a store called Wumbohex. ");
                    story.Add("1.)	Shop"); // Options
                    story.Add("2.)	Leave the tower");
                    story.Add("3.)	Check Inventory");
                    story.Add("4.)	Check Stats");
                    story.Add("1.)	The Claw/ price: 600 mells"); // Shop buy options
                    story.Add("2.)	Purple Remote/ price: 200 mells");
                    story.Add("3.)	Awesome Cyborg Doll/ price: 350 mells");
                    story.Add("4.)	Laser Sword/ price: 400 mells");
                    story.Add("5.)	Leave");
                    story.Add("You race down the rest of the tower and as you exit you bump into a cyborg Ephantus, an Elephant man race. He turns and stares at you with his red robotic eye.");
                    story.Add("What do you do?"); // Options
                    story.Add("1.)	Apologize and run away.");
                    story.Add("2.)	Attempt to fight.");
                    story.Add("3.)	Ask if they wanna go.");
                    story.Add("You ask the Ephantus and found it he is a she. She says she is Klarice and was surprise her hired date was a human.  "); // Option 3:
                    story.Add("She takes you to the closest mall and dragging you from one store to the next all day long. You awake the next morning tired and sore but 2000 mells richer. "); // . [Go to option 1]
                    story.Add("As you reach for a weapon his mechanical nose shoots into your chest and rips your heart out. He screams “KALIMA!” as you die."); // Option 2:
                    story.Add("Game Over.");
                    story.Add("You run away from the Cyborg Ephantus in terror, hoping to never see them again. You rush into the slums knowing your so close to pet"); // Option 1
                    story.Add("As you head towards where THE MAN lands you see the busy main street full of beggars or a back alley that appears to bypass all of it.");
                    story.Add("What do you Do?");
                    story.Add("1.)	Take the main street."); // Options
                    story.Add("2.)	Take the alley.");
                    story.Add("You attempt to trudge past all the beggars without responding to them. A small female blue skinned humanoid with 2 small horns on her forehead and black bat wings on her back in a long brown shirt climbs onto your shoulder. "); // Option 1
                    story.Add("You recognize she is of the Lashtist race. She says mister “Where are you going? If I guide you there will you give me some food?” ");
                    story.Add("What will you do?");
                    story.Add("1.)	Say yes.");
                    story.Add("2.)	Tell her to scram.");
                    story.Add("She guides you to THE MAN’s ship, but you forgot Lashtist feed off the blood of other. She starts drinking your blood as you see THE MAN fly away."); // Option 1
                    story.Add("Game Over.");
                    story.Add("She flutters away sobbing about being hungry. Then you notice her start drinking the blood of another beggar in an alley. He becomes a mummy is 30 seconds. You just dodged a bullet."); // Continue where option 2 joins back in]
                    story.Add("As you begin walking through the alley, a small green humanoid with large pointy ears clutching what appears to be a butter knife runs into you. You recognize him as a Gobleen. "); // // Option 2
                    story.Add("He is short of breath as if he was running from something. He realizes you’re not a wall but a person and freaks out. He screams, “You will not take my precious!!” as he strokes his butter knife. "); // Fight
                    story.Add("As you leave beggar central you see THE MAN’s ship, but there is a massive gang war on the path to the ship"); // [Win, gain Holy Butter Knife and join back with option 1] ,[Lose, Game over.]
                    story.Add("What do you Do?");
                    story.Add("1.)	Fight your way through."); // Options:
                    story.Add("2.)	Attempt to sneak around.");
                    story.Add("3.)	Yell dumbbell fight!");
                    story.Add("You yell out and both gangs turn to you. You hear someone says, “wrong planet!” as a pizza flies toward you.  Its aroma attracts the local Flesh fleas. You are eaten alive by the fleas. "); // Option 3:
                    story.Add("Game Over.");
                    story.Add("As you attempt to sneak past the war grounds, a humanoid cyborg with no details to see his original race but a large ‘A’ on his chest confronts you. "); // Option 2:
                    story.Add("(Cyborg) \n “To whose allegiance do you claim?! Awesome or Metal?!” ");
                    story.Add("What do you Do?"); // Options
                    story.Add("1.)	Give item from inventory.");
                    story.Add("2.)	Answer with “Metal?”");
                    story.Add("3.)	Answer with “Awesome?”");
                    story.Add("4.)	[Fight]");
                    story.Add("Fight"); // Option 4: Go to option 1, fight through.
                    story.Add("(Cyborg) \n  “You dare say Metal Man is better?!?! To me, an Awesome Cyborg fan?!?!?! Be converted!!” "); //Option 2:
                    story.Add("He throws a helmet on you which forces you to watch ‘The Adventures of Awesome Cyborg’ on repeat for 3 weeks straight.");
                    story.Add("Awesome Cyborg is love; Awesome Cyborg is life. You join the gang with no self-will attempting to convert others to your cause.");
                    story.Add("Game Over.");
                    story.Add("(Cyborg \n “I see through you lies Metal Man spy!! There is no saving your kind!”"); // Option 3:
                    story.Add("He pulls out an anti-battleship cannon and vaporizes you. You are wiped from existence.");
                    story.Add("Game Over.");
                    story.Add("(Cyborg) \n  “You would give me this rare figurine of Awesome Cyborg?! There are only 10 in existence! I will cherish what you have given me! May you bring justice to the blind comrade!”"); //Option 1: // [If you give Awesome Cyborg Doll]
                    story.Add(""); // [Continue on to THE MAN’s ship]
                    story.Add("[Fight Random Enemy]"); // Option 1:
                    story.Add(""); // Win: [Fight Random Enemy]
                    story.Add(""); // Lose: Game Over.
                    story.Add(""); // Win Both: Continue on to THE MANS ship
                    story.Add("After scrapping through the warzone, you finally make it to THE MAN’s ship. Sadly, right as you approach the ship, the entry ramp raises up and the ship begins to leave. Over a speaker from the ship you hear THE MAN call out. ");
                    story.Add($"(THE MAN) \n “Muahahahaha!{pc.Name} you’re too slow. I’ve got everything I need to feats with {pc.PetName}. If you want to join us on Krytunga then be my guest!” He then speeds of into space");
                    story.Add("You know where this ends. Time to get pet back. You head back to your ship, setting coordinates for the planet of Krytunga, the crystal world.");
                    // End of Wombodum
                    return story;

                case PlanetTypes.Krytunga:
                    story.Add("Krytunga, the crystal planet");
                    story.Add("Finally, you land on the remote planet of Krytunga. This planet is said to be uninhabitable due only the planet’s unique crystals that grow here. ");
                    story.Add("As you circle the planet you notice what appears to be a fortress made from crystal. You notice that THE MAN’s ship is landed in the courtyard.");
                    story.Add($"({pc.Name}) \n “Found you, you ugly bastard!” you growl to yourself. ");
                    story.Add("You land just outside the fortress and get ready to face the music, you mean THE MAN. As you leave your ship, a crystal alien you’ve never heard or seen of before approaches you");
                    story.Add("He looks like a 3-foot humanoid with crystal skin. As he draws near, he begins to speak.");
                    story.Add("(Crystal Alien) \n “Yo homedog! Care to swap some sparkle spazzles?”");
                    story.Add("What do you Do?"); // Options
                    story.Add("1.)	Say “I guess?”");
                    story.Add("2.)	Say “Some what?!?”");
                    story.Add("3.)	Punt the crystal dwarf thing");
                    story.Add("4.)	Ignore and rush into the fortress");
                    story.Add("(Crystal Alien) \n “Cool! Here’s what I got flesh man!”"); // Option 1:
                    story.Add("1.)	Red Crystal/ price: 200 mells"); // Items Sold:[Go into Buy/Sell mode]
                    story.Add("2.)	Blue Crystal/ price: 200 mells");
                    story.Add("3.)	Green Crystal/ price: 200 mells");
                    story.Add("4.)	Leave");
                    story.Add("The crystal alien launches into the history of the planet and the local lingo. You attempt to leave several times, but he cuts you off every time."); // Option 2:
                    story.Add("He leaves no room to interrupt during his entire 8-year long lecture. Given no room to ever leave, you die from starvation 1 month into the lecture.");
                    story.Add("Game Over.");
                    story.Add("As your leg makes contact with the alien, it starts to move through him like swimming through honey. Before you can realize it, the alien has become your leg from the knee down"); // Option 3:
                    story.Add("His face disappears but now hear his voice in your head. Your otherwise fine and charge into the fortress mildly off balance."); // [Pick up with option 4]
                    story.Add("You charge into the fortress expecting to face THE MAN’s henchmen but find it empty. You rush through the halls until you come to a grand staircase going up to one massive door and another going down to an identical looking door."); // Option 4:
                    story.Add("What do you Do?"); // Options:
                    story.Add("1.)	Go up the stairs");
                    story.Add("2.)	Go down the stairs");
                    story.Add("As you climb down the stairs you take a deep breath before you fling the doors open. Astonished, you find not a throne room but what appears to be some sort of factory"); // Option 2:
                    story.Add("You wander to the edge of the observation platform to get a better look. ");
                    story.Add("As you stare out across the factory, it quickly becomes clear that this is where THE MAN creates the crystal aliens like the one that greeted you when you landed. As this dawns on you, you feel someone kick you from behind.");
                    story.Add("You fall over the railing into a vat of molten crystal in front of you. You’re able to turn your head before you fall in and see THE MAN cackling as he watches you die in the molten crystal.");
                    story.Add("Game Over");
                    story.Add("As you climb up the stairs you take a deep breath before you fling the doors open. You see THE MAN on a throne of crystal smiling down at you. "); // Option 1:
                    story.Add($"(THE MAN)\n  “Welcome {pc.Name}! I’ve been waiting for you. Can’t hold the grand party without you. Give me 5 more minutes and it will all be ready.”");
                    story.Add("What do you do?");
                    story.Add("1.)	Don’t wait and attack."); // Options
                    story.Add($"2.) Demand he give {pc.PetName} back.");
                    story.Add("3.)	Wait the 5 minutes.");
                    story.Add("You decide to wait to see what happens. More crystal aliens, similar to the one the greeted you start to bring in what appear to be party decorations"); // Option 3
                    story.Add("A table and chair are brought out for you to sit with a massive 7-layer cake is placed in front of you");
                    story.Add("The aliens start sing happy birthday to you, and THE MAN tells you to blow out the candles. You indulge them and blow out the candles");
                    story.Add("BOOOOOOOMMMM!!!!");
                    story.Add("The cake explodes the second you blow the candles out. You should have never trusted THE MAN, even if it was your birthday.");
                    story.Add("Game Over");
                    story.Add($"THE MAN stares a you confused. He goes on to tell you he never took {pc.PetName}; he just hid him in your ship’s exterior storage compartment. "); // Option 2:
                    story.Add("He goes on to say your birthday party will soon be ready and should stick around for it.");
                    story.Add($"Bewildered, you race out to your ship and check the exterior storage. Sure enough, the second you open it,{pc.PetName}leaps onto you and starts licking your face.");
                    story.Add("Overjoyed, the 2 of you go back onto your ship to float through the galaxy watching cartoons together. You don’t trust THE MAN with throwing any parties and just leave the planet.");
                    story.Add("As you start to leave atmosphere, you see THE MAN’s fortress explode. Glad to have trusted your gut, you and pet fly off on new adventures.");
                    story.Add($"Victory,{pc.Name} has got {pc.PetName} back!");
                    story.Add("Thanks for playing!"); // Game Done
                    story.Add("Shocked by your sudden attack, THE MAN throws out a yellow crystal that turns into 2-foot yellow crystal mouse."); // Option 1:
                    story.Add(""); // [Fight Mouse]
                    story.Add(""); // Win:
                    story.Add("(THE MAN) \n “Cursed knock-offs! I’ll just deal with you myself!”");
                    story.Add(""); // [Fight THE MAN]
                    story.Add(""); // Win:
                    story.Add($"After obliterating THE MAN, you run past the throne into what you assume was THE MAN’s room. There in a cage is {pc.PetName}.");
                    story.Add($"You quickly bust the lock and {pc.PetName} flies into your arms, licking your face. Finally, you and {pc.PetName} can get back to your primary mission, watching all the galaxy’s cartoons ever created!");
                    story.Add($"Victory,{pc.Name} has got {pc.PetName} back!");
                    story.Add("Thanks for playing!"); // Game Done
                    //End of Krytunga
                    return story;

                default:
                    return Story;
            }
        }
    }
}