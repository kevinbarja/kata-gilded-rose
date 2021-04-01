namespace GildedRose
{
	public class Item
	{

	  public string name;
      public int sellIn;
      public int quality;

	  public Item(string name, int quality, int sellIn)
	  {
		this.Name = name;
		this.SellIn = sellIn;
		this.Quality = quality;
	  }

	  public virtual string Name
	  {
		  get
		  {
			return name;
		  }
		  set
		  {
			this.name = value;
		  }
	  }


	  public virtual int SellIn
	  {
		  get
		  {
			return sellIn;
		  }
		  set
		  {
			this.sellIn = value;
		  }
	  }


	  public virtual int Quality
	  {
		  get
		  {
			return quality;
		  }
		  set
		  {
			this.quality = value;
		  }
	  }
	}

}