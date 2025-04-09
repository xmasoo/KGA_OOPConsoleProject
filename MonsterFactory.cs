namespace KGA_OOPConsoleProject
{
    public static class MonsterFactory
    {
        public static Random random = new Random();
        public static int monsterNum;// = random.Next(1, 4)
        static Monster monster;
        public static Monster CreateMonster(int num)//몬스터생성기 1초급 2중급 3상급 종류중 랜덤하게 4보스는 차례대로 나오게함 
        {
            if (num == 1)
            {
                monsterNum = random.Next(1, 4);
            }
            else if (num == 2)
            {
                monsterNum = random.Next(4, 7);
            }
            else if (num == 3)
            {
                monsterNum = random.Next(7, 9);
            }
            else if (num == 4)
            {
                monsterNum = Game.bossCount + 9;
            }

            switch (monsterNum)
            {
                case 1:
                    return new Monster(Monster.MonsterName.Rabbit, 10, 4, 3, 3, 10, 15);
                case 2:
                    return new Monster(Monster.MonsterName.Slime, 10, 4, 3, 3, 10, 15);
                case 3:
                    return new Monster(Monster.MonsterName.Wolf, 10, 4, 3, 3, 10, 15);//이름 체력 공격력 방어력 레벨 경험치 골드
                case 4:
                    return new Monster(Monster.MonsterName.Goblin, 50, 6, 5, 5, 20, 25);
                case 5:
                    return new Monster(Monster.MonsterName.Orc, 50, 6, 5, 5, 20, 25);
                case 6:
                    return new Monster(Monster.MonsterName.Troll, 50, 6, 5, 5, 20, 25);
                case 7:
                    return new Monster(Monster.MonsterName.Vampire, 70, 8, 7, 7, 40, 35);
                case 8:
                    return new Monster(Monster.MonsterName.Cerberus, 70, 8, 7, 7, 40, 35);
                case 9:
                    return new Monster(Monster.MonsterName.Boss1, 100, 10, 9, 9, 70, 50);
                case 10:
                    return new Monster(Monster.MonsterName.Boss2, 120, 12, 10, 10, 100, 60);
                case 11:
                    return new Monster(Monster.MonsterName.Boss3, 150, 15, 12, 12, 120, 70);
                case 12:
                    return new Monster(Monster.MonsterName.Boss4, 200, 20, 15, 15, 150, 100);
                default:
                    return null;
            }


        }
    }
}
