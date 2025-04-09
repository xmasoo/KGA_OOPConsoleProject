namespace KGA_OOPConsoleProject
{
    public class INN : Scene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("현재 위치는 여관입니다.");
            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1. 휴식하기 \t 2. 정비하기 \t 3. 마을로 돌아가기");
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
                    if (Game.player.CurrentHP == Game.player.MaxHP)
                    {
                        Console.WriteLine("체력이 가득 찼습니다.");
                        Console.WriteLine("당신은 쉴 필요가 없습니다.");
                        Util.PressAnyKey();
                    }
                    else
                    {
                        Console.WriteLine("쉬고나니 피로가 가십니다");
                        Game.player.Heal(Game.player.MaxHP);
                        Util.PressAnyKey();
                    }
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Maintenance");
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
