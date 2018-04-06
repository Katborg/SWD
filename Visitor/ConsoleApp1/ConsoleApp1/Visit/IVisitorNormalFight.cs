using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Unit;

namespace Visitor
{
	public class  IVisitorNormalFight : IVisitorFight
	{
		public double Visit(IUnit unit)
		{
			throw new NotImplementedException();
		}

		public double Visit(IViking unit)
		{
			throw new NotImplementedException();
		}

		public double Visit(IEnglishSoldier unit)
		{
			throw new NotImplementedException();
		}

		public double Visit(IRomanSoldier unit)
		{
			throw new NotImplementedException();
		}
	}
}
