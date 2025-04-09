namespace KGA_OOPConsoleProject
{
    public class ShopBuying : Scene
    {
        private ConsoleKey input;
        private int cursorPosx = 0;
        private int cursorPosy = 5;
        private int m = 5;//세로 길이 조절용
        private int n = 15;//가로 길이 조절용으로 변수 따로 만듬
        private Item[,] shopItem;
        int y;//y = cursorPosy - m 이거 매번쓰기 싫어서
        int x;//x = cursorPosx / n 이거 매번쓰기 싫어서
        public override void Render()
        {
            y = cursorPosy - m;
            x = cursorPosx / n;
            shopItem = new Item[3, 3];
            shopItem[0, 0] = new Item("나무 검", "보통 검이다", 100,true,"공격력",3);
            shopItem[0, 1] = new Item("철 검", "단단한 검이다", 200, true, "공격력", 5);
            shopItem[0, 2] = new Item("티타늄 검", "단단하고 가벼워서 휘두르기 좋다", 300, true, "공격력", 10);
            shopItem[1, 0] = new Item("나무 방패", "보통 방패다", 100, true, "방어력", 3);
            shopItem[1, 1] = new Item("철 방패", "단단한 방패다", 200, true, "방어력", 5);
            shopItem[1, 2] = new Item("아이언맨 슈트", "어중간한 공격으로는 흡집도 나지 않을 거 같다", 300, true, "방어력", 10);
            shopItem[2, 0] = new Item("포션", "먹으면 체력이 회복된다", 50, false, "heal", 30);
            shopItem[2, 1] = new Item("엘릭서", "먹으면 체력이 50퍼센트 회복된다", 200, false, "heal%", 50);
            shopItem[2, 2] = new Item("사탕", "달다", 300, false, "hp", 10);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("현재 위치는 상점입니다.");
            Console.WriteLine("구매할 물건을 고르세요. 구매할 물건에 커서를 두고 스페이스바를 누르면 돼요");
            Console.WriteLine("돌아가기 : 0");
            Console.WriteLine($"  1. {shopItem[0, 0].Name} \t 2. {shopItem[0, 1].Name} \t 3. {shopItem[0, 2].Name}");
            Console.WriteLine($"  4. {shopItem[1, 0].Name} \t 5. {shopItem[1, 1].Name} \t 6. {shopItem[1, 2].Name}");
            Console.WriteLine($"  7. {shopItem[2, 0].Name} \t 8. {shopItem[2, 1].Name} \t 9. {shopItem[2, 2].Name}");//상점이 많아지면 for문 써도 좋을듯
            Console.WriteLine();

            Console.WriteLine($"{shopItem[y, x].Description} 가격 : {shopItem[y, x].Price} 골드"); //아이템설명이나오게
            Game.player.ShowStatus();
            Game.player.ShowInventory();
            PrintCursor();
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            if (input == ConsoleKey.Spacebar)
                Buy();

            else
                ChangeCursorPos();

        }
        public override void Result()
        {
            if (input == ConsoleKey.D0)
            {
                Console.SetCursorPosition(0, 19);
                Console.WriteLine("상점으로 돌아갑니다.");
                Util.PressAnyKey();
                Game.ChangeScene("Shop");
            }
        }
        public void PrintCursor()
        {
            Console.SetCursorPosition(cursorPosx, cursorPosy);
            Console.WriteLine(">");
        }

        public void ChangeCursorPos()
        {

            switch (input)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    cursorPosy = cursorPosy == m ? m + 2 : cursorPosy - 1;
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    cursorPosy = cursorPosy == m + 2 ? m : cursorPosy + 1;
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    cursorPosx = cursorPosx == 0 ? 2 * n : cursorPosx - n;
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    cursorPosx = cursorPosx == 2 * n ? 0 : cursorPosx + n;
                    break;
            }
        }

        public void Buy()
        {
            bool isPayed = false;
            Console.SetCursorPosition(0, 19);
            if (Game.inventory.Count == 6)
                Console.WriteLine("인벤토리가 가득 찼습니다.");
            else
                isPayed = Game.player.SpendGold(shopItem[y, x].Price);
            if (isPayed) Game.inventory.AddItem(shopItem[y, x]);
            Util.PressAnyKey();
        }
    }
}
