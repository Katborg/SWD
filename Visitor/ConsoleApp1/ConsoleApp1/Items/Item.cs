namespace Visitor
{
	public class Item : IItem
	{
		protected double damage = 1;
		protected double building = 1;


		public ItemType GetType()
		{
			return ItemType.None;
		}
	}

	interface IItem
	{
		ItemType GetType();
	}

	public enum ItemType
	{
		None,
		Tool,
		Wepeon,
		Defence

	}
}