using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    internal class Scene1 : Scene
    {
        public override void Render()
        {
            Console.WriteLine("Rendering Scene 1");
            // Add rendering logic here
        }
        public override void Input()
        {
            Console.WriteLine("Input for Scene 1");
            // Add input handling logic here
        }
        public override void Update()
        {
            Console.WriteLine("Updating Scene 1");
            // Add update logic here
        }
        public override void Result()
        {
            Console.WriteLine("Result of Scene 1");
            // Add result handling logic here
        }
    }
}
