using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        
        public Item(string name, string description, int price)//아이템효과도 써야함 공격력증가 체력증가라던지
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
