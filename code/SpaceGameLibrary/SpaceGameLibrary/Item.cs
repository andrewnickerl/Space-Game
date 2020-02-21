using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceGameLibrary
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public short Damage { get; set; }
        public short Value { get; set; }
        public bool Reusable { get; set; }
        public byte Quantity { get; set; }
    }
}