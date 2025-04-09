namespace KGA_OOPConsoleProject
{
    public class Maintenance : Scene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("장비 정비 중입니다.");
            Console.WriteLine("장비하거나 사용할 아이템을 고르세요.");
            Console.WriteLine("돌아가기 : 0");
            Game.player.ShowInventory(1);
            for (int i = 0; i < Game.inventory.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Game.inventory[i].Name}");
            }
            Game.player.ShowStatus();
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            if ((int)input <= Game.inventory.Count + 48 && (int)input > 48) EquipItem();
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D0:
                    Game.ChangeScene("INN");
                    break;
                default:
                    break;
            }
        }
        public void EquipItem()
        {
            Item item = Game.inventory[(int)input - 49];
            Item temp;
            if (item.Equipable)
            {
                if (item.Effect == "공격력")
                {
                    temp = Game.equipInventory[0];
                    Game.equipInventory[0] = item;
                    Game.player.EffectOn(item);
                    Game.inventory.RemoveItem((int)input - 49);
                    Game.player.EffectOff(temp);
                    Game.inventory.AddItem(temp);
                }
                else if (item.Effect == "방어력")
                {
                    temp = Game.equipInventory[1];
                    Game.equipInventory[1] = item;
                    Game.player.EffectOn(item);
                    Game.inventory.RemoveItem((int)input - 49);
                    Game.player.EffectOff(temp);
                    Game.inventory.AddItem(temp);
                }
            }
            else if (!item.Equipable)
            {
                Game.player.EffectOn(item);
                Game.inventory.RemoveItem((int)input - 49);

            }
        }


    }
}
