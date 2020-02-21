using System;
using System.Collections.Generic;

namespace SpaceGameLibrary
{
    public class Player
    {
        public string Name { get; set; }
        public short Hp { get; set; }
        public List<Item> Inventory { get; set; }
        public string PlayerStatus { get; set; }
        public short Currency { get; set; }

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
    }
}
