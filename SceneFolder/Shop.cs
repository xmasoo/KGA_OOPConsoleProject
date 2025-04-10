namespace KGA_OOPConsoleProject
{
    public class Shop : Scene
    {
        private ConsoleKey input;
        public bool isPayed = false;//상점에서 얼마 이상을 쓰면 발생하는 이벤트 용
        public override void Render()
        {
            if (ShopBuying.payedGold >= 500) isPayed = true;
            if (!isPayed)
            {
                Console.WriteLine("\"없는 거 빼고 다 있다네\"");
                Console.WriteLine();
                Console.WriteLine("현재 위치는 상점입니다.");
                Console.WriteLine("무엇을 하시겠습니까?");
                Console.WriteLine("1. 구매 \t 2. 판매 \t 3. 마을로 돌아가기");
            }
            else if (isPayed)
            {
                Console.WriteLine("\"단골이라 말해주는건데 혹시 자네 도박에 관심이 있나?\"");
                Console.WriteLine();
                Console.WriteLine("현재 위치는 상점입니다.");
                Console.WriteLine("무엇을 하시겠습니까?");
                Console.WriteLine("1. 구매 \t 2. 판매 \t 3. 도박장 가기 \t 4. 마을로 돌아가기 ");
            }
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
                    Game.ChangeScene("ShopBuying");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("ShopSelling");
                    break;
                case ConsoleKey.D3:
                    if (!isPayed)
                    {
                        Console.WriteLine();
                        Console.WriteLine("마을로 돌아갑니다.");
                        Util.PressAnyKey();
                        Game.ChangeScene("Town");
                    }
                    else if (isPayed)
                    {
                        Game.ChangeScene("Gamble");
                    }
                    break;
                case ConsoleKey.D4:
                    if (isPayed)
                    {
                        Console.WriteLine();
                        Console.WriteLine("마을로 돌아갑니다.");
                        Util.PressAnyKey();
                        Game.ChangeScene("Town");
                    }
                    break;
                default:
                    break;
            }
        }

    }
}
