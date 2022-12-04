using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dima_demo_1_0_by14092022.MenuItems
{
	public class MenuItemExit : MenuItemCore
	{
		public override string Title { get { return "exit"; } }

		public override void Execute()
		{
			Console.WriteLine("exit....");
			Environment.Exit(0);
		}
	}
}
