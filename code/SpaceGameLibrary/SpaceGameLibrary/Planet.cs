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

        public bool AccessStore(Player pc, List<Item> storeInventory, string selection)
        {

            switch(selection)
            {
                case "Auto Chopper":
                    if(storeInventory.Exists(item => item.Name == selection))
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
                    item6.Quantity = 20;
                    item6.Value = 250;
                    this.StoreInventory.Add(item6);
                    Item item7 = new Item();
                    item7.Name = "45 lbs plate";
                    item7.Quantity = 3;
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

        public string[] Story()
        {
            throw new System.NotImplementedException();
        }
    }
}