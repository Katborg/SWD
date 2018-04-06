using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace Visitor
{
	abstract class Defence : IItem
	{
		public new ItemType GetType()
		{
			return ItemType.Defence;
		}

		public double GetPower()
		{
			return 4;
		}

		public abstract DefenceType GetDefenceType();

	}

	public enum DefenceType
	{
		BigShield,
		SmallShield,
		ChainMail
	}
}
