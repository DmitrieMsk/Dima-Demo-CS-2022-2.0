using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dima_demo_1_0_by14092022.MenuItems
{
	public class MenuItemFormula : MenuItemCore
	{
		public override string Title { get { return "X*Y % Z"; } }

		public override void Execute()
		{
			
			Console.WriteLine("enter please x,y,z");
			int x = IOUtils.SafeReadInteger(null);
			int y = IOUtils.SafeReadInteger(null);
			int z = 0;
			IOUtils.ZnonZero(z, y, x);
			
		}
	}
}
