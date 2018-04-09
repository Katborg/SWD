using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	public class EnglishSoldier :Unit, IEnglishSoldier
	{
		public override double AcceptVisit(IVisitor visitor)
		{
			return visitor.Visit(this);
		}
	}

	public interface IEnglishSoldier : IUnit
	{

	}
}
