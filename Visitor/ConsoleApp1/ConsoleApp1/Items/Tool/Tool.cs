using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace Visitor
{
	abstract class Tool : IItem, ITool
	{
		//public  ItemType GetType()
		//{
		//	return ItemType.Tool;
		//}

		public virtual double GetPower()
		{
			return 1;
		}

		//public abstract ToolType GetToolType();
	}

	//public enum ToolType
	//{
	//	Hammer,
	//	Saw,
	//	Axe
	//}

}
