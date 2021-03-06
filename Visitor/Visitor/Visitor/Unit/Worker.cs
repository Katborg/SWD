﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	public class Worker : Unit, IWorker
	{
		public override double AcceptVisit(IVisitor visitor) => visitor.Visit(this);
	}
}
