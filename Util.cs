﻿namespace KGA_OOPConsoleProject
{
    public static class Util
    {
        public static void PressAnyKey(string text = "아무 키나 입력하세요")
        {
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
        public static void Transition(int a)//화면전환
        {
            if (a == 1)
            {
                Console.Clear();
                Console.WriteLine("화면 전환 중...");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
            else if (a == 2)//메인화면전환
            {
                string[] asciiArt = new string[]
                        {
                            "                ;;;  .  ,,...;;;;;;;              ",
                            "               -   .   .~;*;;!;!!;:;              ",
                            "               :      ,  :!;;!:!;!!;.   .         ",
                            "              :       ,:!:!!:-,:;;*;,             ",
                            "              ~  .-  ,;!;!;;:!;~;:;;:    .        ",
                            "              .  -~ ,!!;;*:;;;,!:;!!!             ",
                            "              :;!:~;!!!;:;!;;:;!!;!;*             ",
                            "             .;!:!;;;!~!:~~:!!;;:!;!!,            ",
                            "             !;;:~~,-:~~~~~:;;;~-;!;;;            ",
                            "            ,;;;:~~~:~~~~~::!::~~:;;!;            ",
                            "            ;;;;-~,,-:::~-,-,~:--:;;!!~           ",
                            "           ,;:::::,.::.-:::~:~:::~:!!::           ",
                            "           ;:;:~~,  ~,,,:~~:~:~~~~~~*:;.          ",
                            "          .*!~~~,   ~:::~~::,~~~~~:;::;-          ",
                            "          ;~:~:~    ;:~:~~~- ;~~~~~~~::~          ",
                            "         .:!,:~.    ~,~~~::, .~~:~~~~!;:          ",
                            "         :~~:::     ~,-~:~~.  ~::~~~::!:~         ",
                            "         ~; ~::      ..:::~   ;:~~:~~:;*;         ",
                            "        .;--~:~.              ,~~~~~~~:!;         ",
                            "        :!.-:~:.  .:,    -:::::~~~~~~~;~!         ",
                            "    .   :,.-~~~.~:~           ;~~~~:~~,!!.        ",
                            "       .;. :~~~,              ::~~~~~~.*!.        ",
                            "       -!. :~~~     . .       ~~~:~~:~.~-,        ",
                            "       -  ,~:~~     ,.  -     ::~~~~~. ,;~        ",
                            "       :. -~~:~               ~~~~~~~. .;~        ",
                            "       :..-~::~              .~~~~::;.  -.        ",
                            "       , .-~~:~~             .~~:~~:.   ,         ",
                            "   .   .  :~::~~~,           ~~~~::~ ....         ",
                            "        . :~~~::~~:.       .-:~~~~~~.. ,~         ",
                            "        ..:~::~~~:~:~-    -~~;~~~~~~ ..:          ",
                            "         -~~~~~~~~~~:.  .~.~~~~~:~~.  :.          ",
                            "         ,~~~:;~~~~:** ,***;~:~~:~:..;.           ",
                            "          ~:~~~~~~:=$=-=**=!:~:~~~~-~.            ",
                            "          ::~~~~::-**=!*$*=*:~~:~~;-              ",
                            "          :~::~~~,.*:!**.=!,,:~~:~.               ",
                            "          ~~~~~~-- ,,~=; -  -::~~:                ",
                            "          :~~;~~!** ;:! !  :!:~:~-                ",
                            "          ~~~~:;!=*!,:~ .;,=*~::~:                ",
                            "          ~~:~:;=$=- :~. ~=$=~~~:::               ",
                            "          ~:~:~;*$*  !,;:~*$*~~~;*;:              ",
                            "         .:~~::!==::!~ *-.!=!:~:;!;;;,            ",
                            "        -!::~::*=$  !  ~ .!=!~~~;;!;;!:           ",
                            "       ;:;:~~~;=$=  ;  , .!=!~~~:;;;;;::.         ",
                            "     .;;!!~:::;==!!!, .- !!=!~::;;!;;;*!:~        ",
                            "    ~;;;;;~:~~===***   ,***$*~~!;:;!;;;!!!:.      ",
                            "   ~;;!;;;:~~~$=$*$*,  ;**=$*~~;!:;;;!!;:;!;-     ",
                            "  ~!!;!!!~~~::$==***:;!***;$*~~~=~!;;!;!;;;!;- .  ",
                            " .!~;;!;:;~~~:=$=;=**;;***;$*~~~~:-;;:!;!;;!!:,   ",
                            " ;::;;;;;~~:~*$=$=**~~.**=*=$:~::~  ;!;:;:;;*;:   ",
                            ".;!;!;!;~~~~:*$$$$=*.  !=**$=~~~~~~-.;;;;!;;;;*,  ",
                            "-!!;!!;:~:~~!====*=*   -*====!~~~~~:-~!;!;;!;:;!~  ",
                        };

                Console.Clear();
                for (int i = 0; i < asciiArt.GetLength(0); i++)
                {
                    for (int j = 0; j < asciiArt[i].Length; j++)
                    {
                        Console.Write(asciiArt[i][j]);
                    }
                        Thread.Sleep(1);
                    Console.WriteLine();
                }
                Util.PressAnyKey("화면 전환 중...");
                Console.Clear();
            }
            else if (a == 3)//전투화면전환
            {
                string[] asciiArt = new string[]
                {
                    "  ,--.   ,--.  ,--.   ,--.  ,--.   ,--.  ,--.   ,--.",
                    " /    \\ /    \\ |  |   |  |  |  |   |  |  |  |   |  |",
                    "|  ()  |  ()  ||  |   |  |  |  |   |  |  |  |   |  |",
                    "|      \\      ||  '--.|  '--.|  '--.|  '--.|  '--.|",
                    "|       \\     ||     ||     ||     ||     ||     ||",
                    "`--------`---' `-----'`-----'`-----'`-----'`-----'",
                };
                Console.Clear();
                for (int i = 0; i < asciiArt.GetLength(0); i++)
                {
                    for (int j = 0; j < asciiArt[i].Length; j++)
                    {
                        Console.Write(asciiArt[i][j]);
                    }
                    Thread.Sleep(1);
                    Console.WriteLine();
                }
                Util.PressAnyKey("화면 전환 중...");
                Console.Clear();
            }


        }
    }
}
