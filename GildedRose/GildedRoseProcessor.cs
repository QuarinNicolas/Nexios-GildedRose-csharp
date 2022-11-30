using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Main
{
	public class GildedRoseProcessor
	{
		private const string _agedBrie = "Aged Brie";
		private const string _backStagePasses = "Backstage passes to a TAFKAL80ETC concert";
		private const string _sulfuras = "Sulfuras, Hand of Ragnaros";

		public Item[] Items { get; set; }
        public GildedRoseProcessor(Item[] items)
		{
			this.Items = items;
		}

		public void UpdateQuality()
		{
			foreach(var item in Items)
			{
				if (item.Name != _agedBrie && item.Name != _backStagePasses)
				{
					if (item.Quality > 0)
					{
						if (item.Name != _sulfuras)
						{
							item.Quality = item.Quality - 1;
						}
					}
				}
				else
				{
					if (item.Quality < 50)
					{
						item.Quality = item.Quality + 1;

						if (item.Name == _backStagePasses)
						{
							if (item.SellIn < 11)
							{
								if (item.Quality < 50)
								{
									item.Quality = item.Quality + 1;
								}
							}

							if (item.SellIn < 6)
							{
								if (item.Quality < 50)
								{
									item.Quality = item.Quality + 1;
								}
							}
						}
					}
				}

				if (item.Name != _sulfuras)
				{
					item.SellIn = item.SellIn - 1;
				}

				if (item.SellIn < 0)
				{
					if (item.Name != _agedBrie)
					{
						if (item.Name != _backStagePasses)
						{
							if (item.Quality > 0)
							{
								if (item.Name != _sulfuras)
								{
									item.Quality = item.Quality - 1;
								}
							}
						}
						else
						{
							item.Quality = item.Quality - item.Quality;
						}
					}
					else
					{
						if (item.Quality < 50)
						{
							item.Quality = item.Quality + 1;
						}
					}
				}
			}
		}
	}
}


