namespace KGA_OOPConsoleProject
{
    public class Boss : Scene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("현재 위치는 보스방입니다.");
            Console.WriteLine("보스에게 도전하시겠습니까?");
            Console.WriteLine("1. 네 \t 2. 아직 준비가 덜 됐어 ");
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            if (input == ConsoleKey.D1)
            {
                Console.WriteLine();
                if (Game.bossCount == 0)
                {
                    Console.WriteLine("나는 사천왕 뭐시기");
                    Console.WriteLine("대충 사천왕이 할만한 대사1");
                }
                else if (Game.bossCount == 1)
                {
                    Console.WriteLine("크큭 그놈은 사천왕중 최약체");
                    Console.WriteLine("대충 사천왕이 할만한 대사2");
                }
                else if (Game.bossCount == 2)
                {
                    Console.WriteLine("대충 사천왕이 할만한 대사3");
                }
                else if (Game.bossCount == 3)
                {
                    Console.WriteLine("대충 사천왕이 할만한 대사4");
                }
            }
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.monster = MonsterFactory.CreateMonster(4);
                    Util.PressAnyKey();
                    Game.ChangeScene("Battle");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine();
                    Console.WriteLine("사냥터로 돌아갑니다.");
                    Util.PressAnyKey();
                    Game.ChangeScene("HuntingGround");
                    break;
                default:
                    break;
            }
        }

    }
}
