using Newtonsoft.Json;
using System;
using System.IO;

namespace HigurashiDaybreakConfig
{
    public class DXEnvironment
    {
        private DXMyConfig myConf;

        public DXEnvironment()
        {
            string myPath = configLoc();
            if (File.Exists(myPath))
            {
                this.myConf = JsonConvert.DeserializeObject<DXMyConfig>(File.ReadAllText(myPath));
            } else
            {
                this.myConf = new DXMyConfig();
            }
        }

        public string getFolder()
        {
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"HigurashiDaybreak/");
            Directory.CreateDirectory(folder);
            return folder;
        }
        
        public string getGameLocation()
        {
            return this.myConf.GameFolder;
        }

        public void setGameLocation(string location)
        {
            this.myConf.GameFolder = location;
            this.saveConfig();
        }

        private string configLoc()
        {
            return Path.Combine(getFolder(), "config.json");
        }

        private void saveConfig()
        {
            File.WriteAllText(configLoc(), JsonConvert.SerializeObject(this.myConf));
        }
    }

    public class DXMyConfig
    {
        public string GameFolder { get; set; } = "";
    }
}
