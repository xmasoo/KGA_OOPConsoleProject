using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    internal class Town : Scene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("마을");
        
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            
        }
        public override void Result()
        {
            
        }
    }
}
