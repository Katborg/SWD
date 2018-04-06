using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	class Axe : Weapon
	{
		public override WeaponType GetWeaponType()
		{
			return WeaponType.Axe;
		}
	}
}
