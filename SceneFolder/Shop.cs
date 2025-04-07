using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    internal class Shop : Scene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("현재 위치는 상점입니다.");
            Console.WriteLine("무엇을 하시겠습니까?");
            Console.Write("1. 구매 \t 2. 판매 \t 3. 강도 \t 4. 마을로 돌아가기");
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
                    //TODO 구매하는 코드
                    break;
                case ConsoleKey.D2:
                    //TODO 판매하는 코드
                    break;
                case ConsoleKey.D3:
                    //TODO 강도당하는 코드
                    break;
                case ConsoleKey.D4:
                    Game.ChangeScene("Town");
                    break;
                default:
                    break;
            }
        }

    }
}
