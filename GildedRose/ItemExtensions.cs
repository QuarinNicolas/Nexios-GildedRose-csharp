using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Main
{
    public static class ItemExtensions
    {

        public static void IncreaseQualityBy(this Item item, int quality = 1)
        {
            if (item.Quality < 50)
                item.Quality += quality;
        }
        public static void DecreaseQualityBy(this Item item, int quality = 1)
        {
            if (item.Quality > 0)
                item.Quality -= quality;
        }

        public static void IncreaseSellInBy(this Item item, int sellIn = 1)
        {
            item.SellIn += sellIn;
        }
        public static void DecreaseSellInBy(this Item item, int sellIn = 1)
        {
            item.SellIn -= sellIn;
        }

        public static bool IsAgedBrie(this Item item)
        {
            return item.Name == Constants._agedBrie;
        }
        public static bool IsBackStagePasses(this Item item)
        {
            return item.Name == Constants._backStagePasses;
        }
        public static bool IsSulfuras(this Item item)
        {
            return item.Name == Constants._sulfuras;
        }
    }
}
