using System;
using ConsoleApp1.Visit;


namespace Visitor
{
	class Program
	{
		static void Main(string[] args)
		{
			IViking johnViking = new Viking();
			
			johnViking.AddItem(new WarAxe());
			johnViking.AddItem(new Axe());
			johnViking.Name = "John The Viking";

			IRomanSoldier jasperRoman = new RomanSoldier();
			jasperRoman.AddItem(new BigSheld());
			jasperRoman.AddItem(new Spear());
			jasperRoman.Name = "Jasper Roman";

			Fight(johnViking,jasperRoman);
			BuildHouse(johnViking, jasperRoman);

			IRomanSoldier jasperTheRomanBuilder = new RomanSoldier();
			jasperTheRomanBuilder.Name = "Jasper Roman builder";

			IWorker bob = new Worker();
			bob.Name = "Bob";
			bob.AddItem(new Axe());

			Fight(jasperTheRomanBuilder, bob);
			BuildHouse(jasperTheRomanBuilder, bob);
			BuildHouse(johnViking, bob);
			Console.ReadKey();
		}

		#region Figthing
		static void Fight(IUnit unitOne, IUnit unitTwo)
		{
			Console.WriteLine("\nFighting  games!!!");
			Console.WriteLine($"In the first corner we have:");
			double unitOnePower = unitOne.AcceptVisit(new VisitorNormalFight()); ;

			Console.WriteLine($"{unitOne.Name} with");
			unitOne.PrintItems();
			Console.WriteLine($"and a power of {unitOnePower}");

			Console.WriteLine($"In the other corner we have:");
			double unitTwoPower = unitTwo.AcceptVisit(new VisitorNormalFight());

			Console.WriteLine($"{unitTwo.Name} with");
			unitTwo.PrintItems();
			Console.WriteLine($"and a power of {unitTwoPower}");

			Console.WriteLine("So the winner is {0}", (unitOnePower > unitTwoPower ? unitOne.Name : unitTwo.Name));
		}
		#endregion
	
		#region Building
		static void BuildHouse(IUnit unitOne, IUnit unitTwo)
		{
			Console.WriteLine("\nBuilding games!!!");
			Console.WriteLine($"At the first building ground we have:");
			double unitOnePower = unitOne.AcceptVisit(new VisitorNormalBuild());

			Console.WriteLine($"{unitOne.Name} with");
			unitOne.PrintItems();
			Console.WriteLine($"and a buildpower of {unitOnePower}");

			Console.WriteLine($"At the Other building ground we have:");
			double unitTwoPower = unitTwo.AcceptVisit(new VisitorNormalBuild());

			Console.WriteLine($"{unitTwo.Name} with");
			unitTwo.PrintItems();
			Console.WriteLine($"and a buildpower of {unitTwoPower}");
			Console.WriteLine("\nA house takes 30 build power");

			int unitOneRound = CalcHouseBuildTime(unitOnePower);
			int unitTwoRound = CalcHouseBuildTime(unitTwoPower);


			Console.WriteLine($"So it took {unitOne.Name} {unitOneRound} to build a house");
			Console.WriteLine($"So it took {unitTwo.Name} {unitTwoRound} to build a house");
			
			//Pronaouse Winner
			Console.WriteLine(unitTwoRound == unitOneRound
				? $"Whey are equally fast!!"
				: $"So the Winner is claerly {(unitOneRound < unitTwoRound ? unitOne.Name : unitTwo.Name)} ");
		}

		static int CalcHouseBuildTime(double buildpower)
		{
			double buildTime = 30 / buildpower;
			return (int)Math.Ceiling(buildTime);
		}
		#endregion
	}
}
