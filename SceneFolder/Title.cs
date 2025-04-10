namespace KGA_OOPConsoleProject
{
    public class Title : Scene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("==================================");
            Console.WriteLine("            뭐시기 RPG            ");
            Console.WriteLine("==================================");
            Console.WriteLine("1. 게임 시작");
            Console.WriteLine("2. 설정");
            Console.WriteLine("3. 게임 종료");
            Console.WriteLine("==================================");
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
                    Game.ChangeScene("Intro");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Setting");
                    break;
                case ConsoleKey.D3:
                    Game.ChangeScene("End");
                    break;
                default:
                    break;
            }
        }

    }
}
