namespace GildedRose
{
    public class BackstagePassesBehavior : IBehaviorInterface
    {
        public virtual void UpdateQuality(Item item)
        {
            if (passDate(item))
            {
                item.Quality = 0;
            }
            else if (item.Quality < 50)
            {
                int? qualityIncrease = getQualityIncreaseBy(item.SellIn);
                item.Quality += qualityIncrease.Value;
            }
            item.SellIn--;

            if (item.Quality > 50)
            {
                item.Quality = 50;
            }

            if (item.SellIn < 0)
            {
                item.SellIn = 0;
            }

        }

        private int? getQualityIncreaseBy(int? remainingDaysBeforeExpiration)
        {
            if (remainingDaysBeforeExpiration <= 5)
            {
                return 3;
            }
            else if (remainingDaysBeforeExpiration <= 10)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
        // Verifica si se paso la fecha
        private bool passDate(Item item)
        {
            return item.SellIn <= 0;
        }
    }
}
