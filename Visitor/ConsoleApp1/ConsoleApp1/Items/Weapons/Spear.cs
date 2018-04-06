using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace Visitor
{
	class Spear : Weapon
	{
		public override WeaponType GetWeaponType()
		{
			return WeaponType.Spear;
		}
	}
}
