using System.Collections.Generic;

namespace Visitor
{
	public interface IUnit
	 {
		void PrintItems();
		double AcceptVisit(IVisitor visitor);
		List<IItem> GetItems();
		void AddItem(IItem item);
		 
		 string Name { get; set; }
	 }
}
