using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigurashiDaybreakConfig
{
    public class AddressList
    {
        private string fileLocation;
        private string[] addresses;

        public AddressList(string filelocation)
        {
            //see if I can watch this file for changes & reload
            //form still needs to reload it though...
            this.fileLocation = filelocation;
            string text = File.ReadAllText(this.fileLocation, Encoding.UTF8);
            addresses = text.Split(new[] { System.Environment.NewLine },
            StringSplitOptions.None);
            Console.WriteLine(addresses);
        }

        public string[] getAddresses()
        {
            return this.addresses;
        }

        public string getFileLocation()
        {
            return this.fileLocation;
        }
    }
}
