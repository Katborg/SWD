using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Visitor.Unit;

namespace Visitor
{
	interface IVisitor
	{
		double Visit(IUnit unit);
		double Visit(IViking unit);
		double Visit(IEnglishSoldier unit);
		double Visit(IRomanSoldier unit);

	}
}
