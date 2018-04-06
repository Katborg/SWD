using System;
using System.Collections.Generic;


namespace Visitor
{
	public class  VisitorNormalFight : IVisitorFight
	{
		public double Visit(IUnit unit)
		{
			List<IItem> items = unit.GetItems();
			return Calc_power(items);
		}

		public double Visit(IViking unit)
		{
			List<IItem> items = unit.GetItems();
			double power = Calc_power(items);

			//give viking extra power if he has axes
			foreach (var VARIABLE in items)
			{
				if (VARIABLE is WarAxe) power = power * 1.2;
			}

			return power;
		}

		public double Visit(IEnglishSoldier unit)
		{
			List<IItem> items = unit.GetItems();
			double power = Calc_power(items);
			bool oneBow = false;

			//give EnglishSoldier extra power if he has a bow
			foreach (var VARIABLE in items)
			{
				if (VARIABLE is Bow)
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
			double power = Calc_power(items);
			bool onespear = false;
			bool onesBigShield = false;
			
			//check for spear and shield
			foreach (var VARIABLE in items)
			{
#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
				if (VARIABLE is Spear) onespear = true;
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast

#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
				if (VARIABLE is BigSheld) onesBigShield = true;
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast

			}

			//give ekstra power if one BigSheild and spear present
			if (onesBigShield && onespear) power = power * 1.5;

			return power;
		}

		private double Calc_power(List<IItem> items)
		{
			double power = 0;
			foreach (var item in items)
			{
				if (item is Weapon || item is Defence)
				{
					power += item.GetPower();
				}
			}

			return power;
		}
	}
}
