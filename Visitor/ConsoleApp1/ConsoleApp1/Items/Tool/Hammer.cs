﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	class Hammer : Tool
	{
		public override ToolType GeToolType()
		{
			return ToolType.Hammer;
		}
	}
}
