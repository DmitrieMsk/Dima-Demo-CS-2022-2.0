using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dima_demo_1_0_by14092022.MenuItems
{
	class MenuItemDate : MenuItemCore
	{
		public override string Title { get { return "Date parse"; } }

		public static long result;
		public override void Execute()
		{
			DateTime date10, date11, date20, date21;
			Console.WriteLine("enter please enter 2 time periods");
			do
			{
				
				 date10 = IOUtils.SafeReadDate("start 1 time period");
				Console.WriteLine("Value is {0}.{1}.{2}", date10.Day, date10.Month, date10.Year);
				 date11 = IOUtils.SafeReadDate("end 1 time period");
				Console.WriteLine("Value is {0}.{1}.{2}", date11.Day, date11.Month, date11.Year);
				if (date10.CompareTo(date11) > 0)
				{
					Console.WriteLine("Date incorrect form, please write new date");
				}
			} while (date10.CompareTo(date11) > 0);


			do
			{

				date20 = IOUtils.SafeReadDate("start 2 time period");
				Console.WriteLine("Value is {0}.{1}.{2}", date20.Day, date20.Month, date20.Year);
				date21 = IOUtils.SafeReadDate("end 2 time period");
				Console.WriteLine("Value is {0}.{1}.{2}", date21.Day, date21.Month, date21.Year);
				if (date20.CompareTo(date21) > 0)
				{
					Console.WriteLine("Date incorrect form, please write new date");
				}
			} while (date20.CompareTo(date21) > 0);
			

			result = Calc.calcDate(date10, date11, date20, date21);
			IOUtils.check_fact(result);
			
		}
		
	}
}
