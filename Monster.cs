namespace KGA_OOPConsoleProject
{
    public class Monster
    {

        public enum MonsterName
        {
            토끼 = 1,
            슬라임,
            늑대,

            고블린,
            오크,
            트롤,

            뱀파이어,
            케르베로스,

            Boss1,
            Boss2,
            Boss3,
            Boss4
        }

        public MonsterName Name { get; set; }

        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int AttackPower { get; set; }
        public int DefensePower { get; set; }
        public int Level { get; set; }
        public int Exp { get; set; }
        public int Gold { get; set; }

        public Monster(MonsterName name, int maxHP, int attackPower, int defensePower, int level, int exp, int gold)
        {
            Name = name;
            MaxHP = maxHP;
            CurrentHP = maxHP;
            AttackPower = attackPower;
            DefensePower = defensePower;
            Level = level;
            Exp = exp;
            Gold = gold;
        }

        public void TakeDamage(int damage)
        {
            int actualDamage = Math.Max(1, damage - DefensePower);
            CurrentHP -= actualDamage;
            if (CurrentHP < 0) CurrentHP = 0;
            Console.WriteLine($"{Name}은(는) {actualDamage}의 피해를 입었습니다! 남은 HP: {CurrentHP}");
        }

        public bool IsDead()
        {
            return CurrentHP <= 0;
        }
        public bool IsBoss()
        {
            return MonsterFactory.monsterNum >= 9;
        }
        public void ShowStatus()
        {
            Console.WriteLine($"이름 : {Name} 레벨: {Level}, HP: {CurrentHP}/{MaxHP}, 공격력: {AttackPower}, 방어력: {DefensePower}");
        }
    }
}
