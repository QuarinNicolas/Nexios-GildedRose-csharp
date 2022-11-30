using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Main
{
	public class GildedRoseProcessor
	{
		public Item[] Items { get; set; }
        public GildedRoseProcessor(Item[] items)
		{
			Items = items;
		}

		public void UpdateQuality()
		{
			foreach(var item in Items)
			{
                switch (item.Name)
                {
					case Constants._agedBrie:
						UpdateAgedBrieItem(item);
						break;
					case Constants._backStagePasses:
						UpdateBackStagePassesItem(item);
						break;
					case Constants._sulfuras:
						UpdateSulfurasItem(item);
						break;
					default:
						UpdateRegularItem(item);
						break;
                }
			
			}
		}

		private void UpdateRegularItem(Item item)
        {
			item.DecreaseQualityBy();

			item.DecreaseSellInBy();

			if (item.SellIn >= 0)
				return;

			item.DecreaseQualityBy();
		}

		private void UpdateSulfurasItem(Item item)
		{

		}

		private void UpdateAgedBrieItem(Item item)
		{
			item.IncreaseQualityBy();

			item.DecreaseSellInBy();

			if (item.SellIn >= 0)
				return;
			
			item.IncreaseQualityBy();
		}

		private void UpdateBackStagePassesItem(Item item)
		{
			item.IncreaseQualityBy();

			if (item.SellIn < 11)
				item.IncreaseQualityBy();

			if (item.SellIn < 6)
				item.IncreaseQualityBy();

			item.DecreaseSellInBy();

			if (item.SellIn >= 0)
				return;

			item.Quality = 0;
		}
	}
}


