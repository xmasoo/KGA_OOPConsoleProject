namespace KGA_OOPConsoleProject.SceneFolder
{
    internal class Hunting : Scene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("현재 위치는 사냥터입니다.");
            Console.WriteLine("사냥할 난이도를 고르세요");
            Console.Write("1. 초급(LV10이하 추천) \t 2. 중급(LV10이상 추천) \t 3. 고급(LV20이상 추천)");
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    break;
                default:
                    break;
            }
        }
        public override void Result()
        {

        }


    }
}
