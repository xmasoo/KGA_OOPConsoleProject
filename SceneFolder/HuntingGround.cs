using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    internal class HuntingGround : Scene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("현재 위치는 사냥터입니다.");
            Console.WriteLine("무엇을 하시겠습니까?");
            Console.Write("1. 사냥하기 \t 2. 보스 도전 \t 3. 마을로 돌아가기");
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
            switch (input)
            {
                case ConsoleKey.D1:
                    //TODO 사냥하는 코드
                    break;
                case ConsoleKey.D2:
                    //TODO 보스 도전하는 코드
                    break;
                case ConsoleKey.D3:
                    Game.ChangeScene("Town");
                    break;
                default:
                    break;
            }
        }

    }
}
