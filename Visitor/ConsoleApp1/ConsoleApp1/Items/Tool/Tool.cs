using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace Visitor
{
	abstract class Tool : IItem
	{
		public  ItemType GetType()
		{
			return ItemType.Tool;
		}

		public double GetPower()
		{
			return 1;
		}

		public abstract ToolType GeToolType();
	}

	public enum ToolType
	{
		Hammer,
		Saw,
		Axe
	}

}
