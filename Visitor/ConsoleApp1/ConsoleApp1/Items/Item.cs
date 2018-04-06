namespace Visitor
{
	
	interface IItem
	{
		ItemType GetType();
	}

	public enum ItemType
	{
		Tool,
		Wepeon,
		Defence

	}
}