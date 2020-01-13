using System;
using System.Windows.Forms;

namespace HigurashiDaybreakConfig
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            DXEnvironment myEnv = new DXEnvironment();
            string path = myEnv.getGameLocation();

            //todo: completely redo this messy structure
            if(path == "")
            {
                MessageBox.Show("Please set your game folder location.","Important");
                FormMyConf fMyConf = new FormMyConf();
                fMyConf.setConfig(ref myEnv);
                Application.Run(fMyConf);
                path = myEnv.getGameLocation();
            }

            if(path != "")
            {
                startApp(path);
            }
        }

        static void startApp(string path)
        {
            Config cfg = new Config(path + "/config.dat");
            AddressList adr = new AddressList(path + "/addresslist.txt");
            GameRunner gr = new GameRunner(path);

            FormConfig mainForm = new FormConfig();
            mainForm.setConfig(cfg);
            mainForm.setAddressList(adr);
            mainForm.setGameRunner(gr);

            Application.Run(mainForm);
        }
    }
}
