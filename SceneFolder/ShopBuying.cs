namespace KGA_OOPConsoleProject
{
    public class ShopBuying : Scene
    {
        private ConsoleKey input;
        private int cursorPosx = 0;
        private int cursorPosy = 5;
        private int m = 5;//세로 길이 조절용
        private int n = 16;//가로 길이 조절용으로 변수 따로 만듬
        private Item[,] shopItem;
        int y;//y = cursorPosy - m 이거 매번쓰기 싫어서
        int x;//x = cursorPosx / n 이거 매번쓰기 싫어서
        public override void Render()
        {
            y = cursorPosy - m;
            x = cursorPosx / n;
            shopItem = new Item[3, 4];//아이템 추가할거면 배열크기 늘리고 밑에 추가하면 됨
            shopItem[0, 0] = new Item("나무 검", "보통 검이다", 100, true, "공격력", 5);
            shopItem[0, 1] = new Item("철 검   ", "단단한 검이다", 200, true, "공격력", 10);
            shopItem[0, 2] = new Item("티타늄 검", "단단하고 가벼워서 휘두르기 좋다", 300, true, "공격력", 50);
            shopItem[1, 0] = new Item("나무 방패", "보통 방패다", 100, true, "방어력", 3);
            shopItem[1, 1] = new Item("철 방패 ", "단단한 방패다", 200, true, "방어력", 10);
            shopItem[1, 2] = new Item("티타늄 방패", "어중간한 공격으로는 흡집도 나지 않을 거 같다", 500, true, "방어력", 30);
            shopItem[2, 0] = new Item("포션    ", "먹으면 체력이 회복된다", 50, false, "체력", 30);
            shopItem[2, 1] = new Item("엘릭서  ", "먹으면 체력이 많이 회복된다", 150, false, "체력", 70);
            shopItem[2, 2] = new Item("사탕", "달달허이 최대 체력이 조금 오른다", 200, false, "최대체력", 20);

            shopItem[0, 3] = new Item("치트 검", "즉사치트", 1000, true, "공격력", 500);
            shopItem[1, 3] = new Item("식용 돌", "꼭꼭 씹어먹으면 방어력이 오른다", 250, false, "방어력", 3);
            shopItem[2, 3] = new Item("프로틴  ", "먹으면 근육이 올라온다", 200, false, "공격력", 5);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("현재 위치는 상점입니다.");
            Console.WriteLine("구매할 물건을 고르세요. 구매할 물건에 커서를 두고 스페이스바를 누르면 돼요");
            Console.WriteLine("돌아가기 : 0");
            for (int i = 0; i < shopItem.GetLength(0); i++)
            {
                for (int j = 0; j < shopItem.GetLength(1); j++)
                {
                    Console.Write($" {i * shopItem.GetLength(1) + j + 1}. {shopItem[i, j].Name}\t");
                }
                Console.WriteLine();
            }
            //Console.WriteLine($"  1. {shopItem[0, 0].Name} \t 2. {shopItem[0, 1].Name} \t 3. {shopItem[0, 2].Name}");
            //Console.WriteLine($"  4. {shopItem[1, 0].Name} \t 5. {shopItem[1, 1].Name} \t 6. {shopItem[1, 2].Name}");
            //Console.WriteLine($"  7. {shopItem[2, 0].Name} \t 8. {shopItem[2, 1].Name} \t 9. {shopItem[2, 2].Name}");//상점이 많아지면 for문 써도 좋을듯
            Console.WriteLine();

            Console.WriteLine($"{shopItem[y, x].Description} / 가격 : {shopItem[y, x].Price} 골드"); //아이템설명이나오게
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
                Console.SetCursorPosition(0, 12 + m + Game.inventory.Count);//아이템 상황에 따라 출력 위치 조절
                Console.WriteLine();
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
                    cursorPosy = cursorPosy == m ? m + shopItem.GetLength(0) - 1 : cursorPosy - 1;
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    cursorPosy = cursorPosy == m + shopItem.GetLength(0) - 1 ? m : cursorPosy + 1;
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    cursorPosx = cursorPosx == 0 ? (shopItem.GetLength(1) - 1) * n : cursorPosx - n;
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    cursorPosx = cursorPosx == (shopItem.GetLength(1) - 1) * n ? 0 : cursorPosx + n;
                    break;
            }
        }

        public void Buy()
        {
            bool isPayed = false;
            Console.SetCursorPosition(0, 12 + m + Game.inventory.Count);
            if (Game.inventory.Count == 6)
                Console.WriteLine("인벤토리가 가득 찼습니다.");
            else
                isPayed = Game.player.SpendGold(shopItem[y, x].Price);
            if (isPayed) Game.inventory.AddItem(shopItem[y, x]);
            Util.PressAnyKey();
        }
    }
}
