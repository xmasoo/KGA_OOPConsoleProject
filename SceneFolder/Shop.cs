using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public class Shop : Scene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("\"없는 거 빼고 다 있다네\"");
            Console.WriteLine();
            Console.WriteLine("현재 위치는 상점입니다.");
            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1. 구매 \t 2. 판매 \t 3. 마을로 돌아가기");
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
                    Game.ChangeScene("ShopBuying");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("ShopSelling");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("마을로 돌아갑니다.");
                    Util.PressAnyKey();
                    Game.ChangeScene("Town");
                    break;
                default:
                    break;
            }
        }

    }
}
