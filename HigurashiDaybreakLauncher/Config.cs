using System;
using System.Collections;
using System.IO;
using System.Net;

namespace HigurashiDaybreakConfig
{
    public class Config
    {
        private byte[] config;
        private string configLocation;

        const int CFG_CHAT = 248;
        const int CFG_DELAY = 245;
        const int CFG_PORT = 246;
        const int CFG_IP = 225;

        const int CFG_SHADING = 212;
        const int CFG_SHADOWS = 213;
        const int CFG_TEXTURE = 214;
        const int CFG_SCREEN = 215;

        const int CFG_NAME = 216;
        const int CFG_PAGES = 224;

        const int CFG_VOLMUSIC = 233;
        const int CFG_VOLVOICE = 237;
        const int CFG_VOLSOUND = 241;


        public Config(string filelocation)
        {
            this.configLocation = filelocation;
            this.reload();
        }

        public void reload()
        {
            this.config = File.ReadAllBytes(this.configLocation);
        }

        public void save()
        {
            File.WriteAllBytes(configLocation, config);
        }


        public bool getChat()
        {
            return _getBool(CFG_CHAT);
        }
        public void setChat(bool set)
        {
            _setBool(CFG_CHAT, set);
        }
        public bool getShading()
        {
            return _getBool(CFG_SHADING);
        }
        public void setShading(bool set)
        {
            _setBool(CFG_SHADING, set);
        }
        public bool getShadows()
        {
            return _getBool(CFG_SHADOWS);
        }
        public void setShadows(bool set)
        {
            _setBool(CFG_SHADOWS, set);
        }
        public bool getTexture()
        {
            return _getBool(CFG_TEXTURE);
        }
        public void setTexture(bool set)
        {
            _setBool(CFG_TEXTURE, set);
        }
        public bool getScreen()
        {
            return _getBool(CFG_SCREEN);
        }
        public void setScreen(bool set)
        {
            _setBool(CFG_SCREEN, set);
        }


        public int getDelay()
        {
            return _getInt(CFG_DELAY);
        }
        public void setDelay(int num)
        {
            _setInt(CFG_DELAY, num);
        }
        public int getVolMusic()
        {
            return _getInt(CFG_VOLMUSIC);
        }
        public void setVolMusic(int num)
        {
            _setInt(CFG_VOLMUSIC, num);
        }
        public int getVolVoice()
        {
            return _getInt(CFG_VOLVOICE);
        }
        public void setVolVoice(int num)
        {
            _setInt(CFG_VOLVOICE, num);
        }
        public int getVolSound()
        {
            return _getInt(CFG_VOLSOUND);
        }
        public void setVolSound(int num)
        {
            _setInt(CFG_VOLSOUND, num);
        }

        public string getIP()
        {
            return _getInt(CFG_IP)+"."+ _getInt(CFG_IP+1)+"."+ _getInt(CFG_IP+2)+"."+ _getInt(CFG_IP+3);
        }
        public void setIP(string ipstr)
        {

            IPAddress tmpIP;
            bool isAlreadyIP = IPAddress.TryParse(ipstr, out tmpIP);
            if (isAlreadyIP)
            {
                string[] ipsegs = ipstr.Split('.');
                if (ipsegs.Length == 4)
                {
                    for (var i = 0; i < 4; i++)
                    {
                        _setInt(CFG_IP + i, byte.Parse(ipsegs[i]));
                    }
                }
            }
        }

        public string getName()
        {
            byte pageValue = config[CFG_PAGES];
            BitArray pages = new BitArray(new byte[] { pageValue });
            char[] name = new char[8];
            for(int i = 0; i < 8; i++)
            {
                name[i] = Name.getChar(config[CFG_NAME + i], Convert.ToByte(pages[i]));
            }
            return new string(name);
        }
        public void setName(string name)
        {
            name = name.PadRight(8);
            BitArray pages = new BitArray(8);
            for(int i = 0; i < 8; i++)
            {
                _setInt(CFG_NAME + i, Name.getIndex(name[i]));
                pages[i] = Convert.ToBoolean(Name.getPage(name[i]));
            }
            byte[] finalPages = new byte[1];
            pages.CopyTo(finalPages,0);
            _setInt(CFG_PAGES, finalPages[0]);
        }

        public UInt16 getPort()
        {
            return BitConverter.ToUInt16(new byte[] { config[CFG_PORT], config[CFG_PORT + 1]},0);
        }
        public void setPort(UInt16 port)
        {
            byte[] portPieces = BitConverter.GetBytes(port);
            _setInt(CFG_PORT, portPieces[0]);
            _setInt(CFG_PORT+1, portPieces[1]);
        }


        private bool _getBool(int loc)
        {
            return config[loc] == 0x01;
        }
        private void _setBool(int loc, bool set)
        {
            config[loc] = (byte)(set ? 0x01 : 0x00);
        }

        private int _getInt(int loc)
        {
            return (int)config[loc];
        }
        private void _setInt(int loc,int num)
        {
            config[loc] = (byte)num;
        }

        public static byte _bitFomByte(byte b, int bitNumber)
        {
            return Convert.ToByte((b & (1 << bitNumber)) != 0);
        }

    }
}
