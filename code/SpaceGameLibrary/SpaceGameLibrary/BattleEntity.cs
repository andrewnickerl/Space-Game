using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceGameLibrary
{
    public class BattleEntity
    {
        public string Name { get; set; }
        public short Hp { get; set; }
        public short Damage { get; set; }
        public string Intro { get; set; }

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