using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	public interface IVisitorFight : IVisitor
	{
		new double Visit(IEnglishSoldier unit);
		new double Visit(IRomanSoldier unit);
		new double Visit(IUnit unit);
		new double Visit(IViking unit);
	}
}
