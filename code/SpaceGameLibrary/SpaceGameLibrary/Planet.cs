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
                case "Jungle Starter Kit":
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
                case "Schlemal Doll":
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

                case "Green Remote":
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

                case "20 lb Dumbbells":
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

                case "45 lb Plate":
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

                case "OFF Protein":
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

                case "Animal Energy Powder":
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

                case "The Claw":
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

                case "Purple Remote":
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

                case "Awesome Cyborg Doll":
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

                case "Laser Sword":
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

                case "Red Crystal":
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

                case "Green Crystal":
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

        public bool Sell(Player pc, string selection)
        {
            switch (selection)
            {
                case "The D.A.V.E.":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Blitz Blade":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Shield o' Saturn":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Plutonian Plasma Rifle":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Auto Chopper":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Jungle Starter Kit":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Schlemal Doll":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Green Remote":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "20 lb Dumbbells":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "45 lb Plate":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "OFF Protein":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Animal Energy Powder":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "The Claw":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Purple Remote":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Awesome Cyborg Doll":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Laser Sword":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Red Crystal":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Blue Crystal":
                    if (pc.Inventory.Exists(item => item.Name == selection))
                    {
                        pc.Currency += pc.Inventory.Find(item => item.Name == selection).Value;
                        pc.Inventory.Remove(pc.Inventory.Find(item => item.Name == selection));
                        return true;
                    }
                    else return false;
                case "Green Crystal":
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
                case PlanetTypes.Noir:
                    Item theDAVE = new Item();
                    theDAVE.Name = "The D.A.V.E.";
                    theDAVE.Quantity = 1;
                    theDAVE.Value = 5;
                    theDAVE.Damage = 10000;
                    inventory.Add(theDAVE);
                    Item blitzBlade = new Item();
                    blitzBlade.Name = "Blitz Blade";
                    blitzBlade.Quantity = 1;
                    blitzBlade.Value = 200;
                    blitzBlade.Damage = 3;
                    inventory.Add(blitzBlade);
                    Item shieldOSaturn = new Item();
                    shieldOSaturn.Name = "Shield o' Saturn";
                    shieldOSaturn.Quantity = 1;
                    shieldOSaturn.Value = 200;                    
                    inventory.Add(shieldOSaturn);
                    Item plasmaRifle = new Item();
                    plasmaRifle.Name = "Plutonian Plasma Rifle";
                    plasmaRifle.Quantity = 1;
                    plasmaRifle.Value = 200;
                    plasmaRifle.Damage = 4;
                    inventory.Add(plasmaRifle);
                    return inventory;
                case PlanetTypes.Aventus:
                    Item autoChopper = new Item();
                    autoChopper.Name = "Auto Chopper";
                    autoChopper.Quantity = 1;
                    autoChopper.Value = 150;
                     autoChopper.Damage = 15;
                    inventory.Add(autoChopper);
                    Item jungleStarterKit = new Item();
                    jungleStarterKit.Name = "Jungle Starter Kit";  //does nothing 
                    jungleStarterKit.Quantity = 1;
                    jungleStarterKit.Value = 300;
                    inventory.Add(jungleStarterKit);
                    Item schlemalDoll = new Item();
                    schlemalDoll.Name = "Schlemal Doll"; //does nothing
                    schlemalDoll.Quantity = 1;
                    schlemalDoll.Value = 50;
                    inventory.Add(schlemalDoll);
                    Item greenRemote = new Item();
                    greenRemote.Name = "Green Remote"; //transports dog you win
                    greenRemote.Quantity = 1;
                    greenRemote.Value = 200;
                    inventory.Add(greenRemote);
                    return inventory;
                case PlanetTypes.SpotMee:
                    Item twLbDumbbells = new Item();
                    twLbDumbbells.Name = "20 lb Dumbbells"; // a consumable
                    twLbDumbbells.Quantity = 1;
                    twLbDumbbells.Value = 250;
                    inventory.Add(twLbDumbbells);
                    Item ftFiveLbPlate = new Item();
                    ftFiveLbPlate.Name = "45 lb Plate";
                    ftFiveLbPlate.Quantity = 1;
                    ftFiveLbPlate.Value = 50;
                    ftFiveLbPlate.Damage = 45;
                    inventory.Add(ftFiveLbPlate);
                    Item offProtein = new Item();
                    offProtein.Name = "OFF Protein";  //blocks 4 rounds
                    offProtein.Quantity = 1;
                    offProtein.Value = 400;
                    inventory.Add(offProtein);
                    Item animalEnergyPowder = new Item();
                    animalEnergyPowder.Name = "Animal Energy Powder"; //doubles damage
                    animalEnergyPowder.Quantity = 1;
                    animalEnergyPowder.Value = 150;
                    inventory.Add(animalEnergyPowder);
                    return inventory;
                case PlanetTypes.Wombodum:
                    Item theClaw = new Item();
                    theClaw.Name = "The Claw";
                    theClaw.Quantity = 1;
                    theClaw.Value = 600;
                    theClaw.Damage = 20;
                    inventory.Add(theClaw);
                    Item purpleRemote = new Item();
                    purpleRemote.Name = "Purple Remote"; //transports THE MAN start the fight
                    purpleRemote.Quantity = 1;
                    purpleRemote.Value = 200;
                    inventory.Add(purpleRemote);
                    Item cyborgDoll = new Item();
                    cyborgDoll.Name = "Awesome Cyborg Doll"; // does nothing
                    cyborgDoll.Quantity = 1;
                    cyborgDoll.Value = 350;
                    inventory.Add(cyborgDoll);
                    Item laserSword = new Item();
                    laserSword.Name = "Laser Sword";
                    laserSword.Quantity = 1;
                    laserSword.Value = 400;
                    laserSword.Damage = 10;
                    inventory.Add(laserSword);
                    return inventory;
                case PlanetTypes.Krytunga:
                    Item redCrystal = new Item();
                    redCrystal.Name = "Red Crystal"; //summons something
                    redCrystal.Quantity = 1;
                    redCrystal.Value = 200;
                    inventory.Add(redCrystal);
                    Item blueCrystal = new Item();
                    blueCrystal.Name = "Blue Crystal"; // summons something
                    blueCrystal.Quantity = 1;
                    blueCrystal.Value = 200;
                    inventory.Add(blueCrystal);
                    Item greenCrystal = new Item();
                    greenCrystal.Name = "Green Crystal"; // summons something
                    greenCrystal.Quantity = 1;
                    greenCrystal.Value = 200;
                    inventory.Add(greenCrystal);
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
                    /*0*/story.Add("(Narrator)\n\nOn a Cold desolate night on Planet Noir, our hero comes to, unaware of the adventure that awaits....");
                    /*1*/story.Add($"(Narrator)\n\nSlowly your eyes open,the emergency beacon on your ship is beaming. How you didn't notice sooner is a mystery, because your ship's security system is blaring a name... {pc.Name.ToUpper()}!!!!");
                    /*2*/story.Add($"(Ship Security system)\n\nGreetings {pc.Name}..... Unknown perpetrator onboard during personnel stasis. Current lifeforms present:  1");
                    /*3*/story.Add($"({pc.Name} inner dialogue)\n\nOnly one??? Could there be someone on here that is missing? *You stand up to look around for clues.*");
                    /*4*/story.Add("Perplexed by mystery, you're faced with a dilemma."); // start of Scenario switch statement for Planet Noir choices
                    /*5*/story.Add("1) Ask security protocols who was on the ship\n\n2) Follow footprints leading outside the ship\n\n3) Grab an Astrocola and watch cartoons\n\n4) Tell the ship security protocols to initiate defense level BAMBAM\n\n\n\nWhat do you do?\n");
                    /*6*/story.Add($"(Ship security protocol)\n\nKnown fugitive known as THE MAN entered and left with {pc.PetName}"); // Scenario 1
                    /*7*/story.Add($"You remember now! Your dog, {pc.PetName}, is gone!!! THE MAN must pay!!!!");
                    /*8*/story.Add("You grab the nearest item to you and man your ship speeding off towards the next planet to find him."); // item if statement start
                    /*9*/story.Add("1) The Blitz Blade\n2) The Shield o' Saturn\n3) The Plutonian Plasma Rifle\n\nWhich item will you grab?\n"); // Add the blitz blade item // Add the shield o saturn item// Add the plasma rifle item
                    /*10*/story.Add("Angry and disoriented, you run to the ship door slamming on the hatch button, suddenly you're sucked out into orbit.");  // Scenario 2
                    /*11*/story.Add("Due to you being on another planet without an atmosphere, the oxygen is sucked out of you like Douglas Quaid in that movie TOTAL RECALL.");
                    /*12*/story.Add("Nice job there guy!");
                    /*13*/story.Add("Leisurely you motion towards the fridge to grab a ice cold Astrocola and notice the key behind it."); // Scenario 3 ADD the DAVE
                    /*14*/story.Add("What a dumb place to hide your Deatomizing Assault Vulcan Emitter cannon (aka The D.A.V.E)!  After collecting your trusty D.A.V.E. you decide you should probably figure out what happened here, so you ask the ship security protocols who was on the ship.");
                    /*15*/story.Add("Paranoid that THE MAN is still onboard your ship you scream to the ship security system to go level BAMBAM!!");  // Scenario 4
                    /*16*/story.Add("In an instant you proceed to get turned into swiss cheese by the turrets on the ship. THE MAN tricked you and sabotaged the weapon system. Nice job there guy!");
                    // End of Noir
                    return story;

                case PlanetTypes.Aventus:
                    /*0*/story.Add($"Ship scanners showed THE MAN’s ship landing on the planet Aventus. It's uncertain what he landed here to do, but we shall find out!");
                    /*1*/story.Add("After dodging the freight ships during your approach, you land on platform 934 after getting clearance from the port officials.");
                    /*2*/story.Add("You see what looks like an ostrich in a tuxedo walking towards you. In a shrill voice the call out to you.");
                    /*3*/story.Add("(Carlsin):\nGreetings traveler, I am Carlsin, a dock supervisor here at Aventus. Who are you and what is your reason for being here?\n"); // start options switch statement
                    /*4*/story.Add("1) Give what Carlsin asked.\n\n2) Refuse to answer and shove past.\n\n3) Ask if he is an ostrich.\n\n4) See inventory/Equip an item.\n\n5) See Stats\n\nWhat will you do?\n");
                    /*5*/story.Add($"You say that you’re {pc.Name} and are looking for a human called THE MAN."); // Scenario 1
                    /*6*/story.Add("(Carlsin)\n “I don’t know who this man is but we did have a ship illegally land at lumber yard 67. I wouldn’t suggest going there since going there by yourself though.");
                    /*7*/story.Add("The site was recently taken over by a young manticore. I’d stop by Frig&Horges in the marketplace if you plan to still go there. They have all the gear you might need to brave the jungle.");
                    /*8*/story.Add("You shove Carlsin causing him to fall off the landing platform. He becomes a new hood ornament for a freight ship leaving planet. You wander into town looking for information."); // Scenario 2
                    /*9*/story.Add("You ask him and immediately see him start to tremble. He screeches as he charges towards you. Before you can react, his beak opens wider than you think possible and bites your head off."); // Scenario 3
                    /*10*/story.Add("Nice job there guy!");
                    /*11*/story.Add("You come to a crossroad with a sign pointing to several different places."); // Crossroads switch statement
                    /*12*/story.Add("1) Go to marketplace\n\n2) Go to jungle\n\n3) Attempt to ride one of the local Schlemals(Carlsin’s race)\n\n4) See inventory.\n\nWhat will you do?\n");
                    /*13*/story.Add("You go to the marketplace and see a store called Frig&Horge.You enter and ask the clerk if you can sell things here. They say yes.");
                    /*14*/story.Add("1) Buy items\n\n2) Sell items\n\n3) See inventory\n\n4) See stats\n\n5) Leave\n\nWhat would you like to do?\n"); // Market options
                    /*15*/story.Add("1)	Auto Chopper____Price 150 Mells\n\n2)	Jungle Starter Kit_____Price 300 Mells\n\n3)	Schlemal Doll______Price 50 Mells\n\n4)	Green Remote_____Price 200 Mells\n\n5)	Leave\n\nWhat will you do?\n"); // Sub-options 2
                    /*16*/story.Add("1) Show PC inventory with prices\n\n2) Leave\n\nWhat will you do?\n"); // Sub-Option 3
                    /*17*/story.Add("You sneak up on a Schlemal and right as it notices you, you leap onto its back. It leaps into the air and dunks the both of you into a tree compressor. You become an ambassador’s new table.");
                    /*18*/story.Add("Nice job there Guy!");
                    /*19*/story.Add($"You head into the jungle in hopes of finding THE MAN and {pc.PetName}. After trudging through the jungle, the path splits into 2.");
                    /*20*/story.Add("1)	Take the right path\n\n2)	Take the left path\n\n3)	Check inventory\n\n4)	Check stats.\n\nWhat will you do?\n");
                    /*21*/story.Add("As you continue down the right path, you smell something sweet from a large flower. As you stop to smell the flower, it lunges out and eats the top half of you."); // Option 1
                    /*22*/story.Add("Nice job there guy!");
                    /*23*/story.Add("You come upon lumber yard 67. As you arrive, you see a ship that you don’t recognize fly away. It is much sleeker then the local freight ships.THE MAN has got away!!"); // Option 2
                    /*24*/story.Add("You then hear a mewl from the yard. A kitten with red fur, a small horn, and bat wings trots over to you carrying a star-map data stick.");
                    /*25*/story.Add("1) feed the manticore\n\n2) kick the cat thing.\n\n3) Run back to ship.\n\nWhat will you do?\n");
                    /*26*/story.Add("You kick the cat with wings causing it to drop the star-map data stick. As you bend over to pick it up you hear another mewl."); //  Option 2
                    /*27*/story.Add("Right as your hand touches the data stick, you get engulfed in flames. All that is left is ashes.");
                    /*28*/story.Add("Nice job there guy!");
                    /*29*/story.Add("You give the manticore cub some of your food. It greedily devours the food and your hand. It starts to purr and won’t leave you alone."); // Option 1
                    /*30*/story.Add("You lost a hand but gained a manticore companion.With the data chip and your new companion, you rush back to your ship and chase after THE MAN.");
                    /*31*/story.Add("You rush back through the jungle in hope that you can get to the ship in time. As you arrive, you power it on and check to see if there are any traces of the ship that just left.");
                    /*32*/story.Add("You’re in luck! You take off from the landing pad, sending several Schlemals to their death and chase after THE MAN.");
                    // End of Aventus
                    return story;

                case PlanetTypes.SpotMee:
                    /*0*/story.Add("You are at planet SpotMee and land in the capital city, Brotopia. THE MAN is definitely here, but the city is large and filled with gladiator rings.");
                    /*1*/story.Add("As you start to walk towards the city, an AD bot starts screaming its ad in your face.");
                    /*2*/story.Add("(ad bot)\n Come on down!come on down! Come one, come all to the Guilds Gym Arena! Legendary boss, THE MAN!, challenges all to come fight to take his fortune! Can any claim his Mells?!?!?!” ");
                    /*3*/story.Add("1) Go to the Marketplace.\n\n2) Go to Guilds Gym Arena.\n\n3)	Check inventory.\n\n4)	Check stats.\n\nWhat do you do?\n");
                    /*4*/story.Add("As you wander down the marketplace, you see a store called, DO YOU EVEN LIFT. You decide to shop there."); // Option 1
                    /*5*/story.Add("1) Buy.\n\n2) Sell.\n\n3)	Leave.\n\nWhat will you do?\n");
                    /*6*/story.Add("Unavailable at this time :(");   /*("1) 20lbs Dumbbell/ qty: 20 price: 250 mells\n\n2) 45lbs Plate/ qty: 3 price: 50 mells3) OFFs Protein/ price: 400 mells\n\n4)	Animal Energy Powder/ price: 150 mells\n\n5) Leave.\n\nWhat will you do?\n");*/ //"Shop Items to buy
                    /*7*/story.Add("You run off towards Guilds Gym Arena, the AD bot blaring the same ad the whole way. When you arrive to the arena you see a line with various aliens hoping to win THE MAN’s fortune."); // Option 2
                    /*8*/story.Add("When you finally get to the front you recognize an Orgus by its big green pig head with tusk shooting out. He has a name tag that reads Daisy.");
                    /*9*/story.Add("(Daisy)\nin a deep gruff voice he asks,“Arena name and race?\n”");
                    /*10*/story.Add("1) Give new name for arena fights.\n\n2) Give your name for arena fights.\n\n3) Ask Daisy about name.\n\n4) Mock Daisy for name.\n\nWhat will you do?\n"); // Options
                    /*11*/story.Add("You laugh at Daisy for being named after a weak Earth flower. Daisy roars over being mocked, “Daisy is greatest warrior name from Orgus home world!!! Puny human shall die!”"); // Option 4
                    /*12*/story.Add("He slams his hand down on a button on his desk causing the floor below you to disappear. You fall into a pit of boiling oil becoming Daisy’s snack for the arena matches later.");
                    /*13*/story.Add("Nice job there guy!");
                    /*14*/story.Add("You give Daisy your name and he explains that you must win the 3 rounds in order to win THE MAN’s tournament. As you enter the arena for the first round a voice over the louder speakers come on."); // Option 2
                    /*15*/story.Add($"“Cooooontestants!!! There has been a change for the first round! Instead of the traditional Brotopia dumbbell fight, whoever kills {pc.Name},the only human here, will win the tournament!!!” ");
                    /*16*/story.Add("All the contestants turn toward you and before anyone else can jump you, an Orgus jumps from the stands and turns you into a pancake.");
                    /*17*/story.Add("Nice job there guy!");
                    /*18*/story.Add("Daisy tells you he was named after the greatest warrior in Orgus history. You marvel in wonder at the name. Daisy says he likes you and says if you enter the red door over there, you can skip to the final round."); // Option 3
                    /*19*/story.Add("Welcome contestants!! The first round shall be the traditional Dumbbell fight! Ready, Go!");
                    /*20*/story.Add("You look around and see everyone pulling out dumbbells and throwing them like snowballs.");
                    /*21*/story.Add("1) Access Inventory.\n\n2)	Dodge and hope to pick up stray dumbbells.\n\n3) Cower in a corner.\n\n4)	Run around the arena screaming.\n\nWhat will you do?\n"); // Options //[Everything but dumbbells fails and sends back to original options]
                    /*22*/story.Add("“You survived the round and moved on.”"); // If dumbbells used.
                    /*23*/story.Add("You attempt to dodge the incoming dumbbells but get hit in the head crushing it.");
                    /*24*/story.Add("Nice job there guy!");
                    /*25*/story.Add("You run to the corner of the circular arena and cower in the fetal position. After 10 mins of fight, you hear victory! You’re on of the 5 finalists. Move on to round 2"); // Option 3
                    /*26*/story.Add("You start screaming as you run around. You forget to breath properly and pass out after 10 mins. You awake with round 2 under way but a giant horned lizard having eaten your legs."); // Option 4
                    /*27*/story.Add("A little low on that food chain now my guy!");
                    /*28*/story.Add("(Announcer)\n “Champions moving on to round 2! You shall face one of our beasts we have in our arena. When called, come face your beast!”"); // Round 2
                    /*29*/story.Add("The first 2 contestants both quickly get eaten, making you nervous.");
                    /*30*/story.Add("(Announcer) \n THE MAN shall greet the champion!"); // Fight {random Enemy} Win move on , lose Game Over // Round 3:
                    /*31*/story.Add("THE MAN walks out to greet you but freezes when he sees you. He screams for them to release another beast as he runs away.");
                    /*32*/story.Add("You chase after THE MAN barely making it to your ship before you see his ship leave atmosphere. You follow after him in the ship."); // Fight [Random Enemy] [Win move on, lose Game over]
                    // End of SpotMee
                    return story;

                case PlanetTypes.Wombodum:
                    /*0*/story.Add("You chase THE MAN to Wumbodom. \n \nThe whole planet is one giant city and THE MAN went straight to land in the slums of the planet");
                    /*1*/story.Add("With your larger ship, you can’t fit in where he landed, so you land on the roof of one of the outlying towers. As you climb down the building, you see a store called Wumbohex. ");
                    /*2*/story.Add("1) Shop\n\n2) Leave the tower.\n\n3) Check Inventory.\n\n4) Check Stats\n\nWhat will you do?\n"); // Options
                    /*3*/story.Add("Unavailable at this time :(");   /*("1) The Claw/ price: 600 mells.\n\n2) Purple Remote/ price: 200 mells.\n\n3) Awesome Cyborg Doll/ price: 350 mells.\n\n4)	Laser Sword/ price: 400 mells.\n\n5) Leave.\n\nWhat will you do?\n");*/ // Shop buy options
                    /*4*/story.Add("You race down the rest of the tower and as you exit you bump into a cyborg Ephantus, an Elephant man race. He turns and stares at you with his red robotic eye.");
                    /*5*/story.Add("1) Apologize and run away.\n\n2) Attempt to fight.\n\n3) Ask if they wanna go.\n\nWhat do you do?\n"); // Options
                    /*6*/story.Add("You ask the Ephantus and found it he is a she. She says she is Klarice and was surprise her hired date was a human."); // Option 3:
                    /*7*/story.Add("She takes you to the closest mall and dragging you from one store to the next all day long. You awake the next morning tired and sore but 2000 mells richer. "); // . [Go to option 1]
                    /*8*/story.Add("As you reach for a weapon his mechanical nose shoots into your chest and rips your heart out. \n \n He screams “KALIMA!” as you die."); // Option 2:
                    /*9*/story.Add("Nice job there guy!");
                    /*10*/story.Add($"You run away from the Cyborg Ephantus in terror, hoping to never see them again. \n You rush into the slums knowing your so close to {pc.PetName}");  // Option 1
                    /*11*/story.Add("As you head towards where THE MAN lands you see the busy main street full of beggars or a back alley that appears to bypass all of it.");
                    /*12*/story.Add("1) Take the main street.\n\n2) Take the alley.\n\n3) Check Inventory.\n\n4) Check Stats\n\nWhat do you do?\n");
                    /*13*/story.Add("You attempt to trudge past all the beggars without responding to them. A small female blue skinned humanoid with 2 small horns on her forehead and black bat wings on her back in a long brown shirt climbs onto your shoulder. "); // Option 1
                    /*14*/story.Add("You recognize she is of the Lashtist race. \nShe says mister “Where are you going? If I guide you there will you give me some food?” ");
                    /*15*/story.Add("1)	Say yes.\n\n2)	Tell her to scram.\n\nWhat will you do?\n");
                    /*16*/story.Add("She guides you to THE MAN’s ship, but you forgot Lashtist feed off the blood of other. She starts drinking your blood as you see THE MAN fly away."); // Option 1
                    /*17*/story.Add("Nice job there Guy!");
                    /*18*/story.Add("She flutters away sobbing about being hungry. Then you notice her start drinking the blood of another beggar in an alley. He becomes a mummy is 30 seconds. You just dodged a bullet."); // Continue where option 2 joins back in]
                    /*19*/story.Add("As you begin walking through the alley, a small green humanoid with large pointy ears clutching what appears to be a butter knife runs into you. You recognize him as a Gobleen. "); // // Option 2
                    /*20*/story.Add("He is short of breath as if he was running from something. He realizes you’re not a wall but a person and freaks out. He screams, “You will not take my precious!!” as he strokes his butter knife. "); // Fight
                    /*21*/story.Add("As you leave beggar central you see THE MAN’s ship, but there is a massive gang war on the path to the ship"); // [Win, gain Holy Butter Knife and join back with option 1] ,[Lose, Game over.]
                    /*22*/story.Add("1) Fight your way through.\n\n2) Attempt to sneak around.\n\n3) Yell dumbbell fight!\n\n4) Check Inventory.\n\n5) Check Stats\n\nWhat do you do?\n"); // Options:
                    /*23*/story.Add("You yell out and both gangs turn to you. You hear someone says, “wrong planet!” as a pizza flies toward you.  Its aroma attracts the local Flesh fleas. You are eaten alive by the fleas. "); // Option 3:
                    /*24*/story.Add("Nice job there guy!");
                    /*25*/story.Add("As you attempt to sneak past the war grounds, a humanoid cyborg with no details to see his original race but a large ‘A’ on his chest confronts you. "); // Option 2:
                    /*26*/story.Add("(Cyborg) \n “To whose allegiance do you claim?! Awesome or Metal?!\n” ");
                    /*27*/story.Add("1) Give item from inventory.\n\n2)	Answer with “Metal?”\n\n3)	Answer with Awesome?\n\n4)	[Fight]\n\nWhat do you Do?\n");  // Option 4: Go to option 1, fight through.
                    /*28*/story.Add("(Cyborg) \n “You dare say Metal Man is better?!?! To me, an Awesome Cyborg fan?!?!?! Be converted!!” "); //Option 2:
                    /*29*/story.Add("He throws a helmet on you. \nIt forces you to watch ‘The Adventures of Awesome Cyborg’ on repeat for 3 weeks straight.");
                    /*30*/story.Add("Awesome Cyborg is love; \nAwesome Cyborg is life. \nYou join the gang with no self-will attempting to convert others to your cause.");
                    /*31*/story.Add("Way to follow the sheep there guy!");
                    /*32*/story.Add("(Cyborg) \n“I see through you lies Metal Man spy!! There is no saving your kind!”"); // Option 3:
                    /*33*/story.Add("He pulls out an anti-battleship cannon and vaporizes you.You are wiped from existence.");
                    /*34*/story.Add("Battleship's not your game there guy!");
                    /*35*/story.Add("(Cyborg) \n “You would give me this rare figurine of Awesome Cyborg?! There are only 10 in existence! I will cherish what you have given me! May you bring justice to the blind comrade!”"); //Option 1: // [If you give Awesome Cyborg Doll]
                    /*36*/story.Add(""); // [Continue on to THE MAN’s ship]
                    /*37*/story.Add("[Fight Random Enemy]"); // Option 1:
                    /*38*/story.Add(""); // Win: [Fight Random Enemy]
                    /*39*/story.Add(""); // Lose: Game Over.
                    /*40*/story.Add(""); // Win Both: Continue on to THE MANS ship
                    /*41*/story.Add("After scrapping through the warzone, you finally make it to THE MAN’s ship. \n \nSadly, right as you approach the ship, the entry ramp raises up and the ship begins to leave. \n \nOver a speaker from the ship you hear THE MAN call out. ");
                    /*42*/story.Add($"(THE MAN)\n “Muahahahaha!{pc.Name} you’re too slow. I’ve got everything I need to feast with {pc.PetName}. \n \nIf you want to join us on Krytunga then be my guest!” He then speeds off into space");
                    /*43*/story.Add($"You know where this ends. Time to get {pc.PetName} back. \n \nYou head back to your ship, setting coordinates for the planet of Krytunga, the crystal world.");
                    // End of Wombodum
                    return story;

                case PlanetTypes.Krytunga:
                     /*0*/story.Add("Krytunga, the crystal planet");
                     /*1*/story.Add("Finally, you land on the remote planet of Krytunga. This planet is said to be uninhabitable due only the planet’s unique crystals that grow here.");
                     /*2*/story.Add("As you circle the planet you notice what appears to be a fortress made from crystal. You notice that THE MAN’s ship is landed in the courtyard.");
                     /*3*/story.Add($"({pc.Name}) \n “Found you, you ugly bastard!” you growl to yourself.");
                     /*4*/story.Add("You land just outside the fortress and get ready to face the music... \n \n \nyou mean THE MAN. \n \nAs you leave your ship, a crystal alien you’ve never heard of or seen before approaches you");
                     /*5*/story.Add("He looks like a 3-foot humanoid with crystal skin. As he draws near, he begins to speak.");
                     /*6*/story.Add("(Crystal Alien) \n “Yo homedog! Care to swap some sparkle spazzles?\n”");
                     /*7*/story.Add("1) Say I guess?\n\n2) Say “Some what?!?\n\n 3) Punt the crystal dwarf thing.\n\n4) Ignore and rush into the fortress.\n\n5) Check Inventory.\n\n6) Check Stats\n\nWhat do you do?"); // Options
                     /*8*/story.Add("(Crystal Alien) \n “Cool! Here’s what I got flesh man!”"); // Option 1:
                     /*9*/story.Add("Unavailable at this time :(");   //*"1) Red Crystal/ price: 200 mells.\n\n2) Blue Crystal/ price: 200 mells.\n\n3)	Green Crystal/ price: 200 mells\n\n4) Leave.\n\nWhat will you do?\n");*/ // Items Sold:[Go into Buy/Sell mode]
                     /*10*/story.Add("The crystal alien launches into the history of the planet and the local lingo. You attempt to leave several times, but he cuts you off every time."); // Option 2:
                     /*11*/story.Add("He leaves no room to interrupt during his entire 8-year long lecture. Given no room to ever leave, you die from starvation 1 month into the lecture.");
                     /*12*/story.Add("Should've brought a snack pak there guy!");
                     /*13*/story.Add("As your leg makes contact with the alien, it starts to move through him like swimming through honey. Before you can realize it, the alien has become your leg from the knee down"); // Option 3:
                     /*14*/story.Add("His face disappears but now hear his voice in your head. Your otherwise fine and charge into the fortress mildly off balance."); // [Pick up with option 4]
                     /*15*/story.Add("You charge into the fortress expecting to face THE MAN’s henchmen but find it empty. \n \nYou rush through the halls until you come to a grand staircase going up to one massive door and another going down to an identical looking door."); // Option 4:
                     /*16*/story.Add("1)  Go up the stairs.\n\n2)  Go down the stairs. \n\n5)  Check Inventory.\n\n6)  Check Stats \n\nWhat do you do?\n");
                     /*17*/story.Add("As you climb down the stairs you take a deep breath before you fling the doors open. \n \nAstonished, you find not a throne room but what appears to be some sort of factory"); // Option 2:
                     /*18*/story.Add("You wander to the edge of the observation platform to get a better look.");
                     /*19*/story.Add("As you stare out across the factory, \n \nit quickly becomes clear that this is where THE MAN creates the crystal aliens like the one that greeted you when you landed. \n \nAs this dawns on you, you feel someone kick you from behind.");
                     /*20*/story.Add("You fall over the railing into a vat of molten crystal in front of you. \n \nYou’re able to turn your head before you fall in and see THE MAN cackling as he watches you die in the molten crystal.");
                     /*21*/story.Add("Nice job there guy!");
                     /*22*/story.Add("As you climb up the stairs you take a deep breath before you fling the doors open. You see THE MAN on a throne of crystal smiling down at you. "); // Option 1:
                     /*23*/story.Add($"(THE MAN)\n “Welcome {pc.Name}! I’ve been waiting for you. Can’t hold the grand party without you. Give me 5 more minutes and it will all be ready.”");
                     /*24*/story.Add($"1) Don’t wait and attack.\n\n2) Demand he give {pc.PetName} back.\n\n3) Wait the 5 minutes.\n\nWhat do you do?\n"); // Options
                     /*25*/story.Add("You decide to wait to see what happens. More crystal aliens, similar to the one the greeted you start to bring in what appear to be party decorations"); // Option 3
                     /*26*/story.Add("A table and chair are brought out for you to sit, with a massive 7-layer cake is placed in front of you");
                     /*27*/story.Add("The aliens start sing happy birthday to you, and THE MAN tells you to blow out the candles. \n \nYou indulge them and blow out the candles.....");
                     /*28*/story.Add("BOOOOOOOMMMM!!!!");
                     /*29*/story.Add("The cake explodes the second you blow the candles out. You should have never trusted THE MAN, even if it was your birthday.");
                     /*30*/story.Add("How'd that wish turn out there guy?!");
                     /*31*/story.Add($"THE MAN stares a you confused. He goes on to tell you he never took {pc.PetName} \n \nHe just hid him in your ship’s exterior storage compartment."); // Option 2:
                     /*32*/story.Add("He goes on to say your birthday party will soon be ready and should stick around for it.");
                     /*33*/story.Add($"Bewildered, you race out to your ship and check the exterior storage. \n \nSure enough, the second you open it,{pc.PetName}leaps onto you and starts licking your face.");
                     /*34*/story.Add("Overjoyed, the 2 of you go back onto your ship to float through the galaxy watching cartoons together. \n \nYou don’t trust THE MAN with throwing any parties and just leave the planet.");
                     /*35*/story.Add($"As you start to leave atmosphere, you see THE MAN’s fortress explode. \n \nGlad to have trusted your gut, you and {pc.PetName} fly off on new adventures.");
                     /*36*/story.Add($"Victory!!! \n \n \n{pc.Name} has got {pc.PetName} back!");
                     /*37*/story.Add("!!!Thanks for playing!!!"); // Game Done
                     /*38*/story.Add("Shocked by your sudden attack, THE MAN throws out a yellow crystal that turns into 2-foot yellow crystal mouse."); // Option 1:
                     /*39*/story.Add(""); // [Fight Mouse]
                     /*40*/story.Add(""); // Win:
                     /*41*/story.Add("(THE MAN) \n “Cursed knock-offs! I’ll just deal with you myself!”");
                     /*42*/story.Add(""); // [Fight THE MAN]
                     /*43*/story.Add(""); // Win:
                     /*44*/story.Add($"After obliterating THE MAN, you run past the throne into what you assume was THE MAN’s room. \nThere in a cage is {pc.PetName}.");
                     /*45*/story.Add($"You quickly bust the lock and {pc.PetName} flies into your arms, licking your face. \nFinally, you and {pc.PetName} can get back to your primary mission, \nwatching all the galaxy’s cartoons ever created!");
                     /*46*/story.Add($"Victory,{pc.Name} has got {pc.PetName} back!");
                     /*47*/story.Add("Thanks for playing!"); // Game Done
                    //End of Krytunga
                    return story;

                default:
                    return Story;
            }
        }
    }
}