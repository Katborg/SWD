using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace ConsoleApp1.Items
{
	class Weapon : IItem
	{
		public ItemType GetType()
		{
			return ItemType.Wepeon;
		}
	}
}
