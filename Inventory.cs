namespace KGA_OOPConsoleProject
{
    public class Inventory
    {
        private List<Item> items { get; set; }
        private int maxSize;
        public int Count { get { return items.Count; } }
        public Inventory(int maxSize)
        {
            this.maxSize = maxSize;
            items = new List<Item>();
        }
        public Item this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }
        public void AddItem(Item item)
        {
            if (items.Count < maxSize)
            {
                items.Add(item);
                Console.WriteLine($"{item.Name}이/가 인벤토리에 추가되었습니다.");
            }
            else
            {
                Util.DeleteLine();
                Console.WriteLine("인벤토리가 가득 찼습니다.");
                Util.DeleteLine();
            }
        }
        public void RemoveItem(int index)
        {
            //Console.WriteLine($"아이템 {items[index].Name} 이/가 제거되었습니다.");
            items.RemoveAt(index);
        }
        public void ShowItems()
        {
            if (maxSize == 6)
            {
                Console.WriteLine("인벤토리:");
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {items[i].Name}");
                }
            }
            else if (maxSize == 2)
            {
                if (items.Count > 0 && items[0] != null)
                    Console.WriteLine($"무기 - {items[0].Name}");
                else
                    Console.WriteLine("무기 - 없음");

                if (items.Count > 0 && items[1] != null)
                    Console.WriteLine($"방어구 - {items[1].Name}");
                else
                    Console.WriteLine("방어구 - 없음");
            }
            else
            {
                Util.DeleteLine();
                Console.WriteLine("인벤토리가 비어 있습니다.");
            }
        }

    }
}
