namespace Visitor
{
	public interface IItem
	{
		ItemType GetType();
		double GetPower();
	}

	public enum ItemType
	{
		Tool
		,Wepeon
		,Defence
		//,ToolAndWeapon

	}
}