using System;
using System.IO;
using System.Windows.Forms;
using clothInfoGen.processors;
using GTA;
using Console = GTA.Console;

namespace clothInfoGen
{
    public class Main : Script
    {
        private static string BasePath = "scripts/clothgen/";
        public static readonly Storage Storage = new Storage();
        
        public Main()
        {
            this.Tick += this.OnTick;
            this.KeyUp += this.OnKeyUp;
        }

        private void OnTick(object sender, EventArgs e)
        {
            Game.Player.WantedLevel = 0;
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.NumPad0) {
                GTA.UI.Screen.ShowNotification("~y~Starting...");
                
                PedLoaderProcessor.Process();
                OutputProcessor.Process();
                
                GTA.UI.Screen.ShowNotification("~g~clothesData.json generated...");
            }
        }

        public static string GetPath(string path, bool create = false)
        {
            string resultPath = Path.Combine(BasePath, path);
            Console.Info(resultPath);
            if (create)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(resultPath));
            }
            
            return resultPath;
        }
    }
}