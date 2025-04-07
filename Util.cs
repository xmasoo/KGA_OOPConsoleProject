using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    internal static class Util
    {
        public static void PressAnyKey(string text = "아무 키나 입력하세요")
        {
            Console.WriteLine(text);
            Console.ReadKey(true);
        }
    }
}
