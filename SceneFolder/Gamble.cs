namespace KGA_OOPConsoleProject
{
    public class Gamble : Scene
    {
        private ConsoleKey input;
        private int betting;
        private Random random;
        public override void Render()
        {
            Console.WriteLine("\"돈놓고 돈먹기~\"");
            Console.WriteLine();
            Console.WriteLine("현재 위치는 도박장입니다.");
            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1. 도박하기 \t 2. 상점으로 돌아가기");
            Game.player.ShowStatus();
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
                    Console.WriteLine("도박할 금액을 적으세요");
                    int.TryParse(Console.ReadLine(), out betting);
                    break;
                default:
                    break;
            }
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    if (betting == 0) Console.WriteLine("잘못 입력하였거나 0원을 베팅하셨습니다.");
                    else if (betting > Game.player.Gold) Console.WriteLine("소지금보다 많은 금액을 베팅할 수 없습니다.");
                    else
                    {
                        random = new Random();
                        Console.WriteLine($"{betting} 골드를 베팅하셨습니다.");
                        Game.player.Gold -= betting;
                        int n = random.Next(50, 150);
                        betting = betting * n / 100;
                        if (n > 100) Console.WriteLine("운이 좋으시군요!");
                        else Console.WriteLine("다음엔 따실 수 있을 거에요.");
                        Game.player.AddGold(betting);
                    }
                    Util.PressAnyKey();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine();
                    Console.WriteLine("상점으로 돌아갑니다");
                    Util.PressAnyKey();
                    Game.ChangeScene("Shop");
                    break;
                default:
                    break;
            }
        }

    }
}
