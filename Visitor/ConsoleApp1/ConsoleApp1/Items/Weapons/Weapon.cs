using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace Visitor
{
	public abstract class Weapon : IItem, IWeapon
	{
		public double GetPower()
		{
			return 5;
		}
	}
}
