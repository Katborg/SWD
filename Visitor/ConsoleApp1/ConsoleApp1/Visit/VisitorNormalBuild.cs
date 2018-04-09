using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace ConsoleApp1.Visit
{
	class VisitorNormalBuild : IVisitorBuild
	{
		public double Visit(IUnit unit)
		{
			double power = 0;
			return power;
		}
		public double Visit(IWorker unit)
		{
			List<IItem> items = unit.GetItems();

			double power = 6;

			//Calc building power
			foreach (var item in items) if (item is Tool) power += item.GetPower();

			//Gives bonus the more diffent tools a worker has. 
			int NumberOfDiffentTools = items.Distinct().Count();
			power = power * (NumberOfDiffentTools * 0.75 < 1 ? NumberOfDiffentTools * 0.75 : 1);
			return power;
		}

		public double Visit(IViking unit)
		{
			List<IItem> items = unit.GetItems();

			double power = 3;

			foreach (var item in items)
			{
				if (item is Tool)
				{
					power += item.GetPower();
					if (item is Axe) power += 3;
				}
				if (item is WarAxe) power += 2;
			}
			return power;
		}

		public double Visit(IEnglishSoldier unit)
		{
			List<IItem> items = unit.GetItems();

			double power = 0;

			foreach (var item in items)
			{
				if (item is Tool)
				{
					power += item.GetPower();
				}
			}
			return power;
		}

		public double Visit(IRomanSoldier unit)
		{
			List<IItem> items = unit.GetItems();

			double power = 2;

			foreach (var item in items)
			{
				if (item is Tool)
				{
					power += item.GetPower();
				}
			}
			return power;
		}
	}
}
