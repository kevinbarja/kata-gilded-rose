
namespace GildedRose
{
    public class ItemService
    {
        public Item UpdateQuality(Item item)
        {
            IBehaviorInterface strategy = BehaviorFactory.Create(item);
            strategy.UpdateQuality(item);
            return item;
        }
    }
}
