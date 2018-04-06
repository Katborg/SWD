using System;


namespace Visitor
{
	class Program
	{
		static void Main(string[] args)
		{
			IViking johnViking = new Viking();
			
			johnViking.AddItem(new WarAxe());
			johnViking.AddItem(new WarAxe());
			johnViking.Name = "John The Viking";

			IRomanSoldier jasperRoman = new RomanSoldier();
			jasperRoman.AddItem(new BigSheld());
			jasperRoman.AddItem(new Spear());
			jasperRoman.Name = "Jasper Roman";

			Fight(johnViking,jasperRoman);
			Console.ReadKey();
		}

		static void Fight(IUnit unitOne, IUnit unitTwo)
		{
			Console.WriteLine($"In the first corner we have:");
			double unitOnePower = CalcPower(unitOne);

			Console.WriteLine($"{unitOne.Name} with");
			unitOne.PrintItems();
			Console.WriteLine($"and a power of {unitOnePower}");

			Console.WriteLine($"In the other corner we have:");
			double unitTwoPower = CalcPower(unitTwo);

			Console.WriteLine($"{unitTwo.Name} with");
			unitTwo.PrintItems();
			Console.WriteLine($"and a power of {unitTwoPower}");

			Console.WriteLine("So the winner is {0}", (unitOnePower > unitTwoPower ? unitOne.Name : unitTwo.Name ));
		}

		static double CalcPower(IUnit unit)
		{
			if (unit is Viking)
			{
				return new VisitorNormalFight().Visit((IViking)unit);
			}
			else if (unit is RomanSoldier)
			{
				return new VisitorNormalFight().Visit((IRomanSoldier)unit);
			}
			else if (unit is EnglishSoldier)
			{
				return new VisitorNormalFight().Visit((IEnglishSoldier)unit);
			}
			else
			{
				return new VisitorNormalFight().Visit(unit);
			}
		}
	}
}
