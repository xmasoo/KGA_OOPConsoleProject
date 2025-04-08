namespace KGA_OOPConsoleProject
{
    public class ShopSelling : Scene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("현재 위치는 상점입니다.");
            Console.WriteLine("판매할 물건을 고르세요. 판매가는 구매가의 90%입니다.");
            Console.WriteLine("돌아가기 : 0");
            for (int i = 0; i < Game.inventory.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Game.inventory[i].Name}");
            }
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            if ((int)input <= Game.inventory.Count + 48 && (int)input > 48) Selling();
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D0:
                    Console.WriteLine("상점으로 돌아갑니다.");
                    Util.PressAnyKey();
                    Game.ChangeScene("Shop");
                    break;
                default:
                    break;
            }
        }
        public void Selling()
        {
            Item item = Game.inventory[(int)input - 49];
            Game.inventory.RemoveItem((int)input - 49);
            Game.player.AddGold(item.Price * 9 / 10);
            Util.PressAnyKey();
        }
    }
}
