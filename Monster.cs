namespace KGA_OOPConsoleProject
{
    internal class Monster
    {
        private int maxHP;
        public int MaxHP { get { return maxHP; } set { maxHP = value; } }

        private int currentHP;
        public int CurrentHP { get { return currentHP; } set { currentHP = value; } }

        private int attackPower;
        public int AttackPower { get { return attackPower; } set { attackPower = value; } }

        private int defensePower;
        public int DefensePower { get { return defensePower; } set { defensePower = value; } }

        private string name;
        public string Name { get { return name; } set { name = value; } }

        private int level;
        public int Level { get { return level; } set { level = value; } }

        private int experience;
        public int Experience { get { return experience; } set { experience = value; } }

        private int gold;

        public int Gold { get { return gold; } set { gold = value; } }


        public Monster()
        {
            string Name;
            int MaxHP;
            int CurrentHP;
            int AttackPower;
            int DefensePower;
            int Level;
            int Experience;
            int Gold;
        }
    }
}
