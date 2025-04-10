namespace KGA_OOPConsoleProject
{
    public class Battle : Scene//세세하게 구현은 일단 나중에 우선은 서로 한 대 씩 때리기만 하게
    {
        private ConsoleKey input;
        private Queue<string> queue = new Queue<string>();
        private Monster monster;

        public override void Render()
        {
            monster = Game.monster;

            Console.WriteLine("전투 시작!");
            Console.WriteLine("1. 공격 2. 아이템 사용 3. 도망");
            Game.player.ShowStatus();
            monster.ShowStatus();
            Console.WriteLine();
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
                    queue.Enqueue("playerAttack");
                    queue.Enqueue("monsterAttack");
                    break;
                case ConsoleKey.D2:
                    queue.Enqueue("playerItem");
                    break;
                case ConsoleKey.D3:
                    queue.Enqueue("playerRun");
                    break;
                default:
                    break;
            }
        }
        public override void Result()
        {
            while (queue.Count > 0)
            {
                string action = queue.Dequeue();
                switch (action)
                {
                    case "playerAttack":
                        monster.TakeDamage(Game.player.AttackPower);
                        if (monster.IsDead())
                            Reward();
                        Util.PressAnyKey();
                        break;
                    case "monsterAttack":
                        Game.player.TakeDamage(monster.AttackPower);
                        Util.PressAnyKey();
                        if (Game.player.IsDead())
                        {
                            Game.isRunning = false;
                            return;
                        }
                        break;
                    case "playerItem":
                        UseItem();
                        break;
                    case "playerRun":
                        Console.WriteLine("플레이어가 도망쳤습니다.");
                        Game.ChangeScene("HuntingGround");
                        Util.PressAnyKey();
                        return;
                    default:
                        break;
                }
            }
        }
        public void Reward()
        {
            Console.WriteLine($"{monster.Name}이(가) 죽었습니다.");
            Console.WriteLine();
            Game.player.GainExp(monster.Exp);
            Game.player.AddGold(monster.Gold);

            Console.WriteLine($"플레이어의 현재 경험치: {Game.player.Exp}");
            Console.WriteLine($"플레이어의 현재 골드: {Game.player.Gold}");
            if (monster.IsBoss()) Game.bossCount++;//보스라면 보스카운트 증가
            queue.Clear();//전투가 끝나면 큐를 초기화
            if (Game.bossCount == 4)//사천왕을 다잡았으면 게임 종료
            {
                Game.isRunning = false;
                return;
            }
            else
            {
                Game.ChangeScene("HuntingGround");
                return;
            }
        }

        public void UseItem()
        {
            Console.WriteLine("사용할 아이템 번호를 고르세요 소비 아이템만 사용 가능합니다");
            Console.WriteLine("돌아가기 : 0");
            Game.inventory.ShowItems();
            input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.D0) return;

            if ((int)input - 49 >= 0 && (int)input - 49 < Game.inventory.Count)
            {
                Item item = Game.inventory[(int)input - 49];
                if (!item.Equipable)
                {
                    Game.player.EffectOn(item);
                    Game.inventory.RemoveItem((int)input - 49);
                }
                else
                {
                    Console.WriteLine("전투 중 장비를 장착할 수 없습니다.");
                    Util.PressAnyKey();
                }
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
                Util.PressAnyKey();
            }
        }
    }
}
