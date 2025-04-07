namespace KGA_OOPConsoleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game.Start();

            while (Game.isRunning)
            {
                Game.currentScene.Render();
                Game.currentScene.Input();
                Game.currentScene.Update();
                Game.currentScene.Result();
            }

            Game.End();
        }
    }
}
