using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static Dima_demo_1_0_by14092022.SafeReadClassForString;

namespace Dima_demo_1_0_by14092022
{
	public class String_check
	{
		public static string telephon = "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$";
		public static string email = "[^@ \\t\\r\\n]+@[^@ \\t\\r\\n]+\\.[^@ \\t\\r\\n]+";
		public static string ip = "(\\b25[0-5]|\\b2[0-4][0-9]|\\b[01]?[0-9][0-9]?)(\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}";
		public static string str1, str2, str1_copy, str2_copy;
		
		
		public static void string_check_noRegister(string str1, string str2, string str1_copy, string str2_copy)
		{
			
			str1_copy = str1.Trim();
			str2_copy = str2.Trim();
			str1_copy = str1_copy.ToUpper();
			str2_copy = str2_copy.ToUpper();
			str1_copy = str1_copy.Replace("  ", "");
			str2_copy = str2_copy.Replace("  ", "");
			if (str1_copy.CompareTo(str2_copy) == 0)
			{
				throw new ValidationExceptions("строки совпадают, без учёта их регистров");
			}
			else {
				throw new ValidationExceptions("строки ne совпадают, без учёта их регистров");
			}


		}
		public static void string_check_wRegister(string str1, string str2)
		{

			if (str1.CompareTo(str2) == 0)
			{
				throw new ValidationExceptions("строки совпадают, с учётом их регистров");
			}
			else
			{
				throw new ValidationExceptions("строки ne совпадают, с учётом их регистров");
			}

		}
		public static void string_check_reverse(string str1, string str2, string str1_copy, string str2_copy)
		{
			string str = str1;
			str2_copy = str2;
			str1_copy = new string(str.Reverse().ToArray());
			if (str1_copy.CompareTo(str2_copy) == 0)
			{
				throw new ValidationExceptions("Одна из строк является перевёртышем другой строки");
			}
			else
			{
				throw new ValidationExceptions("Строки не являются перевёртышами");
			}
		}
		public static void string_check_p4_str1(string str1)
		{
			if ((Regex.IsMatch(str1, email, RegexOptions.IgnoreCase)))
			{
				throw new ValidationExceptions("This string is email addres");
			}
			

			if ((Regex.IsMatch(str1, telephon, RegexOptions.IgnoreCase)))
			{
				throw new ValidationExceptions("This string is telephone number");
			}

			if ((Regex.IsMatch(str1, ip, RegexOptions.IgnoreCase)))
			{
				throw new ValidationExceptions("This string is IP addres");
			}
			if (!(Regex.IsMatch(str1, ip, RegexOptions.IgnoreCase)) && (!(Regex.IsMatch(str1, telephon, RegexOptions.IgnoreCase))) && (!(Regex.IsMatch(str1, email, RegexOptions.IgnoreCase))))
			{
				throw new ValidationExceptions("строка не является ничем, только кваказябры");
			}
		}
		public static void string_check_p4_str2(string str2)
		{
			if ((Regex.IsMatch(str2, email, RegexOptions.IgnoreCase)))
			{
				throw new ValidationExceptions("This string is email addres");
			}


			if ((Regex.IsMatch(str2, telephon, RegexOptions.IgnoreCase)))
			{
				throw new ValidationExceptions("This string is telephone number");
			}

			if ((Regex.IsMatch(str2, ip, RegexOptions.IgnoreCase)))
			{
				throw new ValidationExceptions("This string is IP addres");
			}
			if (!(Regex.IsMatch(str2, ip, RegexOptions.IgnoreCase)) && (!(Regex.IsMatch(str2, telephon, RegexOptions.IgnoreCase))) && (!(Regex.IsMatch(str2, email, RegexOptions.IgnoreCase))))
			{
				throw new ValidationExceptions("строка не является ничем, только кваказябры");
			}
		}



	}
}
