using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Visitor
{
	public abstract class Unit : IUnit
	{
		protected double Stregh = 5;
		protected double Agility = 5;
		protected double Inteligens = 5;
		protected List<IItem> ItemList = new List<IItem>();

		public void PrintItems()
		{
			foreach (var VARIABLE in ItemList)
			{
				Console.WriteLine($"{VARIABLE.ToString()}");
			}
		}
		public void AddItem(IItem item)
		{
			ItemList.Add(item);
		}

		public string Name { get; set; }

		public virtual double AcceptVisit(IVisitor visitor)
		{
			return visitor.Visit(this);
		}

		public List<IItem> GetItems()
		{
			return ItemList;
		}
	}

	 public interface IUnit
	 {
		 void PrintItems();
		double AcceptVisit(IVisitor visitor);
		List<IItem> GetItems();
		 void AddItem(IItem item);
		 
		 string Name { get; set; }
	 }
}
