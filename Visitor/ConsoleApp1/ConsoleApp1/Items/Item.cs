namespace Visitor
{
	
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