namespace GildedRose
{
	public class AgedBrieBehavior : IBehaviorInterface
	{
		public virtual void UpdateQuality(Item item)
		{
			if (item.Quality < 50)
			{
				item.quality++;
			}
			item.SellIn--;
            if (item.SellIn < 0)
            {
                item.SellIn = 0;
            }
        }
	}

}