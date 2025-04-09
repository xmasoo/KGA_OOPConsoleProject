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
                    return new Monster(Monster.MonsterName.토끼, 10, 4, 3, 3, 10, 15);
                case 2:
                    return new Monster(Monster.MonsterName.슬라임, 14, 3, 2, 3, 10, 15);
                case 3:
                    return new Monster(Monster.MonsterName.늑대, 17, 5, 3, 3, 10, 15);//이름 체력 공격력 방어력 레벨 경험치 골드
                case 4:
                    return new Monster(Monster.MonsterName.고블린, 50, 10, 5, 10, 20, 25);
                case 5:
                    return new Monster(Monster.MonsterName.오크, 60, 16, 5, 10, 20, 25);
                case 6:
                    return new Monster(Monster.MonsterName.트롤, 70, 20, 3, 15, 20, 25);
                case 7:
                    return new Monster(Monster.MonsterName.뱀파이어, 100, 30, 10, 20, 40, 50);
                case 8:
                    return new Monster(Monster.MonsterName.케르베로스, 120, 35, 15, 20, 40, 50);
                case 9:
                    return new Monster(Monster.MonsterName.Boss1, 100, 20, 5, 10, 70, 150);
                case 10:
                    return new Monster(Monster.MonsterName.Boss2, 150, 30, 10, 15, 100, 200);
                case 11:
                    return new Monster(Monster.MonsterName.Boss3, 200, 40, 20, 20, 120, 300);
                case 12:
                    return new Monster(Monster.MonsterName.Boss4, 250, 50, 25, 30, 150, 500);
                default:
                    return null;
            }


        }
    }
}
