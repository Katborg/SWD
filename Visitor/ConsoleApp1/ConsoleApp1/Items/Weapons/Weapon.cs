using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace Visitor
{
	public abstract class Weapon : IItem
	{
		//public new ItemType GetType()
		//{
		//	return ItemType.Wepeon;
		//}

		public double GetPower()
		{
			return 5;
		}

		//public abstract WeaponType GetWeaponType();


		
	}
	//public enum WeaponType
	//{
	//	Sword,
	//	Axe,
	//	Bow,
	//	Spear
	//}

}
