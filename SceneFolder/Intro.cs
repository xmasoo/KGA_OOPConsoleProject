using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public class Intro : Scene
    {
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("당신은 신입 모험가입니다..");
            Console.WriteLine("사천왕을 잡는 것이 당신의 목표입니다.");
            Console.WriteLine("성장하고 강해져서 게임을 클리어해주세요.");

            Util.PressAnyKey();
        }
        public override void Input()
        {
            
        }
        public override void Update()
        {
            
        }
        public override void Result()
        {
            Game.ChangeScene("Town");
        }
    
    }
}
