using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	class Saw : Tool
	{
		public override double GetPower()
		{
			return 1.5;
		}
	}
}
