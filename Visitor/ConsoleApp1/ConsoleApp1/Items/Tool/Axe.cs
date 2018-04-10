using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	class Axe : Tool, IWeapon, IAxe
	{
		public override double GetPower()
		{
			return 3;
		}
	}
}
