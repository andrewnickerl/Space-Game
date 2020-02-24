using System;
using System.Collections.Generic;

namespace SpaceGameLibrary
{
    public class Player
    {
        public string Name { get; set; }
        public short Hp { get; set; } = 100;
        public List<Item> Inventory { get; set; } = new List<Item>();
        public List<string> PlayerStatus { get; set; } = new List<string>();
        public short Currency { get; set; } = 500;
        public Item EquippedItem { get; set; }
        public string PetName { get; set; }
        public List<BattleEntity> BattleEntities { get; set; } = new List<BattleEntity>();

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
