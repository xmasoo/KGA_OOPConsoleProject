namespace KGA_OOPConsoleProject
{
    public static class Game
    {
        public static bool isRunning = true;
        private static Dictionary<string, Scene> sceneDic;
        public static Scene currentScene = new Scene1();

        public static void ChangeScene(string sceneName)
        {
            currentScene = sceneDic[sceneName];
        }
        public static void Start()
        {
            //타이틀   
            Title.ShowTitle();

            //초기 설정
            Dictionary<string, Scene> sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("1", new Scene1());
            sceneDic.Add("2", new Scene2());
            sceneDic.Add("3", new Scene3());

            //인트로

            Title.ShowIntro();
        }


        public static void End()
        {

        }
    }
}
