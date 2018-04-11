using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace ConsoleApp1.Visit
{
	interface IVisitorBuild : IVisitor
	{
		new double Visit(IEnglishSoldier unit);
		new double Visit(IRomanSoldier unit);
		new double Visit(IUnit unit);
		new double Visit(IViking unit);
		new double Visit(IWorker unit);
	}
}
