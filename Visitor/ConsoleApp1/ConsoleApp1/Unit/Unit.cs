using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	abstract class Unit : IUnit
	{
		protected double Stregh = 5;
		protected double Agility = 5;
		protected double Inteligens = 5;
		protected List<Item> ItemList = new List<Item>();
		
		public virtual double AcceptVisit()
		{
			throw new NotImplementedException();
		}
	}

	 public interface IUnit
	 {
	 }
}
