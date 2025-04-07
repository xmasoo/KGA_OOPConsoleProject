using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public class Scenedafault : Scene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("현재 위치는 입니다.");
            Console.WriteLine("세요");
            Console.Write("1.  \t 2.  \t 3. ");
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            
        }
        public override void Result()
        {
            
        }

    }
}
