using System;
using System.Collections.Generic;

namespace Visitor
{
	public class  VisitorNormalFight : IVisitorFight
	{
		public double Visit(IUnit unit)
		{
			List<IItem> items = unit.GetItems();

			double power = 1;

			foreach (var item in items)
			{
				if (item is IWeapon || item is IDefence)
				{
					power += item.GetPower();
				}
			}
			return power;
		}

		public double Visit(IViking unit)
		{
			List<IItem> items = unit.GetItems();
			double power = 2;

			//give viking extra power if he has axes and calc power
			foreach (var item in items)
			{
				if (item is IWeapon || item is IDefence)
				{
					power += item.GetPower();
				}
				if (item is IAxe) power = power * 1.2;
			}

			return power;
		}

		public double Visit(IEnglishSoldier unit)
		{
			List<IItem> items = unit.GetItems();
			double power = 1;
			bool oneBow = false;

			//give EnglishSoldier extra power if he has a bow and calc power
			foreach (var item in items)
			{
				if (item is IWeapon || item is IDefence)
				{
					power += item.GetPower();
				}
				if (item is Bow)
				{
					//get extra power for first bow only
					if(!oneBow) { 
					power = power * 1.3;
						oneBow = true;
					}
				}
			}
			return power;
		}

		public double Visit(IRomanSoldier unit)
		{
			List<IItem> items = unit.GetItems();

			double power = 2;
			bool onespear = false;
			bool onesBigShield = false;

			//check for spear and shield and calc power
			foreach (var item in items)
			{
				if (item is IWeapon || item is IDefence)
				{
					power += item.GetPower();
				}

				if (item is Spear) onespear = true;
				if (item is BigSheld) onesBigShield = true;
			}

			//give ekstra power if one BigSheild and spear present
			if (onesBigShield && onespear) power = power * 1.5;

			return power;
		}

		public double Visit(IWorker unit)
		{
			return Visit((IUnit) unit);
		}
	}
}
