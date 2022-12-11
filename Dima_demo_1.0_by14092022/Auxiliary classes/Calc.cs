using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dima_demo_1_0_by14092022
{
	public class Calc
	{
		public static long result;
		public static int calculation(int x, int y, int z)
		{
			Console.Write("X*Y%Z = ");
			return (x * y % z);
		}
		public static int calcDate(DateTime date10, DateTime date11, DateTime date20, DateTime date21)
		{
			TimeSpan date3 = date11 - date10;
			TimeSpan date4 = date21 - date20;
			TimeSpan N = date4 - date4; // НЕ ЗАБЫТЬ ВЕРНУТЬСЯ К ЭТОМУ !
			Console.WriteLine(N);
			if (date10 == date20 && date11 == date21)
			{
				N = date11 - date10;
				return (N.Days + 1);
			}
			if (date21 < date10 || date20 > date11)
			{
				return (N.Days);
			}
			if (date20 > date10 && date20 < date11)
			{
				if (date21 > date11)
				{
					N = date11 - date20;
					return (N.Days + 1);
				}
				else
				{
					N = date21 - date20;
					return (N.Days + 1);
				}
			}
			if (date20 < date10 && date21 > date10)
			{
				if (date21 > date11)
				{
					N = date11 - date10;
					return (N.Days + 1);
				}
				else
				{
					N = date21 - date10;
					return (N.Days + 1);
				}
			}
			if (date10 == date11 && date20 == date21)
			{
				N = date11 - date21;
				return (N.Days);
			}
			if (N.Days > 0)
			{
				return (N.Days + 1);
			}
			else {
				return (N.Days);
			}
		}
		public static void CALCO(string x, string y, string z) 
		{
			
			int X = 0;
			if (Int32.TryParse(x, out X))
			{
				Console.WriteLine(X);
			}
			else { Console.WriteLine("ERROR:Incorrect format!"); Environment.Exit(0); }
			int Y = 0;
			if (Int32.TryParse(y, out Y))
			{
				Console.WriteLine(Y);
			}
			else { Console.WriteLine("ERROR:Incorrect format!"); Environment.Exit(0); }
			int Z = 0;
			if (Int32.TryParse(z, out Z))
			{
				Console.WriteLine(Z);
			}
			else { Console.WriteLine("ERROR:Incorrect format!"); Environment.Exit(0); }
			if (Z == 0)
			{
				Console.WriteLine("Значение не может быть нулевым");
				Environment.Exit(0);
			}
			else
			{
				double Calc = Convert.ToDouble(X * Y % Z);
				Console.Write("Formula = ");
				Console.WriteLine(Calc);
			}
		}
		public static void ProvREC(string data1, string data2, string data3, string data4)
		{
			DateTime date10;
			DateTime date11;
			DateTime date20;
			DateTime date21;
			if (DateTime.TryParse(data1, out date10) && date10.ToString("dd.MM.yyyy") == data1)
			{
				Console.WriteLine(data1);
			}
			else
			{
				Console.WriteLine("ERROR:Incorrect format!");
				Environment.Exit(0);
			}
			if (DateTime.TryParse(data2, out date11) && date11.ToString("dd.MM.yyyy") == data2)
			{
				Console.WriteLine(data2);
			}
			else
			{
				Console.WriteLine("ERROR:Incorrect format!");
				Environment.Exit(0);
			}
			if (DateTime.TryParse(data3, out date20) && date20.ToString("dd.MM.yyyy") == data3)
			{
				Console.WriteLine(data3);
			}
			else
			{
				Console.WriteLine("ERROR:Incorrect format!");
				Environment.Exit(0);
			}
			if (DateTime.TryParse(data4, out date21) && date21.ToString("dd.MM.yyyy") == data4)
			{
				Console.WriteLine(data4);
			}
			else
			{
				Console.WriteLine("ERROR:Incorrect format!");
				Environment.Exit(0);
			}
			TimeSpan timeA = date11 - date10;
			TimeSpan timeB = date21 - date20;
			TimeSpan N = timeB - timeB;
			if (date10 == date20 && date11 == date21)
			{
				N = date11 - date10;
				Console.WriteLine($"N = {N.Days + 1}");
			}
			if (date21 < date10 || date20 > date11)
			{
				Console.WriteLine($"N = {N.Days}");
			}
			if (date20 > date10 && date20 < date11)
			{
				if (date21 > date11)
				{
					N = date11 - date20;
					Console.WriteLine($"N = {N.Days + 1}");
				}
				else
				{
					N = date21 - date20;
					Console.WriteLine($"N = {N.Days + 1}");
				}
			}
			if (date20 < date10 && date21 > date10)
			{
				if (date21 > date11)
				{
					N = date11 - date10;
					Console.WriteLine($"N = {N.Days + 1}");
				}
				else
				{
					N = date21 - date10;
					Console.WriteLine($"N = {N.Days + 1}");
				}
			}
			if (date10 == date11 && date20 == date21)
			{
				N = date11 - date21;
				Console.WriteLine($"N = {N.Days}");
			}
			if (N.Days > 0)
				result = N.Days + 1;
			if (IOUtils.check_fact(result) == 1)
			{
				IOUtils.calc_fact(result);
			}
		}

	}
}
