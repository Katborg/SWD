

namespace Visitor
{
	public interface IVisitor
	{
		double Visit(IUnit unit);
		double Visit(IViking unit);
		double Visit(IEnglishSoldier unit);
		double Visit(IRomanSoldier unit);

	}
}
