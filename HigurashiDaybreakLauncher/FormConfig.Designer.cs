namespace HigurashiDaybreakConfig
{
    partial class FormConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
            this.grp_graphics = new System.Windows.Forms.GroupBox();
            this.chk_screen = new System.Windows.Forms.CheckBox();
            this.chk_texture = new System.Windows.Forms.CheckBox();
            this.chk_shadows = new System.Windows.Forms.CheckBox();
            this.chk_shading = new System.Windows.Forms.CheckBox();
            this.grp_multiplayer = new System.Windows.Forms.GroupBox();
            this.btn_copyip = new System.Windows.Forms.Button();
            this.num_port = new System.Windows.Forms.NumericUpDown();
            this.lbl_port = new System.Windows.Forms.Label();
            this.btn_namechars = new System.Windows.Forms.Button();
            this.chk_chat = new System.Windows.Forms.CheckBox();
            this.num_delay = new System.Windows.Forms.NumericUpDown();
            this.lbl_delay = new System.Windows.Forms.Label();
            this.btn_ips = new System.Windows.Forms.Button();
            this.cb_ips = new System.Windows.Forms.ComboBox();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.grp_controls = new System.Windows.Forms.GroupBox();
            this.grp_audio = new System.Windows.Forms.GroupBox();
            this.tb_volsound = new System.Windows.Forms.TrackBar();
            this.lbl_volsound = new System.Windows.Forms.Label();
            this.tb_volvoice = new System.Windows.Forms.TrackBar();
            this.lbl_volvoice = new System.Windows.Forms.Label();
            this.lvl_volmusic = new System.Windows.Forms.Label();
            this.tb_volmusic = new System.Windows.Forms.TrackBar();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_startdx = new System.Windows.Forms.Button();
            this.btn_startday = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_graphics.SuspendLayout();
            this.grp_multiplayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_port)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_delay)).BeginInit();
            this.grp_controls.SuspendLayout();
            this.grp_audio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_volsound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_volvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_volmusic)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_graphics
            // 
            this.grp_graphics.Controls.Add(this.chk_screen);
            this.grp_graphics.Controls.Add(this.chk_texture);
            this.grp_graphics.Controls.Add(this.chk_shadows);
            this.grp_graphics.Controls.Add(this.chk_shading);
            this.grp_graphics.Location = new System.Drawing.Point(12, 12);
            this.grp_graphics.Name = "grp_graphics";
            this.grp_graphics.Size = new System.Drawing.Size(162, 118);
            this.grp_graphics.TabIndex = 0;
            this.grp_graphics.TabStop = false;
            this.grp_graphics.Text = "Graphics Settings";
            // 
            // chk_screen
            // 
            this.chk_screen.AutoSize = true;
            this.chk_screen.Location = new System.Drawing.Point(7, 92);
            this.chk_screen.Name = "chk_screen";
            this.chk_screen.Size = new System.Drawing.Size(74, 17);
            this.chk_screen.TabIndex = 3;
            this.chk_screen.Text = "Fullscreen";
            this.chk_screen.UseVisualStyleBackColor = true;
            // 
            // chk_texture
            // 
            this.chk_texture.AutoSize = true;
            this.chk_texture.Location = new System.Drawing.Point(7, 68);
            this.chk_texture.Name = "chk_texture";
            this.chk_texture.Size = new System.Drawing.Size(86, 17);
            this.chk_texture.TabIndex = 2;
            this.chk_texture.Text = "HQ Textures";
            this.chk_texture.UseVisualStyleBackColor = true;
            // 
            // chk_shadows
            // 
            this.chk_shadows.AutoSize = true;
            this.chk_shadows.Location = new System.Drawing.Point(7, 44);
            this.chk_shadows.Name = "chk_shadows";
            this.chk_shadows.Size = new System.Drawing.Size(106, 17);
            this.chk_shadows.TabIndex = 1;
            this.chk_shadows.Text = "Enable Shadows";
            this.chk_shadows.UseVisualStyleBackColor = true;
            // 
            // chk_shading
            // 
            this.chk_shading.AutoSize = true;
            this.chk_shading.Location = new System.Drawing.Point(7, 20);
            this.chk_shading.Name = "chk_shading";
            this.chk_shading.Size = new System.Drawing.Size(101, 17);
            this.chk_shading.TabIndex = 0;
            this.chk_shading.Text = "Enable Shading";
            this.chk_shading.UseVisualStyleBackColor = true;
            // 
            // grp_multiplayer
            // 
            this.grp_multiplayer.Controls.Add(this.btn_copyip);
            this.grp_multiplayer.Controls.Add(this.num_port);
            this.grp_multiplayer.Controls.Add(this.lbl_port);
            this.grp_multiplayer.Controls.Add(this.btn_namechars);
            this.grp_multiplayer.Controls.Add(this.chk_chat);
            this.grp_multiplayer.Controls.Add(this.num_delay);
            this.grp_multiplayer.Controls.Add(this.lbl_delay);
            this.grp_multiplayer.Controls.Add(this.btn_ips);
            this.grp_multiplayer.Controls.Add(this.cb_ips);
            this.grp_multiplayer.Controls.Add(this.txt_ip);
            this.grp_multiplayer.Controls.Add(this.lbl_ip);
            this.grp_multiplayer.Controls.Add(this.txt_name);
            this.grp_multiplayer.Controls.Add(this.lbl_name);
            this.grp_multiplayer.Location = new System.Drawing.Point(180, 12);
            this.grp_multiplayer.Name = "grp_multiplayer";
            this.grp_multiplayer.Size = new System.Drawing.Size(337, 118);
            this.grp_multiplayer.TabIndex = 1;
            this.grp_multiplayer.TabStop = false;
            this.grp_multiplayer.Text = "Multiplayer Settings";
            // 
            // btn_copyip
            // 
            this.btn_copyip.Location = new System.Drawing.Point(273, 40);
            this.btn_copyip.Name = "btn_copyip";
            this.btn_copyip.Size = new System.Drawing.Size(58, 23);
            this.btn_copyip.TabIndex = 12;
            this.btn_copyip.Text = "Copy IP";
            this.btn_copyip.UseVisualStyleBackColor = true;
            this.btn_copyip.Click += new System.EventHandler(this.btn_copyip_Click);
            // 
            // num_port
            // 
            this.num_port.Location = new System.Drawing.Point(50, 92);
            this.num_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.num_port.Name = "num_port";
            this.num_port.Size = new System.Drawing.Size(100, 20);
            this.num_port.TabIndex = 11;
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(9, 92);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(29, 13);
            this.lbl_port.TabIndex = 10;
            this.lbl_port.Text = "Port:";
            // 
            // btn_namechars
            // 
            this.btn_namechars.Location = new System.Drawing.Point(156, 15);
            this.btn_namechars.Name = "btn_namechars";
            this.btn_namechars.Size = new System.Drawing.Size(100, 23);
            this.btn_namechars.TabIndex = 9;
            this.btn_namechars.Text = "See Characters";
            this.btn_namechars.UseVisualStyleBackColor = true;
            this.btn_namechars.Click += new System.EventHandler(this.btn_namechars_Click);
            // 
            // chk_chat
            // 
            this.chk_chat.AutoSize = true;
            this.chk_chat.Location = new System.Drawing.Point(87, 69);
            this.chk_chat.Name = "chk_chat";
            this.chk_chat.Size = new System.Drawing.Size(84, 17);
            this.chk_chat.TabIndex = 8;
            this.chk_chat.Text = "Enable Chat";
            this.chk_chat.UseVisualStyleBackColor = true;
            // 
            // num_delay
            // 
            this.num_delay.Location = new System.Drawing.Point(50, 68);
            this.num_delay.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.num_delay.Name = "num_delay";
            this.num_delay.Size = new System.Drawing.Size(31, 20);
            this.num_delay.TabIndex = 7;
            this.num_delay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_delay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_delay_KeyDown);
            // 
            // lbl_delay
            // 
            this.lbl_delay.AutoSize = true;
            this.lbl_delay.Location = new System.Drawing.Point(6, 69);
            this.lbl_delay.Name = "lbl_delay";
            this.lbl_delay.Size = new System.Drawing.Size(37, 13);
            this.lbl_delay.TabIndex = 6;
            this.lbl_delay.Text = "Delay:";
            // 
            // btn_ips
            // 
            this.btn_ips.Location = new System.Drawing.Point(273, 14);
            this.btn_ips.Name = "btn_ips";
            this.btn_ips.Size = new System.Drawing.Size(58, 23);
            this.btn_ips.TabIndex = 5;
            this.btn_ips.Text = "Edit IPs";
            this.btn_ips.UseVisualStyleBackColor = true;
            this.btn_ips.Click += new System.EventHandler(this.btn_ips_Click);
            // 
            // cb_ips
            // 
            this.cb_ips.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ips.FormattingEnabled = true;
            this.cb_ips.Location = new System.Drawing.Point(156, 43);
            this.cb_ips.MaxDropDownItems = 100;
            this.cb_ips.Name = "cb_ips";
            this.cb_ips.Size = new System.Drawing.Size(100, 21);
            this.cb_ips.TabIndex = 4;
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(50, 43);
            this.txt_ip.MaxLength = 15;
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(100, 20);
            this.txt_ip.TabIndex = 3;
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Location = new System.Drawing.Point(6, 45);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(20, 13);
            this.lbl_ip.TabIndex = 2;
            this.lbl_ip.Text = "IP:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(50, 17);
            this.txt_name.MaxLength = 8;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(6, 21);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name:";
            // 
            // grp_controls
            // 
            this.grp_controls.Controls.Add(this.label1);
            this.grp_controls.Location = new System.Drawing.Point(12, 189);
            this.grp_controls.Name = "grp_controls";
            this.grp_controls.Size = new System.Drawing.Size(505, 134);
            this.grp_controls.TabIndex = 2;
            this.grp_controls.TabStop = false;
            this.grp_controls.Text = "Controls";
            // 
            // grp_audio
            // 
            this.grp_audio.Controls.Add(this.tb_volsound);
            this.grp_audio.Controls.Add(this.lbl_volsound);
            this.grp_audio.Controls.Add(this.tb_volvoice);
            this.grp_audio.Controls.Add(this.lbl_volvoice);
            this.grp_audio.Controls.Add(this.lvl_volmusic);
            this.grp_audio.Controls.Add(this.tb_volmusic);
            this.grp_audio.Location = new System.Drawing.Point(12, 137);
            this.grp_audio.Name = "grp_audio";
            this.grp_audio.Size = new System.Drawing.Size(505, 46);
            this.grp_audio.TabIndex = 3;
            this.grp_audio.TabStop = false;
            this.grp_audio.Text = "Audio Settings";
            // 
            // tb_volsound
            // 
            this.tb_volsound.AutoSize = false;
            this.tb_volsound.LargeChange = 1;
            this.tb_volsound.Location = new System.Drawing.Point(388, 19);
            this.tb_volsound.Maximum = 100;
            this.tb_volsound.Minimum = 59;
            this.tb_volsound.Name = "tb_volsound";
            this.tb_volsound.Size = new System.Drawing.Size(100, 20);
            this.tb_volsound.TabIndex = 5;
            this.tb_volsound.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_volsound.Value = 61;
            // 
            // lbl_volsound
            // 
            this.lbl_volsound.Location = new System.Drawing.Point(335, 21);
            this.lbl_volsound.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_volsound.Name = "lbl_volsound";
            this.lbl_volsound.Size = new System.Drawing.Size(47, 13);
            this.lbl_volsound.TabIndex = 4;
            this.lbl_volsound.Text = "Sounds:";
            // 
            // tb_volvoice
            // 
            this.tb_volvoice.AutoSize = false;
            this.tb_volvoice.LargeChange = 1;
            this.tb_volvoice.Location = new System.Drawing.Point(218, 19);
            this.tb_volvoice.Maximum = 100;
            this.tb_volvoice.Minimum = 59;
            this.tb_volvoice.Name = "tb_volvoice";
            this.tb_volvoice.Size = new System.Drawing.Size(100, 20);
            this.tb_volvoice.TabIndex = 3;
            this.tb_volvoice.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_volvoice.Value = 61;
            // 
            // lbl_volvoice
            // 
            this.lbl_volvoice.Location = new System.Drawing.Point(165, 21);
            this.lbl_volvoice.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_volvoice.Name = "lbl_volvoice";
            this.lbl_volvoice.Size = new System.Drawing.Size(47, 13);
            this.lbl_volvoice.TabIndex = 2;
            this.lbl_volvoice.Text = "Voices:";
            // 
            // lvl_volmusic
            // 
            this.lvl_volmusic.Location = new System.Drawing.Point(4, 21);
            this.lvl_volmusic.Margin = new System.Windows.Forms.Padding(3);
            this.lvl_volmusic.Name = "lvl_volmusic";
            this.lvl_volmusic.Size = new System.Drawing.Size(40, 13);
            this.lvl_volmusic.TabIndex = 1;
            this.lvl_volmusic.Text = "Music:";
            // 
            // tb_volmusic
            // 
            this.tb_volmusic.AutoSize = false;
            this.tb_volmusic.LargeChange = 1;
            this.tb_volmusic.Location = new System.Drawing.Point(50, 19);
            this.tb_volmusic.Maximum = 100;
            this.tb_volmusic.Minimum = 59;
            this.tb_volmusic.Name = "tb_volmusic";
            this.tb_volmusic.Size = new System.Drawing.Size(100, 20);
            this.tb_volmusic.TabIndex = 0;
            this.tb_volmusic.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_volmusic.Value = 61;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(13, 329);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(280, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_startdx
            // 
            this.btn_startdx.Location = new System.Drawing.Point(400, 329);
            this.btn_startdx.Name = "btn_startdx";
            this.btn_startdx.Size = new System.Drawing.Size(117, 23);
            this.btn_startdx.TabIndex = 5;
            this.btn_startdx.Text = "Start Daybreak DX";
            this.btn_startdx.UseVisualStyleBackColor = true;
            this.btn_startdx.Click += new System.EventHandler(this.btn_startdx_Click);
            // 
            // btn_startday
            // 
            this.btn_startday.Location = new System.Drawing.Point(299, 329);
            this.btn_startday.Name = "btn_startday";
            this.btn_startday.Size = new System.Drawing.Size(95, 23);
            this.btn_startday.TabIndex = 6;
            this.btn_startday.Text = "Start Daybreak";
            this.btn_startday.UseVisualStyleBackColor = true;
            this.btn_startday.Click += new System.EventHandler(this.btn_startday_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "(This section not yet complete)";
            // 
            // FormConfig
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 359);
            this.Controls.Add(this.btn_startday);
            this.Controls.Add(this.btn_startdx);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.grp_audio);
            this.Controls.Add(this.grp_controls);
            this.Controls.Add(this.grp_multiplayer);
            this.Controls.Add(this.grp_graphics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormConfig";
            this.Text = "Higurashi Daybreak Config";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_graphics.ResumeLayout(false);
            this.grp_graphics.PerformLayout();
            this.grp_multiplayer.ResumeLayout(false);
            this.grp_multiplayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_port)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_delay)).EndInit();
            this.grp_controls.ResumeLayout(false);
            this.grp_controls.PerformLayout();
            this.grp_audio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb_volsound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_volvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_volmusic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_graphics;
        private System.Windows.Forms.CheckBox chk_shading;
        private System.Windows.Forms.CheckBox chk_screen;
        private System.Windows.Forms.CheckBox chk_texture;
        private System.Windows.Forms.CheckBox chk_shadows;
        private System.Windows.Forms.GroupBox grp_multiplayer;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.NumericUpDown num_delay;
        private System.Windows.Forms.Label lbl_delay;
        private System.Windows.Forms.Button btn_ips;
        private System.Windows.Forms.ComboBox cb_ips;
        private System.Windows.Forms.Button btn_namechars;
        private System.Windows.Forms.CheckBox chk_chat;
        private System.Windows.Forms.GroupBox grp_audio;
        private System.Windows.Forms.GroupBox grp_controls;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.NumericUpDown num_port;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.TrackBar tb_volmusic;
        private System.Windows.Forms.Label lvl_volmusic;
        private System.Windows.Forms.Label lbl_volvoice;
        private System.Windows.Forms.TrackBar tb_volsound;
        private System.Windows.Forms.Label lbl_volsound;
        private System.Windows.Forms.TrackBar tb_volvoice;
        private System.Windows.Forms.Button btn_copyip;
        private System.Windows.Forms.Button btn_startdx;
        private System.Windows.Forms.Button btn_startday;
        private System.Windows.Forms.Label label1;
    }
}

