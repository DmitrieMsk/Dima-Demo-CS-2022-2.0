using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dima_demo_1_0_by14092022.MenuItems.MenuItemStrings;

namespace Dima_demo_1_0_by14092022
{
	public static class SafeReadClassForString
	{
		public static string str1, str2, str1_copy, str2_copy;
		public static string readstring1() 
		{
			Console.WriteLine("enter str1");
			return Console.ReadLine();
		}
		public static string readstring2()
		{
			Console.WriteLine("enter str2");
			return Console.ReadLine();
		}
	}
}
