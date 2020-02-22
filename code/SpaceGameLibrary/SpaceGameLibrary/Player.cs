﻿using System;
using System.Collections.Generic;

namespace SpaceGameLibrary
{
    public class Player
    {
        public string Name { get; set; }
        public short Hp { get; set; } = 100;
        public List<Item> Inventory { get; set; } = new List<Item>();
        public string PlayerStatus { get; set; }
        public short Currency { get; set; } = 500;
        public Item EquippedItem { get; set; }
        public string PetName { get; set; } 

        public bool TakeDamage(int damage, ref int hp)
        {
            throw new System.NotImplementedException();
        }

        public bool UseItem(Item item)
        {
            throw new System.NotImplementedException();
        }

        public bool GameOver()
        {
            throw new System.NotImplementedException();
        }

        public bool EquipItem(Item weapon)
        {
            try
            {
                EquippedItem = weapon;
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
