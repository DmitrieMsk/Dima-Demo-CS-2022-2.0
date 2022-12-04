using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dima_demo_1_0_by14092022.MenuItems
{
	public abstract class MenuItemCore
	{
		public abstract string Title { get; }
		public abstract void Execute();
	}
}
