using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	class Axe : Tool
	{
		public override double GetPower()
		{
			return 3;
		}
		/*public override ToolType GetToolType()
		{
			return ToolType.Axe;
		}*/
	}
}
