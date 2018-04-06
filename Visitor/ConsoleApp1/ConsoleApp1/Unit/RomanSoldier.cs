using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	public class RomanSoldier : Unit, IRomanSoldier
	{
		public new double AcceptVisit(IVisitor visitor)
		{
			return visitor.Visit(this);
		}
	}

	public interface IRomanSoldier : IUnit
	{
		
	}
}
