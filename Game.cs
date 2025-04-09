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
        public static Inventory inventory;
        public static Inventory equipInventory;
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
            sceneDic.Add("INN", new INN());
            sceneDic.Add("HuntingGround", new HuntingGround());
            sceneDic.Add("Hunting", new Hunting());
            sceneDic.Add("Shop", new Shop());
            sceneDic.Add("Boss", new Boss());
            sceneDic.Add("Battle", new Battle());
            sceneDic.Add("ShopBuying", new ShopBuying());
            sceneDic.Add("ShopSelling", new ShopSelling());
            sceneDic.Add("Maintenance", new Maintenance());

            player = new Player();
            inventory = new Inventory(6);
            currentScene = sceneDic["Title"];

            equipInventory = new Inventory(2);
            equipInventory.AddItem(new Item("나뭇가지", "기본무기", 0, true, "공격력", 0));
            equipInventory.AddItem(new Item("나무판떼기", "기본방어구", 0, true, "방어력", 0));

            bossCount = 0;

        }


        public static void End()
        {
            if(player.IsDead())
            {
                Console.Clear();

                Console.WriteLine("당신은 죽었습니다..");
            }
            else
            {
                Console.Clear();

                Console.WriteLine("모든 보스를 처치했습니다. 게임 클리어!");
            }
        }
    }
}
