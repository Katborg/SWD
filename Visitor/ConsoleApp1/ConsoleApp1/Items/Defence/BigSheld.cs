﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor 
{
	class BigSheld : Defence
	{
		public override DefenceType GetDefenceType()
		{
			return DefenceType.BigShield;
		}
	}
}
