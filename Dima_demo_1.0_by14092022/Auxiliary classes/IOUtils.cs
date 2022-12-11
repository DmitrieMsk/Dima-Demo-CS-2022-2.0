using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dima_demo_1_0_by14092022.MenuItems.MenuItemStrings;


namespace Dima_demo_1_0_by14092022
{
	public class IOUtils
	{
		public static long capets;
		public static long result;
		public static string str1_copy, str2_copy;
		public static int SafeReadInteger(string message)
		{
			while (true)
			{
				{
					if (!string.IsNullOrEmpty(message))
					{
						Console.WriteLine(message); // если строчка не пустая
					}

				}
				string sValue = Console.ReadLine();
				int iValue = 0;
				if (Int32.TryParse(sValue, out iValue))
				{
					return iValue;
				}
				Console.WriteLine("ERROR: Incorrect format. Enter integer value...");
			}
		}

		public static DateTime SafeReadDate(string message)
		{
			while (true)
			{
				{
					if (!string.IsNullOrEmpty(message))
					{
						Console.WriteLine(message); // если строчка не пустая
					}

				}
				string sValue = Console.ReadLine();
				DateTime date;
				if (DateTime.TryParseExact(sValue,"dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date))
				{
					return date;
				}
				Console.WriteLine("ERROR: Incorrect format. Enter correct date time...");
			}
		}
		public static int check_fact(long result)
		{
			
			if (result >= 12)
			{

				Console.WriteLine("You enter very big otrezok :(");
				return 1;
			}
			else
			{
				
				calc_fact(result);
				return 0;

			}
			
		}
		public static void calc_fact(long result) 
		{
			long fact = result;
			int capets = 1;
			for (int i = 1; i <= fact; i++)
			{
				capets = capets * i;
			}
			Console.WriteLine(capets);
		}
		public static void SafeReadString()
		{
			Console.WriteLine("end please str1");
			string str1 = Console.ReadLine();
			Console.WriteLine("end please str2");
			string str2 = Console.ReadLine();
			Console.WriteLine(str1);

			Console.WriteLine(str2);
			
			
		}
		public static int ZnonZero(int z, int y, int x) 
		{
			int form;
			
			bool f = false; // для того чтоб f проверял до того момента пока не введёт правильно
			while (f == false)
			{
				z = IOUtils.SafeReadInteger(null);
				if (z != 0)
				{
					form = Calc.calculation(x, y, z);
					Console.WriteLine(form);
					f = true;
				}
				else
				{
					Console.WriteLine("value z uncorrect");
					
				}
				
			}
			return 0;
		}
	}
	
}
