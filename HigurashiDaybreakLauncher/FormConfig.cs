using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace HigurashiDaybreakConfig
{
    public partial class FormConfig : Form
    {

        private Config cfg;
        private AddressList adl;
        private GameRunner gr;

        public FormConfig()
        {
            InitializeComponent();
        }

        public bool getChat()
        {
            return this.chk_chat.Checked;
        }
        public void setChat(bool set)
        {
            this.chk_chat.Checked = set;
        }

        public bool getShading()
        {
            return this.chk_shading.Checked;
        }
        public void setShading(bool set)
        {
            this.chk_shading.Checked = set;
        }

        public bool getShadows()
        {
            return this.chk_shadows.Checked;
        }
        public void setShadows(bool set)
        {
            this.chk_shadows.Checked = set;
        }

        public bool getTexture()
        {
            return this.chk_texture.Checked;
        }
        public void setTexture(bool set)
        {
            this.chk_texture.Checked = set;
        }

        public bool getScreen()
        {
            return this.chk_screen.Checked;
        }
        public void setScreen(bool set)
        {
            this.chk_screen.Checked = set;
        }

        public int getDelay()
        {
            return (int)this.num_delay.Value;
        }
        public void setDelay(int num)
        {
            if (num < this.num_delay.Minimum)
            {
                num = (int)this.num_delay.Minimum;
            }
            if (num > this.num_delay.Maximum)
            {
                num = (int)this.num_delay.Maximum;
            }
            this.num_delay.Value = num;
        }

        public int getVolmusic()
        {
            int vol = (int)this.tb_volmusic.Value;
            if (vol == this.tb_volmusic.Minimum)
            {
                return 0;
            }
            return vol;
        }
        public void setVolmusic(int num)
        {
            if (num < this.tb_volmusic.Minimum)
            {
                num = (int)this.tb_volmusic.Minimum;
            }
            if (num > this.tb_volmusic.Maximum)
            {
                num = (int)this.tb_volmusic.Maximum;
            }
            this.tb_volmusic.Value = num;
        }
        public int getVolvoice()
        {
            int vol = (int)this.tb_volvoice.Value;
            if(vol == this.tb_volvoice.Minimum)
            {
                return 0;
            }
            return vol;
        }
        public void setVolvoice(int num)
        {
            if (num < this.tb_volvoice.Minimum)
            {
                num = (int)this.tb_volvoice.Minimum;
            }
            if (num > this.tb_volvoice.Maximum)
            {
                num = (int)this.tb_volvoice.Maximum;
            }
            this.tb_volvoice.Value = num;
        }
        public int getVolsound()
        {
            int vol = (int)this.tb_volsound.Value;
            if (vol == this.tb_volsound.Minimum)
            {
                return 0;
            }
            return vol;
        }
        public void setVolsound(int num)
        {
            if (num < this.tb_volsound.Minimum)
            {
                num = (int)this.tb_volsound.Minimum;
            }
            if (num > this.tb_volsound.Maximum)
            {
                num = (int)this.tb_volsound.Maximum;
            }
            this.tb_volsound.Value = num;
        }

        public string getIP()
        {
            return this.txt_ip.Text;
        }
        public void setIP(string txt)
        {
            this.txt_ip.Text = txt;
        }

        public string getName()
        {
            return this.txt_name.Text;
        }
        public void setName(string name)
        {
            if (name.Length > this.txt_name.MaxLength)
            {
                name = name.Substring(0, 8);
            }
            this.txt_name.Text = name;
        }

        public UInt16 getPort()
        {
            UInt16 num = (UInt16)this.num_port.Value;
            if (num < this.num_port.Minimum)
            {
                num = (UInt16)this.num_port.Minimum;
            }
            if (num > this.num_port.Maximum)
            {
                num = (UInt16)this.num_port.Maximum;
            }
            return num;
        }
        public void setPort(UInt16 port)
        {
            this.num_port.Value = port;
        }

        public void setConfig(Config cfg)
        {
            this.cfg = cfg;
            this.loadConfig();
        }

        public void loadConfig()
        {
            this.setChat(cfg.getChat());
            this.setShading(cfg.getShading());
            this.setShadows(cfg.getShadows());
            this.setTexture(cfg.getTexture());
            this.setScreen(cfg.getScreen());
            this.setDelay(cfg.getDelay());
            this.setIP(cfg.getIP());
            this.setName(cfg.getName());
            this.setPort(cfg.getPort());
            this.setVolmusic(cfg.getVolMusic());
            this.setVolvoice(cfg.getVolVoice());
            this.setVolsound(cfg.getVolSound());
        }

        public void setAddressList(AddressList adl)
        {
            this.adl = adl;
            //temp
            string[] ad = adl.getAddresses();
            for(int i = 0; i < ad.Length; i++)
            {
                this.cb_ips.Items.Add(ad[i]);
            }
            if (ad.Length > 0)
            {
                this.cb_ips.SelectedIndex = 0;
            }
        }

        public String getCurrentListAddress()
        {
            if(this.cb_ips.Items.Count == 0)
            {
                return "";
            }
            return this.cb_ips.SelectedItem.ToString();
        }

        public void setGameRunner(GameRunner gr)
        {
            this.gr = gr;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.cfg.setChat(this.getChat());
            this.cfg.setShading(this.getShading());
            this.cfg.setShadows(this.getShadows());
            this.cfg.setTexture(this.getTexture());
            this.cfg.setScreen(this.getScreen());
            this.cfg.setDelay(this.getDelay());
            this.cfg.setIP(this.getIP());
            this.cfg.setName(this.getName());
            this.cfg.setPort(this.getPort());
            this.cfg.setVolMusic(this.getVolmusic());
            this.cfg.setVolVoice(this.getVolvoice());
            this.cfg.setVolSound(this.getVolsound());
            this.cfg.save();
            this.cfg.reload();
            this.loadConfig();
            System.Windows.Forms.MessageBox.Show("Config Saved", "Message");
        }

        private void num_delay_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            return;
        }

        private void btn_copyip_Click(object sender, EventArgs e)
        {
            String addrStr = this.getCurrentListAddress();

            if (addrStr.Length == 0)
            {
                return;
            }

            IPAddress tmpIP;

            bool isAlreadyIP = IPAddress.TryParse(addrStr, out tmpIP);

            if (isAlreadyIP == true)
            {
                this.setIP(addrStr);
            } else
            {

                IPAddress[] addresses = Dns.GetHostEntry(this.getCurrentListAddress()).AddressList;
                if (addresses.Length > 0)
                {
                    this.setIP(addresses[0].ToString());
                }
            }
        }

        private void btn_ips_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", this.adl.getFileLocation());
        }

        private void btn_startdx_Click(object sender, EventArgs e)
        {
            this.gr.runDX();
        }

        private void btn_startday_Click(object sender, EventArgs e)
        {
            this.gr.runDaybreak();
        }

        private void btn_namechars_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is coming soon™.", "Not Yet Implemented");
        }
    }
}
