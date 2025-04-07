using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    internal class Inventory
    {
        private List<Item> items;
        private int maxSize;
        public Inventory(int maxSize)
        {
            this.maxSize = maxSize;
            items = new List<Item>();
        }
        public void AddItem(Item item)
        {
            if (items.Count < maxSize)
            {
                items.Add(item);
                Console.WriteLine($"{item.Name}이(가) 인벤토리에 추가되었습니다.");
            }
            else
            {
                Console.WriteLine("인벤토리가 가득 찼습니다.");
            }
        }
        public void RemoveItem(Item item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
                Console.WriteLine($"{item.Name}이(가) 인벤토리에서 제거되었습니다.");
            }
            else
            {
                Console.WriteLine("인벤토리에 해당 아이템이 없습니다.");
            }
        }
        public void ShowItems()
        {
            Console.WriteLine("인벤토리:");
            foreach (var item in items)
            {
                Console.WriteLine($"- {item.Name}");
            }
        }
    }
}
