using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public class Title
    {
        public static void ShowTitle()
        {
            Console.Clear();
            Console.WriteLine("==================================");
            Console.WriteLine("            뭐시기 RPG            ");
            Console.WriteLine("==================================");

            Util.PressAnyKey();
        }
        public static void ShowIntro()
        {           
            Console.WriteLine("당신은 신입 모험가입니다..");
            Console.WriteLine("사천왕을 잡는 것이 당신의 목표입니다.");
            Console.WriteLine("성장하고 강해져서 게임을 클리어해주세요.");

            Util.PressAnyKey();
        }
    }
}
