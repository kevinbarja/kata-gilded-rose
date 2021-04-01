namespace GildedRose
{
	public class ConjuredBehavior : IBehaviorInterface
	{
		public virtual void UpdateQuality(Item item)
		{
			if (item.sellIn > 0)
			{
				item.quality -= 2;
			}
			else
			{
				item.quality -= 4;
			}
			if (item.quality < 0)
			{
				item.quality = 0;
			}
			item.sellIn--;
		}
	}

}