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
        public static void DeleteLine()//특정 줄만 지우고 싶을 때 만들었는데 굳이 안쓰는듯
        {
            int cursorPosy = Console.CursorTop;
            Console.SetCursorPosition(0, cursorPosy);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, cursorPosy);
        }

        public static void Transition(string a)//화면전환
        {
            string[] asciiArt = null;
            switch (a)
            {
                case "main":
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
                    break;
                case "gameover":
                    asciiArt = new string[]
                {
                    "   ___        ___        _   __        ___        ___                ___        __    ",
                    " //   ) )   //   ) )   // ) )  ) )   //___) )   //   ) ) ||  / /   //___) )   //  ) ) ",
                    "((___/ /   //   / /   // / /  / /   //         //   / /  || / /   //         //       ",
                    " //__     ((___( (   // / /  / /   ((____     ((___/ /   ||/ /   ((____     //        "
                };
                    break;
                case "clear":
                    asciiArt = new string[]
                {
                    "                            _  _                                                                                   _          ",
                    "                           (_)(_)                                                                                 (_)         ",
                    "       _  _  _                (_)              _  _  _  _            _  _  _            _       _  _              (_)         ",
                    "     _(_)(_)(_)               (_)             (_)(_)(_)(_)_         (_)(_)(_) _        (_)_  _ (_)(_)             (_)         ",
                    "    (_)                       (_)            (_) _  _  _ (_)         _  _  _ (_)         (_)(_)                   (_)         ",
                    "    (_)                       (_)            (_)(_)(_)(_)(_)       _(_)(_)(_)(_)         (_)                                  ",
                    "    (_)_  _  _              _ (_) _          (_)_  _  _  _        (_)_  _  _ (_)_        (_)                       _          ",
                    "      (_)(_)(_)            (_)(_)(_)           (_)(_)(_)(_)         (_)(_)(_)  (_)       (_)                      (_)         "
                };
                    break;

            }

            Console.Clear();
            for (int i = 0; i < asciiArt.GetLength(0); i++)
            {
                Console.WriteLine(asciiArt[i]);
                Thread.Sleep(1);
            }
            PressAnyKey("화면 전환 중... 아무키나 입력하세요");
            Console.Clear();


        }
    }
}
