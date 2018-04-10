namespace Visitor
{
	public interface IVisitorNormalFight
	{
		double Visit(IEnglishSoldier unit);
		double Visit(IRomanSoldier unit);
		double Visit(IUnit unit);
		double Visit(IViking unit);
	}
}