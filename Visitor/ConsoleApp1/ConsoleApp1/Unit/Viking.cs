using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	public class Viking : Unit, IViking 
	{
		public new double AcceptVisit(IVisitor visitor)
		{
			return visitor.Visit(this);
		}
	}
}
