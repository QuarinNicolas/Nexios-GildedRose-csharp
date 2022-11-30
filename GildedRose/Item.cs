using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Main
{
    public class Item
    {
        public Item(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }
        public Item()
        {
                
        }
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
        public string toString()
        {
            return Name + ", " + SellIn + ", " + Quality;
        }
    }
}
