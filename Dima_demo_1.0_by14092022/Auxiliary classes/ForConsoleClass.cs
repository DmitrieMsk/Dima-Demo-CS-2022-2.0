using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dima_demo_1_0_by14092022.Calc;

namespace Dima_demo_1_0_by14092022.MenuItems
{
    public class ForConsoleClass
    {
        public static void StartProgram(String[] a)
        {
            int n = -1, ch = 0;
            n = Search(a, n, "-mi");
            if (n == -1)
            {
                Console.WriteLine("You have not entered the menu item number.");
                Environment.Exit(0);
            }
            switch (a[n + 1])
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    MenuItemHelloWorld hello = new MenuItemHelloWorld();
                    hello.Execute();
                    break;
                case "2":
                    Calccc(n, ch, a);
                    break;
                case "3":
                    Recursion_Date(n, ch, a);
                    break;
                case "4":
                    Stringssss(n, ch, a);
                    break;
                default:
                    Console.WriteLine("You entered an incorrect value.");
                    break;
            }
        }
        public static void Calccc(int n, int ch, String[] a)
        {
            String[] Params = new String[3];
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    n = Search(a, n, "-x");
                    if (n != -1)
                    {
                        Params[0] = a[n + 1];
                        ch++;
                    }
                }
                if (i == 1)
                {
                    n = -1;
                    n = Search(a, n, "-y");
                    if (n != -1)
                    {
                        Params[1] = a[n + 1];
                        ch++;
                    }
                }
                if (i == 2)
                {
                    n = -1;
                    n = Search(a, n, "-z");
                    if (n != -1)
                    {
                        Params[2] = a[n + 1];
                        ch++;
                    }
                }
            }
            if (ch != 3)
            {
                Console.WriteLine("You didn't pass all the parameters.");
            }
            else
            {
                Calc calc = new Calc();
                Calc.CALCO(Params[0], Params[1], Params[2]);
            }
        }
        public static void Recursion_Date(int n, int ch, String[] a)
        {
            String[] Dates = new String[4];
            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    n = Search(a, n, "-d1st");
                    if (n != -1)
                    {
                        Dates[0] = a[n + 1];
                        ch++;
                    }
                }
                if (i == 1)
                {
                    n = -1;
                    n = Search(a, n, "-d1end");
                    if (n != -1)
                    {
                        Dates[1] = a[n + 1];
                        ch++;
                    }
                }
                if (i == 2)
                {
                    n = -1;
                    n = Search(a, n, "-d2st");
                    if (n != -1)
                    {
                        Dates[2] = a[n + 1];
                        ch++;
                    }
                }
                if (i == 3)
                {
                    n = -1;
                    n = Search(a, n, "-d2end");
                    if (n != -1)
                    {
                        Dates[3] = a[n + 1];
                        ch++;
                    }
                }
            }
            if (ch != 4)
            {
                Console.WriteLine("You didn't pass all the parameters.");
            }
            else
            {
                Calc.ProvREC(Dates[0], Dates[1], Dates[2], Dates[3]);
            }
        }
        public static void Stringssss(int n, int ch, String[] a)
        {
            String[] strings = new String[2];
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    n = Search(a, n, "-s1");
                    if (n != -1)
                    {
                        strings[0] = a[n + 1];
                        ch++;
                    }
                }
                if (i == 1)
                {
                    n = Search(a, n, "-s2");
                    if (n != -1)
                    {
                        strings[1] = a[n + 1];
                        ch++;
                    }
                }
            }
            if (ch != 2)
            {
                Console.WriteLine("You didn't pass all the parameters.");
            }
            else
            {
                MenuItemStrings.StringArgs(strings[0], strings[1]);
            }
        }
        public static int Search(String[] a, int n, String str)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (object.Equals(a[i], str))
                {
                    n = i;
                    return n;
                }
            }
            return n;
        }
    }
}