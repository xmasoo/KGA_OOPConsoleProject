namespace KGA_OOPConsoleProject
{
    public class Church : Scene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("현재 위치는 성당입니다.");
            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1. HP회복 \t 2. 기도하기 \t 3. 마을로 돌아가기");
            Console.WriteLine();
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
                    Console.WriteLine("사제가 당신을 치유해줍니다.");
                    Game.player.Heal(Game.player.MaxHP);
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("기도를 합니다.");
                    Thread.Sleep(1000);
                    Console.WriteLine("신앙심이 오르는 기분이 듭니다.");
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
