namespace GildedRose
{
	public class NormalBehavior : IBehaviorInterface
	{
		public virtual void UpdateQuality(Item item)
		{
            item.SellIn--;
            item.Quality--;

            if (item.Quality < 0)
            {
                item.Quality = 0;
            }
            if (item.Quality > 50)
            {
                item.Quality = 50;
            }

        }
	}

}