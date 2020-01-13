using System;
using System.Diagnostics;
using System.IO;

namespace HigurashiDaybreakConfig
{
    public class GameRunner
    {
        private string path;

        private string fileDaybreak = "daybreak.exe";
        private string fileDX = "DaybreakDX.exe";

        public GameRunner(String path)
        {
            this.path = path;

        }

        public void runDaybreak()
        {
            if (this.hasDaybreak())
            {
                this._runGame(this.fileDaybreak);
            }
        }

        public void runDX()
        {
            if (this.hasDX())
            {
                this._runGame(this.fileDX);
            }
        }

        public bool hasDaybreak()
        {
            return File.Exists(this.path + "/"+this.fileDaybreak);
        }

        public bool hasDX()
        {
            return File.Exists(this.path + "/" + this.fileDX);
        }

        private void _runGame(String gameFile)
        {
            Process game = Process.Start(this.path+"/"+gameFile);
            long AffinityMask = (long)game.ProcessorAffinity;
            AffinityMask &= 0x0001;
            game.ProcessorAffinity = (IntPtr)AffinityMask;
            game.PriorityClass = ProcessPriorityClass.High;
        }
    }
}
