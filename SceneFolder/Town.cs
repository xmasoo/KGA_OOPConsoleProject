using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public class Town : Scene
    {
        private ConsoleKey input;
        private bool isFirst = true;
        //private Player player;
        public override void Render()
        {
            if (isFirst)//처음만 발생하는 이벤트
            {
                Console.WriteLine("당신의 모험은 이제 막 시작되었다...");
                Console.WriteLine("뉴비핥는아저씨가 나타나서 당신에게 소매넣기를 했습니다.");
                Console.WriteLine("1000골드를 획득했습니다.");
                Game.player.AddGold(1000);
                Util.PressAnyKey();
                isFirst = false;
            }
            Console.WriteLine("현재 위치는 마을입니다.");
            Console.WriteLine("이동할 장소를 고르세요");
            Console.WriteLine("1. 상점 \t 2. 여관 \t 3. 사냥터");
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
                    Game.ChangeScene("Shop");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("INN");
                    break;
                case ConsoleKey.D3:
                    Game.ChangeScene("HuntingGround");
                    break;
                default:
                    break;
            }
        }
    }
}
