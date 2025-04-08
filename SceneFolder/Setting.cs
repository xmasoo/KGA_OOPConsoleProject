namespace KGA_OOPConsoleProject
{
    public class Setting : Scene
    {
        private ConsoleKey input;
        int cursorPos = 2;
        int option1Count = 5;
        int option2Count = 5;
        public override void Render()
        {
            Console.WriteLine("설정");
            Console.WriteLine("  1    option1      10");
            PrintGauge(option1Count);
            Console.WriteLine("  1    option2      10");
            PrintGauge(option2Count);
            Console.WriteLine();
            Console.WriteLine("  뒤로가기");
            Console.WriteLine();
            Console.WriteLine("아직은 의미없는 기능 나중에 추가하면 추가설명");
            Console.WriteLine("아무 지점에서나 0을 누르거나 뒤로가기에 커서를 두고 스페이스바를 누르면 타이틀로 돌아갑니다.");

            PrintCursor();
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            ChangeCursorPos();
            PrintCursor();
        }

        public override void Result()
        {
            if (input == ConsoleKey.D0) Game.ChangeScene("Title");
            if (cursorPos == 6 && input == ConsoleKey.Spacebar) Game.ChangeScene("Title");
        }

        public void PrintCursor()//커서 위치는 유동적이라서 따로 메서드를 생성
        {
            Console.SetCursorPosition(0, cursorPos);
            Console.WriteLine(">");
        }

        public void ChangeCursorPos()//방향키 입력에 따라 게이지 증가 혹은 감소
        {
            switch (input)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    cursorPos = cursorPos == 2 ? 6 : cursorPos - 2;
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    cursorPos = cursorPos == 6 ? 2 : cursorPos + 2;
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    if (cursorPos == 2 && option1Count > 1) option1Count--;
                    else if (cursorPos == 4 && option2Count > 1) option2Count--;
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    if (cursorPos == 2 && option1Count < 10) option1Count++;
                    else if (cursorPos == 4 && option2Count < 10) option2Count++;
                    break;
            }
        }

        public void PrintGauge(int count)//게이지 출력 메서드
        {
            Console.Write("  ");
            for (int i = 0; i < count; i++)
            {
                Console.Write("ㅁ");
            }
            Console.WriteLine();
        }
    }
}
