namespace KGA_OOPConsoleProject
{
    public class Inventory
    {
        private List<Item> items {  get; set; }
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
            }
        }
        public void RemoveItem(int index)
        {
            Console.WriteLine($"아이템 {items[index].Name} 이/가 제거되었습니다.");
            items.RemoveAt(index);
        }
        public void ShowItems()
        {
            if (maxSize == 6)
            {
                Console.WriteLine("인벤토리:");
                foreach (var item in items)
                {
                    Console.WriteLine($"- {item.Name}");
                }
            }
            else if (maxSize == 2)
            {
                Console.WriteLine("장비 인벤토리:");
                Console.WriteLine($"무기 - {items[0]}");
                Console.WriteLine($"방어구 - {items[1]}");
            }
            else
            {
                Console.WriteLine("인벤토리가 비어 있습니다.");
            }
        }

    }
}
