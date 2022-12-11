using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dima_demo_1_0_by14092022.MenuItems;

namespace Dima_demo_1_0_by14092022
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length == 0)
			{


				Menu.ClearItems();
				Menu.AddItem(new MenuItemExit());
				Menu.AddItem(new MenuItemHelloWorld());
				Menu.AddItem(new MenuItemFormula());
				Menu.AddItem(new MenuItemDate());
				Menu.AddItem(new MenuItemStrings());
				while (true)
				{
					Menu.Execute();
				}
			}
			else
			{
				ForConsoleClass.StartProgram(args);
			}
		}		
	}
}
