using System.IO;
using System.Diagnostics;
using LitJson;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncherLibrary
{
    public class Launcher
    {
        public static void PlayGame()
        {
            Process.Start(Directory.GetCurrentDirectory() + "/Start.exe");
        }

        public static void MapChange()
        {
            Process.Start(Directory.GetCurrentDirectory() + "/HeroesAwaken_MAP_Changer.exe");
        }

        public static void LaunchWebsite(string url)
        {
            Process.Start(url);
        }
    }
}
