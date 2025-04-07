namespace KGA_OOPConsoleProject
{
    public static class Game
    {
        public static bool isRunning = true;
        private static Dictionary<string, Scene> sceneDic;
        public static Scene currentScene;

        public static void ChangeScene(string sceneName)
        {
            currentScene = sceneDic[sceneName];
        }
        public static void Start()
        {
            //초기 설정
            Console.CursorVisible = false;
            //Console.SetWindowSize(40, 30);

            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new Title());
            sceneDic.Add("Intro", new Intro());
            sceneDic.Add("Setting", new Setting());
            sceneDic.Add("Town", new Town());



            currentScene = sceneDic["Title"];



        }


        public static void End()
        {

        }
    }
}
