namespace KGA_OOPConsoleProject
{
    internal class Church : Scene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("현재 위치는 성당입니다.");
            Console.WriteLine("무엇을 하시겠습니까?");
            Console.Write("1. HP회복 \t 2. 기도하기 \t 3. 마을로 돌아가기");
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
                    //TODO HP회복하는 코드
                    break;
                case ConsoleKey.D2:
                    //TODO 기도하기 코드
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
