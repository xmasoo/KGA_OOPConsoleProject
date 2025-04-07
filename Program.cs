namespace KGA_OOPConsoleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Util.Transition(2);
            Game.Start();

            while (Game.isRunning)
            {
                Console.Clear();
                Game.currentScene.Render();
                Game.currentScene.Input();
                Game.currentScene.Update();
                Game.currentScene.Result();
            }

            Game.End();
        }
    }
}
