namespace KGA_OOPConsoleProject
{
    public class HuntingGround : Scene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("현재 위치는 사냥터입니다.");
            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1. 사냥하기 \t 2. 보스 도전 \t 3. 마을로 돌아가기");
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
                    Game.ChangeScene("Hunting");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Boss");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("마을로 돌아갑니다.");
                    Game.ChangeScene("Town");
                    break;
                default:
                    break;
            }
            Util.PressAnyKey();
        }

    }
}
