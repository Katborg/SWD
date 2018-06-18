namespace Visitor
{
	public interface IWorker : IUnit
	{
		double AcceptVisit(IVisitor visitor);
	}
}