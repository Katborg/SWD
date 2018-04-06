using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Unit
{
	abstract class Unit : IUnit
	{
		protected double Stregh;
		protected double Agility;
		protected double Inteligens;
		public virtual double AcceptVisit()
		{
			throw new NotImplementedException();
		}
	}

	 public interface IUnit
	 {
	 }
}
