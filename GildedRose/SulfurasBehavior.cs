namespace GildedRose
{
	public class SulfurasBehavior : IBehaviorInterface
	{
		public virtual void UpdateQuality(Item item)
		{
            item.Quality = 80;
            item.SellIn--;
            if (item.SellIn < 0)
            {
                item.SellIn = 0;
            }
        }
	}

}