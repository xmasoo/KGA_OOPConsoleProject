namespace KGA_OOPConsoleProject
{
    public class Item
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Price { get; private set; }

        public bool Equipable { get;private set; }
        public string Effect { get; private set; }
        public int EffectValue { get; private set; }

        public Item(string name, string description, int price, bool equipable, string effect, int effectvalue)
        {
            Name = name;
            Description = description;
            Price = price;
            Equipable = equipable;//장착 가능하다면 true 아니면 false
            Effect = effect;
            // 공격력 방어력 체력 heal 등으로 표시
            EffectValue = effectvalue;
        }
    }
}
