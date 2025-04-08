namespace KGA_OOPConsoleProject
{
    public class Battle : Scene//세세하게 구현은 일단 나중에 우선은 서로 한 대 씩 때리기만 하게
    {
        private ConsoleKey input;
        private Queue<string> queue = new Queue<string>();//나중을 위해 일단 큐를 만들어놓자
        private Monster monster;

        public override void Render()
        {
            monster = Game.monster;

            Console.WriteLine("전투 시작!");
            Console.WriteLine("1. 공격 2. 도망");
            Game.player.ShowStatus();
            monster.ShowStatus();
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
                        {
                            Console.WriteLine($"{monster.Name}이(가) 죽었습니다.");
                            Console.WriteLine($"{monster.Exp} 경험치와 {monster.Gold} 골드를 획득합니다.");
                            Game.player.GainExp(monster.Exp);
                            Game.player.AddGold(monster.Gold);
                            Console.WriteLine($"플레이어의 현재 경험치: {Game.player.Exp}");
                            Console.WriteLine($"플레이어의 현재 골드: {Game.player.Gold}");
                            Util.PressAnyKey();
                            if (Game.bossCount == 3)
                            {
                                Console.WriteLine("모든 보스를 처치했습니다. 게임 클리어!");
                                Game.End();
                                Util.PressAnyKey();
                                return;
                            }
                            else
                            {
                                Game.ChangeScene("HuntingGround");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{monster.Name}의 남은 체력: {monster.CurrentHP}");
                        }
                        break;
                    case "monsterAttack":
                        Game.player.TakeDamage(monster.AttackPower);
                        Console.WriteLine($"{monster.Name}이/가 플레이어에게 {monster.AttackPower}의 피해를 입혔습니다.");
                        if (Game.player.IsDead())
                        {
                            Console.WriteLine("당신은 죽었습니다.");
                            Game.ChangeScene("End");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"플레이어의 현재 체력: {Game.player.CurrentHP}");
                        }
                        break;
                    case "playerRun":
                        Console.WriteLine("플레이어가 도망쳤습니다.");
                        Game.ChangeScene("HuntingGround");
                        Util.PressAnyKey();
                        return;
                    default:
                        break;
                }
                Util.PressAnyKey();
            }
        }

    }
}
