using Visitor;

namespace ConsoleApp1.Visit
{
	interface IVisitorNormalBuild
	{
		double Visit(IEnglishSoldier unit);
		double Visit(IRomanSoldier unit);
		double Visit(IUnit unit);
		double Visit(IViking unit);
		double Visit(IWorker unit);
	}
}