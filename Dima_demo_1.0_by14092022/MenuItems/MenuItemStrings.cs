using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dima_demo_1_0_by14092022.SafeReadClassForString;

namespace Dima_demo_1_0_by14092022.MenuItems
{
	public class MenuItemStrings : MenuItemCore
	{
		public static string str1, str2, str1_copy, str2_copy;
		public override string Title { get { return "Strings"; } }

		public override void Execute()
		{
			str1 = SafeReadClassForString.readstring1();
			str2 = SafeReadClassForString.readstring2();
			strings_metods_check_one();
			strings_metods_check_two();
			strings_metods_check_three();
			strings_metods_check_four_s1();
			strings_metods_check_four_s2();
		}
		public static void strings_metods_check_one()
		{
			try { String_check.string_check_noRegister(str1, str2, str1_copy, str2_copy); }
			catch (ValidationExceptions E){ Console.WriteLine(E.Message); }
		}
		public static void strings_metods_check_two()
		{
			try { String_check.string_check_wRegister(str1, str2); }
			catch (ValidationExceptions E) { Console.WriteLine(E.Message); }
		}
		public static void strings_metods_check_three()
		{
			try { String_check.string_check_reverse(str1, str2, str1_copy, str2_copy); }
			catch (ValidationExceptions E) { Console.WriteLine(E.Message); }
		}
		public static void strings_metods_check_four_s1()
		{
			str1_copy = str1;
			
			try { String_check.string_check_p4_str1(str1_copy); }
			catch (ValidationExceptions E) { Console.WriteLine(E.Message); }
		}
		public static void strings_metods_check_four_s2()
		{
			str2_copy = str2;

			try { String_check.string_check_p4_str1(str2_copy); }
			catch (ValidationExceptions E) { Console.WriteLine(E.Message); }
		}
		public static void StringArgs(string str11, string str22)
		{
			str1 = str11;
			str2 = str22;
			strings_metods_check_one();
			strings_metods_check_two();
			strings_metods_check_three();
			strings_metods_check_four_s1();
			strings_metods_check_four_s2();
		}
	}
}
