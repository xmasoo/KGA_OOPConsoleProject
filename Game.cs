using KGA_OOPConsoleProject.SceneFolder;

namespace KGA_OOPConsoleProject
{
    public static class Game
    {
        public static bool isRunning = true;
        private static Dictionary<string, Scene> sceneDic;
        public static Scene currentScene;
        public static Player player;
        public static int bossCount;
        public static Monster monster;
        public static void ChangeScene(string sceneName)
        {
            currentScene = sceneDic[sceneName];
        }
        public static void Start()
        {
            //초기 설정
            Console.CursorVisible = false;

            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new Title());
            sceneDic.Add("Intro", new Intro());
            sceneDic.Add("Setting", new Setting());
            sceneDic.Add("Town", new Town());
            sceneDic.Add("Church", new Church());
            sceneDic.Add("HuntingGround", new HuntingGround());
            sceneDic.Add("Hunting", new Hunting());
            sceneDic.Add("Shop", new Shop());
            sceneDic.Add("Boss", new Boss());
            sceneDic.Add("Battle", new Battle());

            player = new Player();

            currentScene = sceneDic["Title"];

            bossCount = 0;

        }


        public static void End()
        {
            Console.WriteLine("게임 클리어!");
        }
    }
}
