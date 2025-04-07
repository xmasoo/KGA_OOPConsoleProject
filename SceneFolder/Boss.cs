using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public class Boss : Scene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("현재 위치는 보스방입니다.");
            Console.WriteLine("보스에게 도전하시겠습니까?");
            Console.Write("1. 네 \t 2. ㅌㅌ ");
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
                    Game.monster = MonsterFactory.CreateMonster(4);
                    Game.ChangeScene("Battle");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("HuntingGround");
                    break;
                default:
                    break;
            }
        }

    }
}
