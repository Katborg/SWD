using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	class Axe : Tool
	{
		public override ToolType GeToolType()
		{
			return ToolType.Axe;
		}
	}
}
