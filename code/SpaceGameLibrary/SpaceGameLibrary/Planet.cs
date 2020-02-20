using System;
using System.Collections.Generic;
using System.Text;
using static SpaceGameLibrary.Enumerations;

namespace SpaceGameLibrary
{
    public class Planet
    {
        public string Name
        {
            get => default;
            set
            {
            }
        }
        public PlanetTypes PlanetType { get; set; }
        public List<Item> WeaponsList { get; set; }
        public Planet(PlanetTypes planet)
        { 
            this.PlanetType = planet;
            this.WeaponsList = new List<Item>();
            AssignWeapons();
        }

        public string Objective
        {
            get => default;
            set
            {
            }
        }

        public array Story()
        {
            throw new System.NotImplementedException();
        }

        public bool AccessStore(Player pc)
        {
            
            //switch()
            //{
            //    case "Auto chopper":
            //        return
            //}
            throw new System.NotImplementedException();
        }

        public bool Combat(Player pc, BattleEntity enemy, BattleEntity ally)
        {
            throw new System.NotImplementedException();
        }
        private void AssignWeapons()
        {
            switch(this.PlanetType)
            {
                case PlanetTypes.Aventus:
                    Item itemone = new Item();
                    itemone.Name = "Auto Chopper";
                    itemone.Quantity = 1;
                    itemone.Value = 150;
                    this.WeaponsList.Add(itemone);
                    Item itemtwo = new Item();
                    itemtwo.Name = "Jungle starter kit";
                    itemtwo.Quantity = 1;
                    itemtwo.Value = 300;
                    this.WeaponsList.Add(itemtwo);
                    Item itemthree = new Item();
                    itemthree.Name = "Schlemal doll";
                    itemthree.Quantity = 1;
                    itemthree.Value = 50;
                    this.WeaponsList.Add(itemthree);
                    Item itemfour = new Item();
                    itemfour.Name = "Green remote";
                    itemfour.Quantity = 1;
                    itemfour.Value = 200;
                    this.WeaponsList.Add(itemfour);
                    break;
                case PlanetTypes.SpotMee:
                    Item itemsix = new Item();
                    itemsix.Name = "20 lbs Dumbbells";
                    itemsix.Quantity = 20;
                    itemsix.Value = 250;
                    this.WeaponsList.Add(itemsix);
                    Item itemsev = new Item();
                    itemsev.Name = "45 lbs plate";
                    itemsev.Quantity = 3;
                    itemsev.Value = 50;
                    this.WeaponsList.Add(itemsev);
                    Item itemeight = new Item();
                    itemeight.Name = "OFF protein";
                    itemeight.Quantity = 1;
                    itemeight.Value = 400;
                    this.WeaponsList.Add(itemeight);
                    Item itemnine = new Item();
                    itemnine.Name = "Animal energy powder";
                    itemnine.Quantity = 1;
                    itemnine.Value = 150;
                    this.WeaponsList.Add(itemnine);
                    break;
                case PlanetTypes.Wombodum:
                    Item itemten = new Item();
                    itemten.Name = "Thew Claw";
                    itemten.Quantity = 1;
                    itemten.Value = 600;
                    this.WeaponsList.Add(itemten);
                    Item itemeleven = new Item();
                    itemeleven.Name = "Purple remote";
                    itemeleven.Quantity = 1;
                    itemeleven.Value = 200;
                    this.WeaponsList.Add(itemeleven);
                    Item item13 = new Item();
                    item13.Name = "Awesome cyborg doll";
                    item13.Quantity = 1;
                    item13.Value = 350;
                    this.WeaponsList.Add(item13);
                    Item item14 = new Item();
                    item14.Name = "laser sword";
                    item14.Quantity = 1;
                    item14.Value = 400;
                    this.WeaponsList.Add(item14);
                    break;
                case PlanetTypes.Krytunga:
                    Item item15 = new Item();
                    item15.Name = "Red crystal";
                    item15.Quantity = 1;
                    item15.Value = 200;
                    this.WeaponsList.Add(item15);
                    Item item16 = new Item();
                    item16.Name = "Blue crystal";
                    item16.Quantity = 1;
                    item16.Value = 200;
                    this.WeaponsList.Add(item16);
                    Item item17 = new Item();
                    item17.Name = "Green crystal";
                    item17.Quantity = 1;
                    item17.Value = 200;
                    this.WeaponsList.Add(item17);
                    break;
            }
        }
    }
}