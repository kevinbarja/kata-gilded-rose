namespace GildedRose
{
	public class BehaviorFactory
	{
		public static IBehaviorInterface Create(Item item)
		{
			if (item.Name.Contains("Normal"))
			{
				return new NormalBehavior();
			}
            else if (item.Name.Contains("Aged Brie"))
            {
                return new AgedBrieBehavior();
            }
            else if (item.Name.Contains("Sulfuras"))
            {
                return new SulfurasBehavior();
            }
			else if (item.Name.Contains("Backstage pass"))
			{
				return new BackstagePassesBehavior();
			}
			else if (item.Name.Contains("Conjured"))
			{
				return new ConjuredBehavior();
			}
			else
			{
                throw new System.NotImplementedException("Nombre de item desconocido");
			}
		}
	}

}