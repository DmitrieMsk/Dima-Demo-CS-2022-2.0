using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dima_demo_1_0_by14092022.MenuItems;

namespace Dima_demo_1_0_by14092022
{
	public class Menu
	{
		private static List<MenuItemCore> MenuItems = new List<MenuItemCore>();
		public static void ClearItems()
		{
			Menu.MenuItems.Clear();
		}
		public static void AddItem(MenuItemCore menuItem)
		{
			Menu.MenuItems.Add(menuItem);
		}
		
		
		public static void Execute()
		{
			ShowMenu();
			int iMenu = IOUtils.SafeReadInteger(null) - 1;
			if (iMenu >= 0 && iMenu <= Menu.MenuItems.Count)
			{
				MenuItems.ToArray()[iMenu].Execute();
			}
			else
			{
				Console.WriteLine("Menu item not found.");
			}
			
		}
		private static void ShowMenu()
		{
			Console.WriteLine("=== MENU ===");
			int iMenuItem = 1;
			foreach (MenuItemCore menuItem in MenuItems)
			{
				Console.WriteLine("{0}: {1}", iMenuItem++, menuItem.Title);
			}
			
			
		}
	}
}
