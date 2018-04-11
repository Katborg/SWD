using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace Visitor
{
	abstract class Tool : IItem, ITool
	{
		public virtual double GetPower()
		{
			return 1;
		}
	}
}
