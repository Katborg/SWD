using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace ConsoleApp1.Items.Defence
{
	class ChainMail : Visitor.Defence
	{
		public override DefenceType GetDefenceType()
		{
			return DefenceType.ChainMail;
		}
	}
}
