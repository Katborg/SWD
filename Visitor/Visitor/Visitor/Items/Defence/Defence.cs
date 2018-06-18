using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace Visitor
{
	abstract class Defence : IItem, IDefence
	{
		public double GetPower()
		{
			return 4;
		}
	}
}
