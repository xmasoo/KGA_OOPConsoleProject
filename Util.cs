namespace KGA_OOPConsoleProject
{
    public static class Util
    {
        public static void PressAnyKey(string text = "아무 키나 입력하세요")
        {
            Console.WriteLine();
            Console.WriteLine(text);
            Console.ReadKey(true);
            Console.WriteLine();
        }
        public static void DeleteLine()//특정 줄만 지우고 싶을 때
        {
            int cursorPosy = Console.CursorTop;
            Console.SetCursorPosition(0, cursorPosy);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, cursorPosy);
        }
        public static void Transition(string a)//화면전환
        {
            string[] asciiArt = null;
            if (a == "main")//메인화면전환
            {
                asciiArt = new string[]
                        {
                            "  #####    #####      #### ",
                            "      ##       ##    ##    ",
                            "  ##  ##   ##  ##   ##     ",
                            "  #####    #####   ##      ",
                            " #####    ##       ##  ### ",
                            " ##  ##   ##       ##   ## ",
                            " ##   ##  ##        ###### "
                        };        
            }
            else if (a == "battle")//전투화면전환
            {
                asciiArt = new string[]
                {
                    "  _             _    _    _        _",
                    " | |           | |  | |  | |      | |",
                    " | |__    __ _ | |_ | |_ | |  ___ | |",
                    " | '_ l  / _` || __|| __|| | / _ l| |",
                    " | |_) || (_| || |_ | |_ | | | __/|_|",
                    " |_.__/  l__,_|l__| l__| |_| l___|(_)"
                };
            }
                Console.Clear();
                for (int i = 0; i < asciiArt.GetLength(0); i++)
                {
                Console.WriteLine(asciiArt[i]);
                    Thread.Sleep(1);
                }
                Util.PressAnyKey("화면 전환 중... 아무키나 입력하세요");
                Console.Clear();


        }
    }
}
