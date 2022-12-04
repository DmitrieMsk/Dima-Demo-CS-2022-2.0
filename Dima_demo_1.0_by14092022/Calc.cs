using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dima_demo_1_0_by14092022
{
	public static class Calc
	{
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
			
	}
}
