using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceGameLibrary
{
    public class BattleEntity
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

        public short Damage
        {
            get => default;
            set
            {
            }
        }

        public bool TakenDamage(short damage)
        {
            throw new System.NotImplementedException();
        }

        public bool DealDamage(short damage)
        {
            throw new System.NotImplementedException();
        }
    }
}