using System;

namespace SpaceGameLibrary
{
    public class Player
    {
        public string Name
        {
            get => default;
            set
            {
            }
        }

        public short Hp
        {
            get => default;
            set
            {
            }
        }

        public System.Array Inventory
        {
            get => default;
            set
            {
            }
        }

        public string PlayerStatus
        {
            get => default;
            set
            {
            }
        }

        public short Currency
        {
            get => default;
            set
            {
            }
        }

        public bool EditInventory(Item item, System.Array Inventory)
        {
            throw new System.NotImplementedException();
        }

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
