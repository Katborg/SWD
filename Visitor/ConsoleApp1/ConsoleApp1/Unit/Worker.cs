using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	public class Worker : Unit, IWorker
	{
		
	}

	interface IWorker : IUnit
	{
		
	}
}
